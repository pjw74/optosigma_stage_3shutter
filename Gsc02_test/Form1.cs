using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.IO;
using System.Diagnostics;

using Thorlabs.MotionControl.DeviceManagerCLI;
using Thorlabs.MotionControl.GenericMotorCLI;
using Thorlabs.MotionControl.GenericMotorCLI.ControlParameters;
using Thorlabs.MotionControl.GenericMotorCLI.AdvancedMotor;
using Thorlabs.MotionControl.GenericMotorCLI.Settings;
using Thorlabs.MotionControl.GenericMotorCLI.KCubeMotor;

//using Thorlabs.MotionControl.TCube.DCServoCLI;
using Thorlabs.MotionControl.KCube.SolenoidCLI;



namespace Gsc02_test
{

    public partial class Form1 : Form
    {


        SerialPort _serialPort = new SerialPort();

        int x_present_dc, z_present_dc, x_start, z_start;
        decimal posi_x_dc_1 = 0;

        KCubeSolenoid shutter_device1;
        KCubeSolenoid shutter_device2;
        KCubeSolenoid shutter_device3;

        List<KCubeSolenoid> device_list = new List<KCubeSolenoid>();


        string shutter_serialNo1;// = "68250283";
        string shutter_serialNo2;// = "68250366";
        string shutter_serialNo3;// = "68250378";

        CycleSettings settings = new CycleSettings();

        uint signal1, signal2, signal3;

        CycleSettings settings1 = new CycleSettings();
        CycleSettings settings2 = new CycleSettings();
        CycleSettings settings3 = new CycleSettings();

        int delay_time;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] PortNames = SerialPort.GetPortNames();  // 포트 검색.
            foreach (string portnumber in PortNames)
            {
                comboBox1.Items.Add(portnumber);          // 검색한 포트를 콤보박스에 입력. 
            }


            all_open_mode.Checked = true;
            sequential_open_mode.Checked = true;
            sequential_open_mode.Checked = false;

        }



        private void connect_Click(object sender, EventArgs e)
        {
            //Thread readThread = new Thread(Read);            
            //_serialPort = new SerialPort();

            _serialPort.PortName = comboBox1.Text;
            //_serialPort.PortName = "COM3";
            _serialPort.BaudRate = 9600;
            _serialPort.Parity = Parity.None;
            _serialPort.DataBits = 8;
            _serialPort.StopBits = StopBits.One;
            //_serialPort.Handshake = Handshake.None;
            //_serialPort.DataReceived += new SerialDataReceivedEventHandler(_serialPort_DataReceived); //이것이 꼭 필요하다
            // Set the read/write timeouts
            _serialPort.ReadTimeout = -1;
            _serialPort.WriteTimeout = -1;
            _serialPort.NewLine = "\r\n";//"\r";
            _serialPort.ReceivedBytesThreshold = 30;
            _serialPort.DtrEnable = true;
            _serialPort.Handshake = Handshake.RequestToSend;
            _serialPort.ReadBufferSize = 4096;
            _serialPort.WriteBufferSize = 2048;
            _serialPort.RtsEnable = true;


            _serialPort.Open();
            //_continue = true;


            if (_serialPort.IsOpen == true)
            {
                //Console.Write("connected \n");


                _serialPort.DiscardInBuffer();
                _serialPort.DiscardOutBuffer();
                //timer1.Start();
                textBox1.Text = "Optosigma Connected";
                connect.Enabled = false;
                //_serialPort.WriteLine("\n");
                Thread.Sleep(1000);
            }


            if (textBox1.Text == "Optosigma Connected")
            {
                //new System.EventHandler(this.homing_Click);
                //System.EventHandler(this.shut_con1_Click);

                //this.shut_con1.PerformClick();

            }
            else
            {
                MessageBox.Show("Optosigma 연결을 확인하세요");
                return;
            }




        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void homing_Click(object sender, EventArgs e)
        {
            //byte[] a = new byte[10];
            char[] a = new char[10];
            //string b = "Q";
            a[0] = 'H';
            a[1] = ' ';
            a[2] = ':';
            //a = Convert.ToByte(b);
            //string c = a.ToString();
            string ab = "H:W--";

            //_serialPort.Write(a, 0, 1);
            //_serialPort.WriteLine("H:W+-");
            _serialPort.WriteLine("H:W--");

            //_serialPort.

            string closed5 = _serialPort.ReadExisting();



        }



        private void point_move_Click(object sender, EventArgs e)
        {
            //decimal x = x_pitch.Value;
            //decimal z = z_pitch.Value;

            //string str_x = x.ToString();
            //string str_z = z.ToString();
            //string[] data = new string[100];
            //char[] data1 = new char[100];

            char[] x_posi_out = new char[10];
            char[] z_posi_out = new char[10];

            //_serialPort.WriteLine("Q:X");
            //_serialPort.WriteLine("Q:K");
            _serialPort.DiscardInBuffer();
            _serialPort.WriteLine("Q:");

            //int count = _serialPort.BytesToRead;
            //_serialPort.
            //Thread.Sleep(1000);

            //string data1 = _serialPort.ReadLine();
            // byte[] re_val = new byte[9];
            string data2 = "";
            /*
            while (true)
            {
                data2 = _serialPort.ReadExisting();

                if(data2.Length != 0)
                {
                    break;
                }
            }
            */

            data2 = _serialPort.ReadTo("\r");

            data2.CopyTo(0, x_posi_out, 0, 10);
            data2.CopyTo(11, z_posi_out, 0, 10);

            //string data2 = _serialPort.ReadExisting();
            //_serialPort.Read(re_val, 0, 9);
            //string read1 = _serialPort.ReadTo("\r");
            //textBox2.Text = "1";

            //textBox2.Text = data2;
            textBox2.Text = data2;

            string x_result_out, z_result_out;
            decimal x_operation, z_operation;

            x_result_out = new string(x_posi_out);
            x_result_out = x_result_out.Trim();

            x_operation = Convert.ToDecimal(x_result_out);
            x_operation = x_operation / 500;

            z_result_out = new string(z_posi_out);
            z_result_out = z_result_out.Trim();

            z_operation = Convert.ToDecimal(z_result_out);
            z_operation = z_operation / 500;


            label_x_posi.Text = x_operation.ToString() + "mm";
            label_z_posi.Text = z_operation.ToString() + "mm";


            //_serialPort.WriteLine("M:W+P500-P200");
            //_serialPort.WriteLine("G");



            //while(true)
            // {

            //  if()

            //}






        }




        private void jog_left_Click(object sender, EventArgs e)
        {

        }

        private void jog_right_Click(object sender, EventArgs e)
        {

        }

        private void jog_down_Click(object sender, EventArgs e)
        {

        }





        private void jog_left_MouseDown(object sender, MouseEventArgs e)
        {
            _serialPort.WriteLine("J:1-");
            _serialPort.WriteLine("G");
        }

        private void jog_right_MouseDown(object sender, MouseEventArgs e)
        {


            _serialPort.WriteLine("J:1+");
            _serialPort.WriteLine("G");
        }

        private void jog_down_MouseDown(object sender, MouseEventArgs e)
        {
            _serialPort.WriteLine("J:2-");
            _serialPort.WriteLine("G");
        }
        private void jog_up_Click(object sender, EventArgs e)
        {

        }

        private void jog_up_MouseDown(object sender, MouseEventArgs e)
        {
            _serialPort.WriteLine("J:2+");
            _serialPort.WriteLine("G");
        }

        private void jog_left_MouseUp(object sender, MouseEventArgs e)
        {
            _serialPort.WriteLine("L:1");

        }
        private void jog_right_MouseUp(object sender, MouseEventArgs e)
        {
            _serialPort.WriteLine("L:1");

        }
        private void jog_up_MouseUp(object sender, MouseEventArgs e)
        {
            _serialPort.WriteLine("L:2");

        }

        private void jog_down_MouseUp(object sender, MouseEventArgs e)
        {
            _serialPort.WriteLine("L:2");

        }



        private async void button1_Click(object sender, EventArgs e)
        {
            //_serialPort.WriteLine("M:W+P500-P200");
            //_serialPort.WriteLine("G");

            //_serialPort.WriteLine("M:1+P500"); // P500 = 1mm
            //_serialPort.WriteLine("G");
            //_serialPort.WriteLine("M:2+P500");
            //_serialPort.WriteLine("G");


            var task_1 = Task.Factory.StartNew(x_right_move);
            //await task_1;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            _serialPort.WriteLine("M:1-P500"); // P500 = 1mm
            _serialPort.WriteLine("G");
        }








        private async void job_start_Click(object sender, EventArgs e)
        {


            if (all_open_mode.Checked == false && sequential_open_mode.Checked == false)
            {
                MessageBox.Show("스캔 방식을 선택하세요");
                return;

            }

            delay_time = Convert.ToInt32(delay_t.Value) * 1000;


            settings1.OpenTime = (Convert.ToInt32(expo_time_r.Value * 1000));
            settings1.ClosedTime = 1000;
            settings1.NumberOfCycles = 0;

            settings2.OpenTime = (Convert.ToInt32(expo_time_g.Value * 1000));
            settings2.ClosedTime = 1000;
            settings2.NumberOfCycles = 0;

            settings3.OpenTime = (Convert.ToInt32(expo_time_b.Value * 1000));
            settings3.ClosedTime = 1000;
            settings3.NumberOfCycles = 0;

            shutter_device1.SetCycleParams(settings1);
            shutter_device2.SetCycleParams(settings2);
            shutter_device3.SetCycleParams(settings3);

            shutter_device1.SetOperatingMode(SolenoidStatus.OperatingModes.SingleToggle);
            shutter_device2.SetOperatingMode(SolenoidStatus.OperatingModes.SingleToggle);
            shutter_device3.SetOperatingMode(SolenoidStatus.OperatingModes.SingleToggle);



            //if (expo_time_r.Value == 0)
            if (!checkBox_r.Checked)
            {
                shutter_device1.DisableDevice();
            }

            if (!checkBox_g.Checked)
            {
                shutter_device2.DisableDevice();
            }

            if (!checkBox_b.Checked)
            {
                shutter_device3.DisableDevice();
            }








            decimal x_limit = (x_start_point.Value * 500) + (x_pitch.Value * (x_array.Value - 1) * 500);
            decimal z_limit = (z_start_point.Value * 500) + (z_pitch.Value * (z_array.Value - 1) * 500);



            string spd_min_str = speed_min_val.Value.ToString();
            string spd_max_str = speed_max_val.Value.ToString();
            string spd_acc_str = acc_time_val.Value.ToString();


            string spd_input = "D:2S" + spd_min_str + "F" + spd_max_str + "R" + spd_acc_str
                    + "S" + spd_min_str + "F" + spd_max_str + "R" + spd_acc_str;

            _serialPort.WriteLine(spd_input);

            Thread.Sleep(500);


            // if (x_limit > 150010)
            //return;

            if (z_limit > 150083)
            {
                return;
            }

            _serialPort.DiscardInBuffer();
            //_serialPort.DiscardOutBuffer();

            //_serialPort.WriteLine("Q:");
            /*
            string x_present = _serialPort.ReadTo(",");
            x_present = x_present.Trim();
            x_present_dc = Convert.ToDecimal(x_present);

            string z_present = _serialPort.ReadTo(",");
            z_present = z_present.Trim();
            z_present_dc = Convert.ToDecimal(z_present);
            */



            if (sequential_open_mode.Checked == true)
            {
                int i;

                var task_sequence = Task.Run(() =>
                {
                    for (i = 0; i < layer_count_val.Value; i++)
                    {
                        //if (i % 2 == 0)
                        //{
                            var task_left = Task.Factory.StartNew(x_move_sequential_left);
                            task_left.Wait();
                            Thread.Sleep(300);
                        //}
                        //else
                        //{
                        /* 
                        var task_right = Task.Factory.StartNew(x_move_sequential_right);

                            task_right.Wait();

                            Thread.Sleep(300);

                        }
                        */
                        if (i == layer_count_val.Value - 1)
                        {
                            break;
                        }
                        /*
                        if(i % 2 == 0)
                        {
                            //left, right 마다 +- 처리

                            decimal convert_x = x_pitch.Value * 500;
                            convert_x = (int)convert_x;

                            x_present_dc += convert_x;
                        }
                        else
                        {
                            decimal convert_x = x_pitch.Value * 500;
                            convert_x = (int)convert_x;

                            x_present_dc -= convert_x;

                        }
                        */

                        var task_up = Task.Factory.StartNew(z_up_move_sequence);
                        //await task_up;
                        task_up.Wait();
                        Thread.Sleep(300);
                    }
                });
                await task_sequence;
                //task_all.Wait();

                MessageBox.Show("Job Finish");
                start_point.Enabled = true;

            }



            if (all_open_mode.Checked == true)
            {

                //var shutter_check = Task.Factory.StartNew(three_shutter_open);
                //shutter_check.Wait();
                                    //int job_count =
                var task_all = Task.Run(() =>
                {
                    for (int i = 0; i < layer_count_val.Value; i++)
                    {
                        //if (i % 2 == 0)
                        //{
                            var task_left = Task.Factory.StartNew(x_left_move);
                            //var task_right = Task.Factory.StartNew(x_right_move);
                            //var task_right = Task.Run(() => asy;
                            //var task_right1 = Task.(x_right_move);
                            //task_right.GetAwaiter();
                            //Thread.Sleep(300);
                            //await task_right;
                            task_left.Wait();

                            Thread.Sleep(300);
                            //Thread.Sleep(delay_time);

                            //var shutter_check_right = Task.Factory.StartNew(three_shutter_open);
                            //shutter_check_right.Wait();//.Wait();

                            //DoAsync();
                        //}
                        //else
                        //{
                        //    var task_right = Task.Factory.StartNew(x_right_move);
                            //Thread.Sleep(300);
                            //await task_left;
                        //    task_right.Wait();

                        //    Thread.Sleep(300);
                            //Thread.Sleep(delay_time);


                            //var shutter_check_left = Task.Factory.StartNew(three_shutter_open);
                            //shutter_check_left.Wait();//.Wait();
                        //}

                        if (i == layer_count_val.Value - 1)
                        {
                            break;
                        }

                        var task_up = Task.Factory.StartNew(z_up_move_sequence);
                        //await task_up;
                        task_up.Wait();

                        Thread.Sleep(300);
                        //  Thread.Sleep(delay_time);

                        // var shutter_check_up = Task.Factory.StartNew(three_shutter_open);
                        // shutter_check_up.Wait();//.Wait();

                        //task_up = Task.Factory.StartNew(z_up_move);
                        //await task_up;
                        //task_up.Wait();                          


                    }
                });
                await task_all;
                //task_all.Wait();

                MessageBox.Show("Job Finish");

                start_point.Enabled = true;

            }

        }

        private void x_left_move()
        {
            x_present_dc = 0;
            x_present_dc = x_start;
            int convert_x = Convert.ToInt32(x_pitch.Value * 500);

            //string x_oper_left;
            string x_val = convert_x.ToString();

            for (int i = 0; i < x_array.Value; i++)
            {

                Thread.Sleep(delay_time);

                var shutter_check_right = Task.Factory.StartNew(three_shutter_open);
                shutter_check_right.Wait();

                //convert_x = Convert.ToInt16(convert_x);

                if (i != x_array.Value - 1)
                {

                    x_present_dc -= convert_x;
                    //x_oper_left = x_present_dc.ToString();

                    string x_left_command = ("M:1-P" + x_val);

                    _serialPort.WriteLine(x_left_command); // P500 = 1mm
                    _serialPort.WriteLine("G");

                    Thread.Sleep(300);

                    //MessageBox.Show("1");
                    //posi_x_dc_1 = x_present_dc;

                    posi_check_method(x_present_dc, z_present_dc);
                }
                else
                {
                    break;
                }

            }
        }


        private async void x_move_sequential_left()
        {
            string x_oper_left;
            //decimal convert_x = x_pitch.Value * 500; //0.07
            //int covert_x_int = Convert.ToInt16(convert_x);

            int convert_x = Convert.ToInt32(x_pitch.Value * 500);


            string x_val = convert_x.ToString();
            string x_left_command;

            x_present_dc = 0;
            x_present_dc = x_start;

            // x_array 10개 3번을 10번
            // 30


            for (int i = 0; i < x_array.Value; i++)
            {

                //string x_left_command = ("M:1-P" + x_val);
                Thread.Sleep(delay_time);
                var shutter_r = Task.Factory.StartNew(shutter1_oneshot);
                shutter_r.Wait();
                Thread.Sleep(300);

                x_present_dc -= convert_x;
                //x_oper_left = x_present_dc.ToString();
                x_left_command = ("M:1-P" + x_val);
                _serialPort.WriteLine(x_left_command); // P500 = 1mm
                _serialPort.WriteLine("G");
                x_left_command = "";
                Thread.Sleep(300);

                posi_check_method(x_present_dc, z_present_dc);

                Thread.Sleep(delay_time);
                var shutter_g = Task.Factory.StartNew(shutter2_oneshot);
                shutter_g.Wait();
                Thread.Sleep(300);

                x_present_dc -= convert_x;
                //x_oper_left = x_present_dc.ToString();
                x_left_command = ("M:1-P" + x_val);
                _serialPort.WriteLine(x_left_command); // P500 = 1mm
                _serialPort.WriteLine("G");
                x_left_command = "";
                Thread.Sleep(300);

                posi_check_method(x_present_dc, z_present_dc);

                Thread.Sleep(delay_time);
                var shutter_b = Task.Factory.StartNew(shutter3_oneshot);
                shutter_b.Wait();
                Thread.Sleep(300);

                x_present_dc -= convert_x;
                //x_oper_left = x_present_dc.ToString();
                x_left_command = ("M:1-P" + x_val);
                _serialPort.WriteLine(x_left_command); // P500 = 1mm
                _serialPort.WriteLine("G");
                x_left_command = "";
                Thread.Sleep(300);

                posi_check_method(x_present_dc, z_present_dc);

            }
        }


        private void z_up_move_sequence()
        {
            int x_start_posi = 0;

            int convert_x = Convert.ToInt32(x_pitch.Value * 500);
            int convert_z = Convert.ToInt32(z_pitch.Value * 500);

            //convert_z = Convert.ToInt16(convert_z);

            string x_start_posi_str;
            string z_val = convert_z.ToString();

            if (all_open_mode.Checked == true)
            {
                x_start_posi = convert_x * (Convert.ToInt32(x_array.Value) - 1);
            }

            if (sequential_open_mode.Checked == true)
            {
                x_start_posi = convert_x * 3 * (Convert.ToInt32(x_array.Value) - 1);
            }

            x_start_posi_str = x_start_posi.ToString();


            for (int i = 0; i < z_array.Value; i++)
            {


                z_present_dc += convert_z;

                _serialPort.WriteLine("M:W" + "+P" + x_start_posi_str + "+P" + z_val);
                _serialPort.WriteLine("G");
                Thread.Sleep(300);



                // decimal convert_x0 = x_pitch.Value * 500;
                // convert_x0 = Convert.ToInt32(convert_x0);

                // x_present_dc += convert_x0;
                // x_oper_right = x_present_dc.ToString();

                //string x_val0 = convert_x0.ToString();
                //int x = Convert.ToInt16(x_array.Value) - 1;
                //decimal x_d = x_pitch.Value * 500;
                //int x_d_int = Convert.ToInt16(x_d);
                //x = x * x_d_int;
                //x_pitch.Value
                //string x_right_command0 = ("M:1+P" + x.ToString());
                //string z_up_command = ("M:2+P" + z_val);



                //string z_up_command = ("M:2+P" + z_val);
                //_serialPort.WriteLine(z_up_command); // P500 = 1mm
                //_serialPort.WriteLine("G");
                //Thread.Sleep(300);

                posi_check_method(x_start, z_present_dc);

                //Thread.Sleep(delay_time);
                //var shutter_check_right = Task.Factory.StartNew(three_shutter_open);
                //shutter_check_right.Wait();
            }
        }





        /*
        public async Task<long> DoAsync(long id)
        {
            return await Task.Run(() =>             
            { 
                return DoSync(id); 
            });
        }
        */
        



        public void x_right_move()
        {
            string x_oper_right;

            for (int i = 1; i < x_array.Value; i++)
            {
                decimal convert_x = x_pitch.Value * 500;
                convert_x = Convert.ToInt32(convert_x);

                //x_present_dc += convert_x;
                x_oper_right = x_present_dc.ToString();

                string x_val = convert_x.ToString();

                string x_right_command = ("M:1+P" + x_val);
                _serialPort.WriteLine(x_right_command); // P500 = 1mm
                _serialPort.WriteLine("G");
                Thread.Sleep(500);

                //posi_x_dc_1 = x_present_dc;

                while (true)
                {
                    Thread.Sleep(500);

                    _serialPort.DiscardInBuffer();
                    _serialPort.DiscardOutBuffer();
                    _serialPort.WriteLine("Q:");

                    Thread.Sleep(500);

                    string posi_x = _serialPort.ReadTo(",");
                    posi_x = posi_x.Trim();

                    Thread.Sleep(300);

                    if (posi_x == x_oper_right)
                    {

                        break;//_serialPort.WriteLine("L:1");
                    }
                }

                Thread.Sleep(delay_time);

                var shutter_check_right = Task.Factory.StartNew(three_shutter_open);
                shutter_check_right.Wait();
            }
        }

        


        private void z_up_move()
        {
            for (int i = 0; i < z_array.Value; i++)
            {
                decimal convert_z = z_pitch.Value * 500;
                convert_z = Convert.ToInt32(convert_z);

                //z_present_dc += convert_z;

                string z_val = convert_z.ToString();

                string z_up_command = ("M:2+P" + z_val);
                _serialPort.WriteLine(z_up_command); // P500 = 1mm
                _serialPort.WriteLine("G");
                Thread.Sleep(300);

                while (true)
                {
                    Thread.Sleep(300);

                    _serialPort.DiscardInBuffer();
                    _serialPort.WriteLine("Q:");

                    string posi_x = _serialPort.ReadTo(",");
                    posi_x = posi_x.Trim();

                    //_serialPort.read
                    string posi_z = _serialPort.ReadTo(",");
                    posi_z = posi_z.Trim();

                    Thread.Sleep(300);

                    if (posi_z == z_present_dc.ToString())
                    {
                        break;//_serialPort.WriteLine("L:1");
                    }
                }

                //Thread.Sleep(delay_time);
                //var shutter_check_right = Task.Factory.StartNew(three_shutter_open);
                //shutter_check_right.Wait();
            }
        }

        

        //     public void x_right_move_sequential()


        private void posi_check_method(decimal x_posi_para, decimal z_posi_para)
        {
            char[] x_posi_out = new char[10];
            char[] z_posi_out = new char[10];

            string x_posi_st, z_posi_st;
            decimal x_posi_deci, z_posi_deci;

            while (true)
            {
                Thread.Sleep(500);

                _serialPort.DiscardInBuffer();
                _serialPort.WriteLine("Q:");

                string data2 = "";

                data2 = _serialPort.ReadTo("\r");

                data2.CopyTo(0, x_posi_out, 0, 10);
                data2.CopyTo(11, z_posi_out, 0, 10);

                

                x_posi_st = new string(x_posi_out);
                x_posi_st = x_posi_st.Trim();
                
                z_posi_st = new string(z_posi_out);
                z_posi_st = z_posi_st.Trim();

                x_posi_deci = Convert.ToDecimal(x_posi_st);
                z_posi_deci = Convert.ToDecimal(z_posi_st);

                //if (posi_x == x_present_dc.ToString()) 
                if (x_posi_para == x_posi_deci && z_posi_para == z_posi_deci)
                {                 
                    break;//_serialPort.WriteLine("L:1");
                }
            }

            /*
            this.Invoke(new Action(delegate ()
            {
                //label_x_posi.Text.Replace("", x_posi_st + "mm");
                //label_x_posi.Text = "";
                //label_z_posi.Text = "";
                label_x_posi.Text = x_posi_st + "mm";
                label_z_posi.Text = z_posi_st + "mm";

            }));
           */
            
            x_posi_deci = 0;
            z_posi_deci = 0;

            x_posi_st = "";
            z_posi_st = "";

            Array.Clear(x_posi_out, 0, x_posi_out.Length);
            Array.Clear(z_posi_out, 0, z_posi_out.Length);
        }


       


        /*
        private void shutter_list(int i)
        {
            switch (i)
            {
                case:
                    1
                case:
                    2
                case:
                    3                        
            }
        }
        */

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.DiscardInBuffer();
                _serialPort.DiscardOutBuffer();
                _serialPort.Close();
            }

            if(all_open_mode.Checked)
            {
                all_open_mode.Checked = true;
            }
            else
            {
                //sequential_open_mode
                sequential_open_mode.Checked = true;

            }






        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //_serialPort.DiscardInBuffer();
            _serialPort.WriteLine("Q:");

            string posi_x = _serialPort.ReadTo(",");
            posi_x = posi_x.Trim();

            //_serialPort.read
            string posi_z = _serialPort.ReadTo(",");
            posi_z = posi_z.Trim();

            this.Invoke(new Action(delegate ()
            {
                label_x_posi.Text = posi_x;
                label_z_posi.Text = posi_z;
            }));

        }

        private async void start_point_Click(object sender, EventArgs e)
        {

            x_present_dc = 0;
            z_present_dc = 0;

            char[] x_posi_out = new char[10];
            char[] z_posi_out = new char[10];

            string spd_min_str = speed_min_val.Value.ToString();
            string spd_max_str = speed_max_val.Value.ToString();
            string spd_acc_str = acc_time_val.Value.ToString();

            string spd_input = "D:2S" + spd_min_str + "F" + spd_max_str + "R" + spd_acc_str
                    + "S" + spd_min_str + "F" + spd_max_str + "R" + spd_acc_str;

            _serialPort.WriteLine(spd_input);

            Thread.Sleep(300);
            //string x_start_posi = x_start_point.Value.ToString();
            //string z_start_posi = z_start_point.Value.ToString();

            string sign_x, sign_z;

            int x_start_dc = Convert.ToInt32(x_start_point.Value * 500);
            int z_start_dc = Convert.ToInt32(z_start_point.Value * 500);

            x_start = x_start_dc;
            z_start = z_start_dc;

            x_present_dc = x_start_dc;
            z_present_dc = z_start_dc;

            /*
            _serialPort.DiscardInBuffer();
            _serialPort.WriteLine("Q:");

            string posi_x = _serialPort.ReadTo(",");
            posi_x = posi_x.Trim();

            decimal x_present = Convert.ToDecimal(posi_x);

            string posi_z = _serialPort.ReadTo(",");
            posi_z = posi_z.Trim();
            decimal z_present = Convert.ToDecimal(posi_z);
            */

            _serialPort.DiscardInBuffer();
            _serialPort.WriteLine("Q:");

            string data2 = "";

            string x_result_out, z_result_out;
            decimal x_present, z_present;

            data2 = _serialPort.ReadTo("\r");

            data2.CopyTo(0, x_posi_out, 0, 10);
            data2.CopyTo(11, z_posi_out, 0, 10);

            x_result_out = new string(x_posi_out);
            x_result_out = x_result_out.Trim();

            x_present = Convert.ToDecimal(x_result_out);
            //x_operation = x_operation / 500;

            z_result_out = new string(z_posi_out);
            z_result_out = z_result_out.Trim();

            z_present = Convert.ToDecimal(z_result_out);
            //z_operation = z_operation / 500;

            decimal x_result = x_start_dc - x_present;

            if (x_result < 0)
            {
                sign_x = "-";
            }
            else
            {
                sign_x = "+";
            }

            x_result = Math.Abs(x_result);
            x_result = Convert.ToInt32(x_result);
            string x_result2 = x_result.ToString();
            //pre:0 to start:100

            //100 -> 200  +100
            //200 -> 100  -100

            decimal z_result = z_start_dc - z_present;

            if (z_result < 0)
            {
                sign_z = "-";
            }
            else
            {
                sign_z = "+";
            }

            z_result = Math.Abs(z_result);
            z_result = Convert.ToInt32(z_result);
            string z_result2 = z_result.ToString();
            //pre:0 to start:100

            //100 -> 200  +100
            //200 -> 100  -100

            _serialPort.WriteLine("M:W" + sign_x + "P" + x_result2 + sign_z + "P" + z_result2);
            _serialPort.WriteLine("G");

            //_serialPort.WriteLine("M:1" + sign + "P" + x_result2);
            //_serialPort.WriteLine("G");

            //_serialPort.WriteLine("M:1" + "+-??" + "P" + "??");

            //_serialPort.WriteLine("M:W" + "+-??" + "P" + "??" + "-+??" + "P" + "??");
            //stage 1              stage2


            var task_complete_check = Task.Run(() =>
            {

                posi_check_method(x_present_dc, z_present_dc);      
                
            });
            task_complete_check.Wait();

            MessageBox.Show("Start Point 이동 완료");

            //this.Invoke(new Action(delegate ()
            //{
                //start_point.Enabled = false;

            //}));

            //Thread.Sleep(300);



        }




        private void speed_set_Click(object sender, EventArgs e)
        {
            //if (radioButton1.Checked)
            //{
            //    _serialPort.WriteLine("D:2S500F1000R200S500F1000R200");
            //}                              //min: 500, max: 1000, R: 200
            //if (radioButton2.Checked)
            //{
            //_serialPort.WriteLine("D:2S800F2000R200S800F2000R200");
            //800    2000     200



            string spd_min_str = speed_min_val.Value.ToString();
            string spd_max_str = speed_max_val.Value.ToString();
            string spd_acc_str = acc_time_val.Value.ToString();


            string spd_input = "D:2S" + spd_min_str + "F" + spd_max_str + "R" + spd_acc_str
                    + "S" + spd_min_str + "F" + spd_max_str + "R" + spd_acc_str;

            _serialPort.WriteLine(spd_input);



            //
            //}
            //if (radioButton3.Checked)
            //{
            //    _serialPort.WriteLine("D:2S3000F8000R250S3000F8000R250");
            //}                //mix: 3000, max: 8000, R: 250


            //D: 2  S100  F1000  R200  S100  F1000  R200

            //   2  S100  F1000  R0    S100  F1000  R0     
            //50~20000           50~20000
            //

        }

        private void emer_stop_Click(object sender, EventArgs e)
        {
            this.Invoke(new Action(delegate ()
            {
                _serialPort.WriteLine("L:E"); // P500 = 1mm
            }));

        }

        private void x_start_point_KeyDown(object sender, KeyEventArgs e)
        {
            //this.x_start_point.Focus();
            //this.x_start_point.se

        }





        private void z_start_point_Enter(object sender, EventArgs e)
        {
            z_start_point.Select(0, z_start_point.Text.Length);
        }

        private void x_start_point_MouseDown(object sender, MouseEventArgs e)
        {
            x_start_point.Select(0, x_start_point.Text.Length);

        }

        private void x_start_point_Enter(object sender, EventArgs e)
        {
            x_start_point.Select(0, x_start_point.Text.Length);

        }

        private void x_pitch_Enter(object sender, EventArgs e)
        {

            x_pitch.Select(0, x_pitch.Text.Length);
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }


        private void z_pitch_Enter(object sender, EventArgs e)
        {
            z_pitch.Select(0, z_pitch.Text.Length);

        }


        /*
        private void z_down_move()
        {
            for (int i = 0; i < z_array.Value - 1; i++)
            {
                decimal convert_z = z_pitch.Value * 500;

                string z_val = convert_z.ToString();

                string z_down_command = ("M:2-P" + z_val);
                _serialPort.WriteLine(z_down_command); // P500 = 1mm
                _serialPort.WriteLine("G");
            }
        }
        */

        private void serial_number_load()
        {
            string savePath = @"./Serial Number.txt";
            //all_serial = System.IO.File.ReadAllLines(savePath);

            string a = System.IO.File.ReadAllText(savePath);


            //string shut_serial1;// = "68250283";
            //string shut_serial2;// = "68250366";
            //string shut_serial3;// = "68250378";

            //string[] serial = new string[20];
            //all_serial.CopyTo(serial, 0);



            string[] all_serial1 = a.Split(new char[] { ',' });

            //int c = all_serial1.Count < "6825" > ();

            //string[] shutter_serial_num = new string[all_serial1.Length];

            for (int i = 0; i < all_serial1.Length; i++)
            {
                if (all_serial1[i].Contains(" "))
                {
                    all_serial1[i] = all_serial1[i].Trim();

                }
                if (all_serial1[i].Contains("6825"))
                {

                    //shutter_serial_num[i] = all_serial1[i].Trim();
                    serial_count(i, all_serial1[i]);


                    //shutter_serialNo2 = all_serial1[1].Trim();
                    //shutter_serialNo3 = all_serial1[2].Trim();
                }
                else
                {
                    //stage_serialNo = all_serial1[i];
                    //stage_serialNo.Trim();
                }

            }



            //shutter_serialNo1 = all_serial1[0].Trim();
            //shutter_serialNo2 = all_serial1[1].Trim();
            //shutter_serialNo3 = all_serial1[2].Trim();

        }



        private void serial_count(int i, string shut_count)
        {
            shut_count.Trim();

            switch (i)
            {
                case 0:
                    shutter_serialNo1 = shut_count;
                    break;
                case 1:
                    shutter_serialNo2 = shut_count;
                    break;
                case 2:
                    shutter_serialNo3 = shut_count;
                    break;


            }
            //return;
        }

        private void shut_con1_Click(object sender, EventArgs e)
        {

            serial_number_load();



            try
            {
                // Tell the device manager to get the list of all devices connected to the computer
                DeviceManagerCLI.BuildDeviceList();
            }
            catch (Exception ex)
            {
                // An error occurred - see ex for details
                Console.WriteLine("Exception raised by BuildDeviceList {0}", ex);
                //Console.ReadKey();
                return;
            }

            // Get available KCube Solenoid and check our serial number is correct - by using the device prefix
            // (i.e. for serial number 68000123, the device prefix is 68)
            List<string> serialNumbers = DeviceManagerCLI.GetDeviceList(KCubeSolenoid.DevicePrefix);

            if (!serialNumbers.Contains(shutter_serialNo1))
            {
                // The requested serial number is not a KSC or is not connected
                Console.WriteLine("{0} is not a valid serial number", shutter_serialNo1);
                //Console.ReadKey();
                return;
            }

            // Create the device
            shutter_device1 = KCubeSolenoid.CreateKCubeSolenoid(shutter_serialNo1);
            shutter_device2 = KCubeSolenoid.CreateKCubeSolenoid(shutter_serialNo2);
            shutter_device3 = KCubeSolenoid.CreateKCubeSolenoid(shutter_serialNo3);

            if (shutter_device1 == null)
            {
                // An error occured
                Console.WriteLine("{0} is not a KCubeSolenoid", shutter_serialNo1);

                //Console.ReadKey();
                return;
            }

            // Open a connection to the device.
            try
            {
                Console.WriteLine("Opening device {0}", shutter_serialNo1);

                shutter_device1.Connect(shutter_serialNo1);
                shutter_device2.Connect(shutter_serialNo2);
                shutter_device3.Connect(shutter_serialNo3);

            }
            catch (Exception)
            {
                // Connection failed
                Console.WriteLine("Failed to open device {0}", shutter_serialNo1);
                // Console.ReadKey();
                return;
            }

            // Wait for the device settings to initialize - timeout 5000ms
            if (!shutter_device1.IsSettingsInitialized())
            {
                try
                {
                    shutter_device1.WaitForSettingsInitialized(5000);
                }
                catch (Exception)
                {
                    Console.WriteLine("Settings failed to initialize");
                }
            }

            if (!shutter_device2.IsSettingsInitialized())
            {
                try
                {
                    shutter_device2.WaitForSettingsInitialized(5000);
                }
                catch (Exception)
                {
                    Console.WriteLine("Settings failed to initialize");
                }
            }

            if (!shutter_device3.IsSettingsInitialized())
            {
                try
                {
                    shutter_device3.WaitForSettingsInitialized(5000);
                }
                catch (Exception)
                {
                    Console.WriteLine("Settings failed to initialize");
                }
            }
            // Display info about device
            DeviceInfo deviceInfo1 = shutter_device1.GetDeviceInfo();
            DeviceInfo deviceInfo2 = shutter_device2.GetDeviceInfo();
            DeviceInfo deviceInfo3 = shutter_device3.GetDeviceInfo();

            Console.WriteLine("Device {0} = {1}", deviceInfo1.SerialNumber, deviceInfo1.Name);
            Console.WriteLine("Device {0} = {1}", deviceInfo2.SerialNumber, deviceInfo2.Name);
            Console.WriteLine("Device {0} = {1}", deviceInfo3.SerialNumber, deviceInfo3.Name);

            // Start the device polling
            // The polling loop requests regular status requests to the motor to ensure the program keeps track of the device. 
            shutter_device1.StartPolling(250);
            shutter_device2.StartPolling(250);
            shutter_device3.StartPolling(250);

            // Needs a delay so that the current enabled state can be obtained
            Thread.Sleep(500);
            // Enable the channel otherwise any move is ignored 
            shutter_device1.EnableDevice();
            shutter_device2.EnableDevice();
            shutter_device3.EnableDevice();
            // Needs a delay to give time for the device to be enabled
            Thread.Sleep(500);

            // get Device Configuration
            SolenoidConfiguration solenoidConfiguration1 = shutter_device1.GetSolenoidConfiguration(shutter_serialNo1);
            ThorlabsKCubeSolenoidSettings currentDeviceSettings1 = ThorlabsKCubeSolenoidSettings.GetSettings(solenoidConfiguration1);

            SolenoidConfiguration solenoidConfiguration2 = shutter_device2.GetSolenoidConfiguration(shutter_serialNo2);
            ThorlabsKCubeSolenoidSettings currentDeviceSettings2 = ThorlabsKCubeSolenoidSettings.GetSettings(solenoidConfiguration2);

            SolenoidConfiguration solenoidConfiguration3 = shutter_device3.GetSolenoidConfiguration(shutter_serialNo3);
            ThorlabsKCubeSolenoidSettings currentDeviceSettings3 = ThorlabsKCubeSolenoidSettings.GetSettings(solenoidConfiguration3);




            bool shutter1_connect = DeviceManagerCLI.IsDeviceConnected(shutter_serialNo1);
            bool shutter2_connect = DeviceManagerCLI.IsDeviceConnected(shutter_serialNo2);
            bool shutter3_connect = DeviceManagerCLI.IsDeviceConnected(shutter_serialNo3);

            if (shutter1_connect && shutter2_connect && shutter3_connect == true)
            {
                textBox3.Text = ("Shutter Connected");

                // shut_con.Enabled = false;
                shut_con1.Enabled = false;

                if (expo_time_r.Value == 0 && expo_time_g.Value == 0 && expo_time_b.Value == 0)
                {
                    MessageBox.Show("노출 시간을 설정하세요!");

                }
                //shutter_con1.Enabled = false;
            }
        }

        private void shut_sel_Click(object sender, EventArgs e)
        {
            if (!checkBox_r.Checked)
            {
                shutter_device1.DisableDevice();
            }

            if (!checkBox_g.Checked)
            {
                shutter_device2.DisableDevice();
            }
            if (!checkBox_b.Checked)
            {
                shutter_device3.DisableDevice();
            }
            //checkBox_g
            //checkBox_b
        }



        private void one_open_Click(object sender, EventArgs e)
        {

            shutter_device1.SetOperatingMode(SolenoidStatus.OperatingModes.Manual);
            shutter_device1.SetOperatingState(SolenoidStatus.OperatingStates.Active);
        }

        private void one_close_Click(object sender, EventArgs e)
        {

            shutter_device1.SetOperatingMode(SolenoidStatus.OperatingModes.Manual);
            shutter_device1.SetOperatingState(SolenoidStatus.OperatingStates.Inactive);
        }

        private void two_open_Click(object sender, EventArgs e)
        {

            shutter_device2.SetOperatingMode(SolenoidStatus.OperatingModes.Manual);
            shutter_device2.SetOperatingState(SolenoidStatus.OperatingStates.Active);
        }

        private void two_close_Click(object sender, EventArgs e)
        {

            shutter_device2.SetOperatingMode(SolenoidStatus.OperatingModes.Manual);
            shutter_device2.SetOperatingState(SolenoidStatus.OperatingStates.Inactive);
        }

        private void three_open_Click(object sender, EventArgs e)
        {

            shutter_device3.SetOperatingMode(SolenoidStatus.OperatingModes.Manual);
            shutter_device3.SetOperatingState(SolenoidStatus.OperatingStates.Active);
        }



        private void three_close_Click(object sender, EventArgs e)
        {

            shutter_device3.SetOperatingMode(SolenoidStatus.OperatingModes.Manual);
            shutter_device3.SetOperatingState(SolenoidStatus.OperatingStates.Inactive);
        }

        private void all_shut_open_Click(object sender, EventArgs e)
        {

            shutter_device1.SetOperatingMode(SolenoidStatus.OperatingModes.Manual);
            shutter_device2.SetOperatingMode(SolenoidStatus.OperatingModes.Manual);
            shutter_device3.SetOperatingMode(SolenoidStatus.OperatingModes.Manual);

            shutter_device1.SetOperatingState(SolenoidStatus.OperatingStates.Active);
            shutter_device2.SetOperatingState(SolenoidStatus.OperatingStates.Active);
            shutter_device3.SetOperatingState(SolenoidStatus.OperatingStates.Active);
        }

        private void all_shut_close_Click(object sender, EventArgs e)
        {

            shutter_device1.SetOperatingMode(SolenoidStatus.OperatingModes.Manual);
            shutter_device2.SetOperatingMode(SolenoidStatus.OperatingModes.Manual);
            shutter_device3.SetOperatingMode(SolenoidStatus.OperatingModes.Manual);

            shutter_device1.SetOperatingState(SolenoidStatus.OperatingStates.Inactive);
            shutter_device2.SetOperatingState(SolenoidStatus.OperatingStates.Inactive);
            shutter_device3.SetOperatingState(SolenoidStatus.OperatingStates.Inactive);
        }


        private async void one_shut_open_Click(object sender, EventArgs e)
        {
            settings1.OpenTime = (Convert.ToInt32(expo_time_r.Value) * 1000);
            settings1.ClosedTime = 1000;
            settings1.NumberOfCycles = 0;

            settings2.OpenTime = (Convert.ToInt32(expo_time_g.Value) * 1000);
            settings2.ClosedTime = 1000;
            settings2.NumberOfCycles = 0;

            settings3.OpenTime = (Convert.ToInt32(expo_time_b.Value) * 1000);
            settings3.ClosedTime = 1000;
            settings3.NumberOfCycles = 0;

            shutter_device1.SetCycleParams(settings1);
            shutter_device2.SetCycleParams(settings2);
            shutter_device3.SetCycleParams(settings3);

            shutter_device1.SetOperatingMode(SolenoidStatus.OperatingModes.SingleToggle);
            shutter_device2.SetOperatingMode(SolenoidStatus.OperatingModes.SingleToggle);
            shutter_device3.SetOperatingMode(SolenoidStatus.OperatingModes.SingleToggle);





            //    List<int> list = new List<int>();



            if (expo_time_r.Value == 0)
            {
                shutter_device1.DisableDevice();
            }

            if (expo_time_g.Value == 0)
            {
                shutter_device2.DisableDevice();
            }

            if (expo_time_b.Value == 0)
            {
                shutter_device3.DisableDevice();
            }


            if (settings1.OpenTime > 0 && settings2.OpenTime > 0 && settings3.OpenTime > 0)
            {
                var shutter1 = Task.Factory.StartNew(shutter1_oneshot);
                var shutter2 = Task.Factory.StartNew(shutter2_oneshot);
                var shutter3 = Task.Factory.StartNew(shutter3_oneshot);

                await shutter1;
                await shutter2;
                await shutter3;
            }

            else if (settings1.OpenTime > 0 && settings2.OpenTime == 0 && settings3.OpenTime == 0)
            {
                var shutter1 = Task.Factory.StartNew(shutter1_oneshot);
                await shutter1;
            }

            else if (settings1.OpenTime == 0 && settings2.OpenTime > 0 && settings3.OpenTime == 0)
            {
                var shutter2 = Task.Factory.StartNew(shutter2_oneshot);
                await shutter2;
            }

            else if (settings1.OpenTime == 0 && settings2.OpenTime == 0 && settings3.OpenTime > 0)
            {
                var shutter3 = Task.Factory.StartNew(shutter3_oneshot);
                await shutter3;
            }






            else if (settings1.OpenTime > 0 && settings2.OpenTime > 0 && settings3.OpenTime == 0)
            {
                var shutter1 = Task.Factory.StartNew(shutter1_oneshot);
                var shutter2 = Task.Factory.StartNew(shutter2_oneshot);

                await shutter1;
                await shutter2;


            }

            else if (settings1.OpenTime == 0 && settings2.OpenTime > 0 && settings3.OpenTime > 0)
            {
                var shutter2 = Task.Factory.StartNew(shutter2_oneshot);
                var shutter3 = Task.Factory.StartNew(shutter3_oneshot);

                await shutter2;
                await shutter3;

            }

            else if (settings1.OpenTime > 0 && settings2.OpenTime == 0 && settings3.OpenTime > 0)
            {
                var shutter1 = Task.Factory.StartNew(shutter1_oneshot);
                var shutter3 = Task.Factory.StartNew(shutter3_oneshot);

                await shutter1;
                await shutter3;
            }

            else if (settings1.OpenTime == 0 && settings2.OpenTime == 0 && settings3.OpenTime == 0)
            {
                MessageBox.Show("시간을 설정하세요!");
            }

        }


        private void shutter1_oneshot()
        {
            shutter_device1.SetOperatingState(SolenoidStatus.OperatingStates.Active);

            //Thread.Sleep(settings.OpenTime / 2);
            //Thread.Sleep(200);
            Thread.Sleep(settings1.OpenTime / 2);

            while (true)
            {
                signal1 = shutter_device1.GetStatusBits();

                if (signal1 == 8192)
                    break;
                else
                {
                    Thread.Sleep(100);
                }
            }
        }

        private void shutter2_oneshot()
        {
            shutter_device2.SetOperatingState(SolenoidStatus.OperatingStates.Active);

            //Thread.Sleep(settings.OpenTime / 2);
            //Thread.Sleep(200);
            Thread.Sleep(settings2.OpenTime / 2);

            while (true)
            {
                signal2 = shutter_device2.GetStatusBits();

                if (signal2 == 8192)
                    break;
                else
                {
                    Thread.Sleep(100);
                }
            }
        }



        private void shutter3_oneshot()
        {
            shutter_device3.SetOperatingState(SolenoidStatus.OperatingStates.Active);
            //Thread.Sleep(200);

            Thread.Sleep(settings3.OpenTime / 2);

            //Thread.Sleep((high_time / 2) + 500);

            while (true)
            {
                signal3 = shutter_device3.GetStatusBits();

                if (signal3 == 8192)
                    break;
                else
                {
                    Thread.Sleep(100);
                }
            }
        }


        private void three_shutter_open()
        {
            //if (_taskComplete_cancel == false)
            // {
            //MessageBox.Show("Stop Job");
            //textBox2.Text = "Please Origin & Start Job!";
            //progressBar1.Value = 0;
            //shutter_device1.SetOperatingState(SolenoidStatus.OperatingStates.Inactive);
            //shutter_device2.SetOperatingState(SolenoidStatus.OperatingStates.Inactive);
            //shutter_device3.SetOperatingState(SolenoidStatus.OperatingStates.Inactive);

            //  return;
            //break;
            //  }

            shutter_device1.SetOperatingState(SolenoidStatus.OperatingStates.Active);
            shutter_device2.SetOperatingState(SolenoidStatus.OperatingStates.Active);
            shutter_device3.SetOperatingState(SolenoidStatus.OperatingStates.Active);

            int a = settings1.OpenTime;
            int b = settings2.OpenTime;
            int c = settings3.OpenTime;

            int high_time, low_time;

            if (a > b)
            {
                high_time = a;

            }
            else
            {
                high_time = b;
            }

            if (high_time < c)
            {
                high_time = c;
            }
            else
            {

            }

            Thread.Sleep((high_time / 2) + 500);

            while (true)
            {
                signal1 = shutter_device1.GetStatusBits();
                signal2 = shutter_device2.GetStatusBits();
                signal3 = shutter_device3.GetStatusBits();

                if (signal1 == 8192 && signal2 == 8192 && signal3 == 8192)
                    break;
            }

            //Thread.Sleep(500);
        }






    }
}
