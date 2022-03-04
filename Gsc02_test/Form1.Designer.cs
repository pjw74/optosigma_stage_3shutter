
namespace Gsc02_test
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.connect = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.homing = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.x_pitch = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.z_pitch = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shut_con1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.emer_stop = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.speed_set = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.layer_count_val = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.delay_t = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.x_start_point = new System.Windows.Forms.NumericUpDown();
            this.z_start_point = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.x_array = new System.Windows.Forms.NumericUpDown();
            this.z_array = new System.Windows.Forms.NumericUpDown();
            this.expo_time_b = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.expo_time_r = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.expo_time_g = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.start_point = new System.Windows.Forms.Button();
            this.job_start = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.acc_time_val = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.speed_max_val = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.speed_min_val = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.point_move = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label_z_posi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_x_posi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.jog_up = new System.Windows.Forms.Button();
            this.jog_right = new System.Windows.Forms.Button();
            this.jog_down = new System.Windows.Forms.Button();
            this.jog_left = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.checkBox_r = new System.Windows.Forms.CheckBox();
            this.checkBox_g = new System.Windows.Forms.CheckBox();
            this.checkBox_b = new System.Windows.Forms.CheckBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.shut_sel = new System.Windows.Forms.Button();
            this.comboBox_r_mode = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.comboBox_g_mode = new System.Windows.Forms.ComboBox();
            this.comboBox_b_mode = new System.Windows.Forms.ComboBox();
            this.three_open = new System.Windows.Forms.Button();
            this.one_open = new System.Windows.Forms.Button();
            this.three_close = new System.Windows.Forms.Button();
            this.all_shut_open = new System.Windows.Forms.Button();
            this.one_close = new System.Windows.Forms.Button();
            this.two_close = new System.Windows.Forms.Button();
            this.all_shut_close = new System.Windows.Forms.Button();
            this.two_open = new System.Windows.Forms.Button();
            this.one_shut_open = new System.Windows.Forms.Button();
            this.all_open_mode = new System.Windows.Forms.RadioButton();
            this.sequential_open_mode = new System.Windows.Forms.RadioButton();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.x_pitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_pitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layer_count_val)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delay_t)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_start_point)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_start_point)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_array)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_array)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expo_time_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expo_time_r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expo_time_g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acc_time_val)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed_max_val)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed_min_val)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(14, 40);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(118, 23);
            this.connect.TabIndex = 1;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 81);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 42);
            this.textBox1.TabIndex = 5;
            // 
            // homing
            // 
            this.homing.Location = new System.Drawing.Point(6, 29);
            this.homing.Name = "homing";
            this.homing.Size = new System.Drawing.Size(100, 34);
            this.homing.TabIndex = 6;
            this.homing.Text = "Home";
            this.homing.UseVisualStyleBackColor = true;
            this.homing.Click += new System.EventHandler(this.homing_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 19200;
            this.serialPort1.DtrEnable = true;
            this.serialPort1.Handshake = System.IO.Ports.Handshake.RequestToSend;
            this.serialPort1.ReceivedBytesThreshold = 30;
            this.serialPort1.RtsEnable = true;
            // 
            // x_pitch
            // 
            this.x_pitch.DecimalPlaces = 2;
            this.x_pitch.Location = new System.Drawing.Point(65, 81);
            this.x_pitch.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.x_pitch.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.x_pitch.Name = "x_pitch";
            this.x_pitch.Size = new System.Drawing.Size(72, 21);
            this.x_pitch.TabIndex = 22;
            this.x_pitch.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.x_pitch.Enter += new System.EventHandler(this.x_pitch_Enter);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(390, 12);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(57, 21);
            this.numericUpDown2.TabIndex = 9;
            this.numericUpDown2.Visible = false;
            // 
            // z_pitch
            // 
            this.z_pitch.DecimalPlaces = 2;
            this.z_pitch.Location = new System.Drawing.Point(65, 105);
            this.z_pitch.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.z_pitch.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.z_pitch.Name = "z_pitch";
            this.z_pitch.Size = new System.Drawing.Size(72, 21);
            this.z_pitch.TabIndex = 23;
            this.z_pitch.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.z_pitch.Enter += new System.EventHandler(this.z_pitch_Enter);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(390, 39);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(57, 21);
            this.numericUpDown4.TabIndex = 11;
            this.numericUpDown4.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.connect);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.shut_con1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 138);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stage Connect";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 21);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(31, 12);
            this.label22.TabIndex = 16;
            this.label22.Text = "Port:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(60, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(72, 20);
            this.comboBox1.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(144, 81);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(118, 42);
            this.textBox3.TabIndex = 248;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status";
            // 
            // shut_con1
            // 
            this.shut_con1.Location = new System.Drawing.Point(144, 39);
            this.shut_con1.Name = "shut_con1";
            this.shut_con1.Size = new System.Drawing.Size(118, 24);
            this.shut_con1.TabIndex = 25;
            this.shut_con1.Text = "Shutter Connect";
            this.shut_con1.UseVisualStyleBackColor = true;
            this.shut_con1.Click += new System.EventHandler(this.shut_con1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.homing);
            this.groupBox2.Controls.Add(this.emer_stop);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Location = new System.Drawing.Point(286, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 138);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Function";
            // 
            // emer_stop
            // 
            this.emer_stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.emer_stop.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.emer_stop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.emer_stop.Location = new System.Drawing.Point(6, 73);
            this.emer_stop.Name = "emer_stop";
            this.emer_stop.Size = new System.Drawing.Size(100, 37);
            this.emer_stop.TabIndex = 19;
            this.emer_stop.Text = "Emergency Stop";
            this.emer_stop.UseVisualStyleBackColor = false;
            this.emer_stop.Click += new System.EventHandler(this.emer_stop_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(118, 94);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 16);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Middle";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(118, 116);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(48, 16);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "High";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(779, 504);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Low";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            // 
            // speed_set
            // 
            this.speed_set.Location = new System.Drawing.Point(65, 107);
            this.speed_set.Name = "speed_set";
            this.speed_set.Size = new System.Drawing.Size(96, 29);
            this.speed_set.TabIndex = 6;
            this.speed_set.Text = "Set Speed";
            this.speed_set.UseVisualStyleBackColor = true;
            this.speed_set.Click += new System.EventHandler(this.speed_set_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.label32);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.layer_count_val);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.delay_t);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.x_start_point);
            this.groupBox3.Controls.Add(this.z_start_point);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.x_array);
            this.groupBox3.Controls.Add(this.z_array);
            this.groupBox3.Controls.Add(this.expo_time_b);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.expo_time_r);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.expo_time_g);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.x_pitch);
            this.groupBox3.Controls.Add(this.z_pitch);
            this.groupBox3.Location = new System.Drawing.Point(12, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 210);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parameter";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(158, 84);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(17, 12);
            this.label31.TabIndex = 255;
            this.label31.Text = "B:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(158, 58);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(18, 12);
            this.label32.TabIndex = 254;
            this.label32.Text = "G:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(158, 34);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(17, 12);
            this.label33.TabIndex = 253;
            this.label33.Text = "R:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(179, 129);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(70, 12);
            this.label30.TabIndex = 252;
            this.label30.Text = "Delay Time";
            // 
            // layer_count_val
            // 
            this.layer_count_val.Location = new System.Drawing.Point(100, 179);
            this.layer_count_val.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.layer_count_val.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.layer_count_val.Name = "layer_count_val";
            this.layer_count_val.Size = new System.Drawing.Size(37, 21);
            this.layer_count_val.TabIndex = 26;
            this.layer_count_val.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 183);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 12);
            this.label17.TabIndex = 33;
            this.label17.Text = "Layer Count:";
            // 
            // delay_t
            // 
            this.delay_t.DecimalPlaces = 2;
            this.delay_t.Location = new System.Drawing.Point(178, 144);
            this.delay_t.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.delay_t.Name = "delay_t";
            this.delay_t.Size = new System.Drawing.Size(71, 21);
            this.delay_t.TabIndex = 251;
            this.delay_t.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "Z Pitch:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 12);
            this.label8.TabIndex = 23;
            this.label8.Text = "X Pitch:";
            // 
            // x_start_point
            // 
            this.x_start_point.DecimalPlaces = 2;
            this.x_start_point.Location = new System.Drawing.Point(65, 25);
            this.x_start_point.Maximum = new decimal(new int[] {
            299,
            0,
            0,
            0});
            this.x_start_point.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.x_start_point.Name = "x_start_point";
            this.x_start_point.Size = new System.Drawing.Size(72, 21);
            this.x_start_point.TabIndex = 20;
            this.x_start_point.Value = new decimal(new int[] {
            299,
            0,
            0,
            0});
            this.x_start_point.Enter += new System.EventHandler(this.x_start_point_Enter);
            this.x_start_point.KeyDown += new System.Windows.Forms.KeyEventHandler(this.x_start_point_KeyDown);
            this.x_start_point.MouseDown += new System.Windows.Forms.MouseEventHandler(this.x_start_point_MouseDown);
            // 
            // z_start_point
            // 
            this.z_start_point.DecimalPlaces = 2;
            this.z_start_point.Location = new System.Drawing.Point(65, 49);
            this.z_start_point.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.z_start_point.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.z_start_point.Name = "z_start_point";
            this.z_start_point.Size = new System.Drawing.Size(72, 21);
            this.z_start_point.TabIndex = 21;
            this.z_start_point.Enter += new System.EventHandler(this.z_start_point_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "X";
            // 
            // x_array
            // 
            this.x_array.Location = new System.Drawing.Point(65, 144);
            this.x_array.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.x_array.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.x_array.Name = "x_array";
            this.x_array.Size = new System.Drawing.Size(37, 21);
            this.x_array.TabIndex = 24;
            this.x_array.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // z_array
            // 
            this.z_array.Location = new System.Drawing.Point(127, 144);
            this.z_array.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.z_array.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.z_array.Name = "z_array";
            this.z_array.Size = new System.Drawing.Size(37, 21);
            this.z_array.TabIndex = 25;
            this.z_array.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // expo_time_b
            // 
            this.expo_time_b.DecimalPlaces = 2;
            this.expo_time_b.Location = new System.Drawing.Point(181, 79);
            this.expo_time_b.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.expo_time_b.Name = "expo_time_b";
            this.expo_time_b.Size = new System.Drawing.Size(71, 21);
            this.expo_time_b.TabIndex = 238;
            this.expo_time_b.Value = new decimal(new int[] {
            21,
            0,
            0,
            131072});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "X x Z:";
            // 
            // expo_time_r
            // 
            this.expo_time_r.DecimalPlaces = 2;
            this.expo_time_r.Location = new System.Drawing.Point(181, 30);
            this.expo_time_r.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.expo_time_r.Name = "expo_time_r";
            this.expo_time_r.Size = new System.Drawing.Size(71, 21);
            this.expo_time_r.TabIndex = 236;
            this.expo_time_r.Value = new decimal(new int[] {
            21,
            0,
            0,
            131072});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "Z Start:";
            // 
            // expo_time_g
            // 
            this.expo_time_g.DecimalPlaces = 2;
            this.expo_time_g.Location = new System.Drawing.Point(181, 54);
            this.expo_time_g.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.expo_time_g.Name = "expo_time_g";
            this.expo_time_g.Size = new System.Drawing.Size(71, 21);
            this.expo_time_g.TabIndex = 237;
            this.expo_time_g.Value = new decimal(new int[] {
            21,
            0,
            0,
            131072});
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(179, 15);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(59, 12);
            this.label27.TabIndex = 239;
            this.label27.Text = "Exposure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "X Start:";
            // 
            // start_point
            // 
            this.start_point.BackColor = System.Drawing.Color.DarkBlue;
            this.start_point.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.start_point.ForeColor = System.Drawing.SystemColors.Control;
            this.start_point.Location = new System.Drawing.Point(16, 55);
            this.start_point.Name = "start_point";
            this.start_point.Size = new System.Drawing.Size(121, 47);
            this.start_point.TabIndex = 60;
            this.start_point.Text = "Start Point";
            this.start_point.UseVisualStyleBackColor = false;
            this.start_point.Click += new System.EventHandler(this.start_point_Click);
            // 
            // job_start
            // 
            this.job_start.BackColor = System.Drawing.Color.Red;
            this.job_start.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.job_start.ForeColor = System.Drawing.SystemColors.Control;
            this.job_start.Location = new System.Drawing.Point(16, 117);
            this.job_start.Name = "job_start";
            this.job_start.Size = new System.Drawing.Size(121, 47);
            this.job_start.TabIndex = 19;
            this.job_start.Text = "Job Start";
            this.job_start.UseVisualStyleBackColor = false;
            this.job_start.Click += new System.EventHandler(this.job_start_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(143, 82);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 12);
            this.label16.TabIndex = 32;
            this.label16.Text = "0 ~ 1000";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(143, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 12);
            this.label15.TabIndex = 31;
            this.label15.Text = "50 ~ 20000";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(143, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 12);
            this.label14.TabIndex = 30;
            this.label14.Text = "50 ~ 20000";
            // 
            // acc_time_val
            // 
            this.acc_time_val.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.acc_time_val.Location = new System.Drawing.Point(81, 80);
            this.acc_time_val.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.acc_time_val.Name = "acc_time_val";
            this.acc_time_val.Size = new System.Drawing.Size(56, 21);
            this.acc_time_val.TabIndex = 27;
            this.acc_time_val.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 12);
            this.label13.TabIndex = 28;
            this.label13.Text = "가감속 시간:";
            // 
            // speed_max_val
            // 
            this.speed_max_val.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.speed_max_val.Location = new System.Drawing.Point(81, 53);
            this.speed_max_val.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.speed_max_val.Minimum = new decimal(new int[] {
            1100,
            0,
            0,
            0});
            this.speed_max_val.Name = "speed_max_val";
            this.speed_max_val.Size = new System.Drawing.Size(56, 21);
            this.speed_max_val.TabIndex = 28;
            this.speed_max_val.Value = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 12);
            this.label12.TabIndex = 26;
            this.label12.Text = "Max Speed:";
            // 
            // speed_min_val
            // 
            this.speed_min_val.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.speed_min_val.Location = new System.Drawing.Point(81, 26);
            this.speed_min_val.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.speed_min_val.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.speed_min_val.Name = "speed_min_val";
            this.speed_min_val.Size = new System.Drawing.Size(56, 21);
            this.speed_min_val.TabIndex = 27;
            this.speed_min_val.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 12);
            this.label11.TabIndex = 24;
            this.label11.Text = "Min Speed:";
            // 
            // point_move
            // 
            this.point_move.Location = new System.Drawing.Point(59, 167);
            this.point_move.Name = "point_move";
            this.point_move.Size = new System.Drawing.Size(107, 30);
            this.point_move.TabIndex = 15;
            this.point_move.Text = "Check";
            this.point_move.UseVisualStyleBackColor = true;
            this.point_move.Click += new System.EventHandler(this.point_move_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(18, 48);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 62);
            this.textBox2.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.point_move);
            this.groupBox4.Controls.Add(this.label_z_posi);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label_x_posi);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(286, 162);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(234, 210);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Information";
            // 
            // label_z_posi
            // 
            this.label_z_posi.AutoSize = true;
            this.label_z_posi.Location = new System.Drawing.Point(108, 145);
            this.label_z_posi.Name = "label_z_posi";
            this.label_z_posi.Size = new System.Drawing.Size(11, 12);
            this.label_z_posi.TabIndex = 22;
            this.label_z_posi.Text = "?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "Position and Status";
            // 
            // label_x_posi
            // 
            this.label_x_posi.AutoSize = true;
            this.label_x_posi.Location = new System.Drawing.Point(108, 121);
            this.label_x_posi.Name = "label_x_posi";
            this.label_x_posi.Size = new System.Drawing.Size(11, 12);
            this.label_x_posi.TabIndex = 23;
            this.label_x_posi.Text = "?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "Z Poisition:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 12);
            this.label10.TabIndex = 21;
            this.label10.Text = "X Poisition:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox8);
            this.groupBox5.Controls.Add(this.acc_time_val);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.speed_set);
            this.groupBox5.Controls.Add(this.speed_min_val);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.speed_max_val);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Location = new System.Drawing.Point(12, 447);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(600, 146);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Speed";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label23);
            this.groupBox8.Controls.Add(this.label18);
            this.groupBox8.Controls.Add(this.label21);
            this.groupBox8.Controls.Add(this.label20);
            this.groupBox8.Controls.Add(this.label19);
            this.groupBox8.Location = new System.Drawing.Point(224, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(370, 128);
            this.groupBox8.TabIndex = 34;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "< 주의사항 >";
            this.groupBox8.Enter += new System.EventHandler(this.groupBox8_Enter);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(15, 106);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(328, 12);
            this.label23.TabIndex = 38;
            this.label23.Text = "5. Emergency Stop 작동 후에는 반드시 Homing 실시할 것.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 64);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(340, 12);
            this.label18.TabIndex = 37;
            this.label18.Text = "3. Min Speed가 2000부터는 가감속 시간 넣어야 함. (100단위)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(15, 85);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(347, 12);
            this.label21.TabIndex = 36;
            this.label21.Text = "4. Jog로 구동 되는 속도임에도 Job에선 구동하지 않을 수 있음.";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(15, 42);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(249, 12);
            this.label20.TabIndex = 35;
            this.label20.Text = "2. 가감속 시간을 0으로 설정하면 등속운동임.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(281, 12);
            this.label19.TabIndex = 34;
            this.label19.Text = "1. Speed 설정값: Min Speed + 1000 = Max Speed";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(666, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "+ move";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.jog_up);
            this.groupBox6.Controls.Add(this.jog_right);
            this.groupBox6.Controls.Add(this.jog_down);
            this.groupBox6.Controls.Add(this.jog_left);
            this.groupBox6.Location = new System.Drawing.Point(404, 18);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(279, 138);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Jog Move";
            // 
            // jog_up
            // 
            this.jog_up.Location = new System.Drawing.Point(102, 20);
            this.jog_up.Name = "jog_up";
            this.jog_up.Size = new System.Drawing.Size(75, 37);
            this.jog_up.TabIndex = 20;
            this.jog_up.Text = "Up";
            this.jog_up.UseVisualStyleBackColor = true;
            this.jog_up.Click += new System.EventHandler(this.jog_up_Click);
            this.jog_up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.jog_up_MouseDown);
            this.jog_up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.jog_up_MouseUp);
            // 
            // jog_right
            // 
            this.jog_right.Location = new System.Drawing.Point(176, 56);
            this.jog_right.Name = "jog_right";
            this.jog_right.Size = new System.Drawing.Size(75, 35);
            this.jog_right.TabIndex = 19;
            this.jog_right.Text = "Right";
            this.jog_right.UseVisualStyleBackColor = true;
            this.jog_right.Click += new System.EventHandler(this.jog_right_Click);
            this.jog_right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.jog_right_MouseDown);
            this.jog_right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.jog_right_MouseUp);
            // 
            // jog_down
            // 
            this.jog_down.Location = new System.Drawing.Point(102, 91);
            this.jog_down.Name = "jog_down";
            this.jog_down.Size = new System.Drawing.Size(75, 35);
            this.jog_down.TabIndex = 18;
            this.jog_down.Text = "Down";
            this.jog_down.UseVisualStyleBackColor = true;
            this.jog_down.Click += new System.EventHandler(this.jog_down_Click);
            this.jog_down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.jog_down_MouseDown);
            this.jog_down.MouseUp += new System.Windows.Forms.MouseEventHandler(this.jog_down_MouseUp);
            // 
            // jog_left
            // 
            this.jog_left.Location = new System.Drawing.Point(28, 56);
            this.jog_left.Name = "jog_left";
            this.jog_left.Size = new System.Drawing.Size(75, 35);
            this.jog_left.TabIndex = 6;
            this.jog_left.Text = "Left";
            this.jog_left.UseVisualStyleBackColor = true;
            this.jog_left.Click += new System.EventHandler(this.jog_left_Click);
            this.jog_left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.jog_left_MouseDown);
            this.jog_left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.jog_left_MouseUp);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(697, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "- move";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.start_point);
            this.groupBox7.Controls.Add(this.job_start);
            this.groupBox7.Location = new System.Drawing.Point(526, 162);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(157, 210);
            this.groupBox7.TabIndex = 24;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Job";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(729, 84);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(103, 20);
            this.comboBox2.TabIndex = 26;
            this.comboBox2.Visible = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(729, 110);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(103, 20);
            this.comboBox3.TabIndex = 27;
            this.comboBox3.Visible = false;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(729, 136);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(103, 20);
            this.comboBox4.TabIndex = 28;
            this.comboBox4.Visible = false;
            // 
            // checkBox_r
            // 
            this.checkBox_r.AutoSize = true;
            this.checkBox_r.Checked = true;
            this.checkBox_r.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_r.Location = new System.Drawing.Point(838, 84);
            this.checkBox_r.Name = "checkBox_r";
            this.checkBox_r.Size = new System.Drawing.Size(41, 16);
            this.checkBox_r.TabIndex = 29;
            this.checkBox_r.Text = "sel";
            this.checkBox_r.UseVisualStyleBackColor = true;
            this.checkBox_r.Visible = false;
            // 
            // checkBox_g
            // 
            this.checkBox_g.AutoSize = true;
            this.checkBox_g.Checked = true;
            this.checkBox_g.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_g.Location = new System.Drawing.Point(838, 110);
            this.checkBox_g.Name = "checkBox_g";
            this.checkBox_g.Size = new System.Drawing.Size(41, 16);
            this.checkBox_g.TabIndex = 30;
            this.checkBox_g.Text = "sel";
            this.checkBox_g.UseVisualStyleBackColor = true;
            this.checkBox_g.Visible = false;
            // 
            // checkBox_b
            // 
            this.checkBox_b.AutoSize = true;
            this.checkBox_b.Checked = true;
            this.checkBox_b.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_b.Location = new System.Drawing.Point(838, 138);
            this.checkBox_b.Name = "checkBox_b";
            this.checkBox_b.Size = new System.Drawing.Size(41, 16);
            this.checkBox_b.TabIndex = 31;
            this.checkBox_b.Text = "sel";
            this.checkBox_b.UseVisualStyleBackColor = true;
            this.checkBox_b.Visible = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(709, 89);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(17, 12);
            this.label24.TabIndex = 32;
            this.label24.Text = "R:";
            this.label24.Visible = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(709, 113);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(18, 12);
            this.label25.TabIndex = 33;
            this.label25.Text = "G:";
            this.label25.Visible = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(709, 139);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(17, 12);
            this.label26.TabIndex = 34;
            this.label26.Text = "B:";
            this.label26.Visible = false;
            // 
            // shut_sel
            // 
            this.shut_sel.Location = new System.Drawing.Point(711, 166);
            this.shut_sel.Name = "shut_sel";
            this.shut_sel.Size = new System.Drawing.Size(87, 39);
            this.shut_sel.TabIndex = 35;
            this.shut_sel.Text = "Shutter Select";
            this.shut_sel.UseVisualStyleBackColor = true;
            this.shut_sel.Visible = false;
            this.shut_sel.Click += new System.EventHandler(this.shut_sel_Click);
            // 
            // comboBox_r_mode
            // 
            this.comboBox_r_mode.FormattingEnabled = true;
            this.comboBox_r_mode.Location = new System.Drawing.Point(885, 84);
            this.comboBox_r_mode.Name = "comboBox_r_mode";
            this.comboBox_r_mode.Size = new System.Drawing.Size(89, 20);
            this.comboBox_r_mode.TabIndex = 36;
            this.comboBox_r_mode.Visible = false;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(885, 69);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(37, 12);
            this.label28.TabIndex = 38;
            this.label28.Text = "Mode";
            this.label28.Visible = false;
            // 
            // comboBox_g_mode
            // 
            this.comboBox_g_mode.FormattingEnabled = true;
            this.comboBox_g_mode.Location = new System.Drawing.Point(885, 108);
            this.comboBox_g_mode.Name = "comboBox_g_mode";
            this.comboBox_g_mode.Size = new System.Drawing.Size(89, 20);
            this.comboBox_g_mode.TabIndex = 39;
            this.comboBox_g_mode.Visible = false;
            // 
            // comboBox_b_mode
            // 
            this.comboBox_b_mode.FormattingEnabled = true;
            this.comboBox_b_mode.Location = new System.Drawing.Point(885, 134);
            this.comboBox_b_mode.Name = "comboBox_b_mode";
            this.comboBox_b_mode.Size = new System.Drawing.Size(89, 20);
            this.comboBox_b_mode.TabIndex = 40;
            this.comboBox_b_mode.Visible = false;
            // 
            // three_open
            // 
            this.three_open.Location = new System.Drawing.Point(22, 75);
            this.three_open.Name = "three_open";
            this.three_open.Size = new System.Drawing.Size(87, 24);
            this.three_open.TabIndex = 244;
            this.three_open.Text = "Blue Open";
            this.three_open.UseVisualStyleBackColor = true;
            this.three_open.Click += new System.EventHandler(this.three_open_Click);
            // 
            // one_open
            // 
            this.one_open.Location = new System.Drawing.Point(22, 21);
            this.one_open.Name = "one_open";
            this.one_open.Size = new System.Drawing.Size(87, 24);
            this.one_open.TabIndex = 240;
            this.one_open.Text = "Red Open";
            this.one_open.UseVisualStyleBackColor = true;
            this.one_open.Click += new System.EventHandler(this.one_open_Click);
            // 
            // three_close
            // 
            this.three_close.Location = new System.Drawing.Point(115, 75);
            this.three_close.Name = "three_close";
            this.three_close.Size = new System.Drawing.Size(87, 24);
            this.three_close.TabIndex = 245;
            this.three_close.Text = "Blue Close";
            this.three_close.UseVisualStyleBackColor = true;
            this.three_close.Click += new System.EventHandler(this.three_close_Click);
            // 
            // all_shut_open
            // 
            this.all_shut_open.Location = new System.Drawing.Point(22, 102);
            this.all_shut_open.Name = "all_shut_open";
            this.all_shut_open.Size = new System.Drawing.Size(87, 24);
            this.all_shut_open.TabIndex = 246;
            this.all_shut_open.Text = "All Open";
            this.all_shut_open.UseVisualStyleBackColor = true;
            this.all_shut_open.Click += new System.EventHandler(this.all_shut_open_Click);
            // 
            // one_close
            // 
            this.one_close.Location = new System.Drawing.Point(115, 21);
            this.one_close.Name = "one_close";
            this.one_close.Size = new System.Drawing.Size(87, 24);
            this.one_close.TabIndex = 241;
            this.one_close.Text = "Red Close";
            this.one_close.UseVisualStyleBackColor = true;
            this.one_close.Click += new System.EventHandler(this.one_close_Click);
            // 
            // two_close
            // 
            this.two_close.Location = new System.Drawing.Point(115, 48);
            this.two_close.Name = "two_close";
            this.two_close.Size = new System.Drawing.Size(87, 24);
            this.two_close.TabIndex = 243;
            this.two_close.Text = "Green Close";
            this.two_close.UseVisualStyleBackColor = true;
            this.two_close.Click += new System.EventHandler(this.two_close_Click);
            // 
            // all_shut_close
            // 
            this.all_shut_close.Location = new System.Drawing.Point(115, 102);
            this.all_shut_close.Name = "all_shut_close";
            this.all_shut_close.Size = new System.Drawing.Size(87, 24);
            this.all_shut_close.TabIndex = 247;
            this.all_shut_close.Text = "All Close";
            this.all_shut_close.UseVisualStyleBackColor = true;
            this.all_shut_close.Click += new System.EventHandler(this.all_shut_close_Click);
            // 
            // two_open
            // 
            this.two_open.Location = new System.Drawing.Point(22, 48);
            this.two_open.Name = "two_open";
            this.two_open.Size = new System.Drawing.Size(87, 24);
            this.two_open.TabIndex = 242;
            this.two_open.Text = "Green Open";
            this.two_open.UseVisualStyleBackColor = true;
            this.two_open.Click += new System.EventHandler(this.two_open_Click);
            // 
            // one_shut_open
            // 
            this.one_shut_open.Location = new System.Drawing.Point(208, 21);
            this.one_shut_open.Name = "one_shut_open";
            this.one_shut_open.Size = new System.Drawing.Size(86, 24);
            this.one_shut_open.TabIndex = 250;
            this.one_shut_open.Text = "One Shot";
            this.one_shut_open.UseVisualStyleBackColor = true;
            this.one_shut_open.Click += new System.EventHandler(this.one_shut_open_Click);
            // 
            // all_open_mode
            // 
            this.all_open_mode.AutoSize = true;
            this.all_open_mode.Location = new System.Drawing.Point(14, 20);
            this.all_open_mode.Name = "all_open_mode";
            this.all_open_mode.Size = new System.Drawing.Size(37, 16);
            this.all_open_mode.TabIndex = 251;
            this.all_open_mode.TabStop = true;
            this.all_open_mode.Text = "All";
            this.all_open_mode.UseVisualStyleBackColor = true;
            // 
            // sequential_open_mode
            // 
            this.sequential_open_mode.AutoSize = true;
            this.sequential_open_mode.Location = new System.Drawing.Point(14, 42);
            this.sequential_open_mode.Name = "sequential_open_mode";
            this.sequential_open_mode.Size = new System.Drawing.Size(82, 16);
            this.sequential_open_mode.TabIndex = 252;
            this.sequential_open_mode.TabStop = true;
            this.sequential_open_mode.Text = "Sequential";
            this.sequential_open_mode.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.all_open_mode);
            this.groupBox9.Controls.Add(this.sequential_open_mode);
            this.groupBox9.Location = new System.Drawing.Point(12, 155);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(132, 70);
            this.groupBox9.TabIndex = 253;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Exposure Mode";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.all_shut_close);
            this.groupBox10.Controls.Add(this.two_open);
            this.groupBox10.Controls.Add(this.one_shut_open);
            this.groupBox10.Controls.Add(this.two_close);
            this.groupBox10.Controls.Add(this.one_close);
            this.groupBox10.Controls.Add(this.three_open);
            this.groupBox10.Controls.Add(this.all_shut_open);
            this.groupBox10.Controls.Add(this.one_open);
            this.groupBox10.Controls.Add(this.three_close);
            this.groupBox10.Location = new System.Drawing.Point(689, 18);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(311, 138);
            this.groupBox10.TabIndex = 24;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Shutter Manual";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 597);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.comboBox_b_mode);
            this.Controls.Add(this.comboBox_g_mode);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.comboBox_r_mode);
            this.Controls.Add(this.shut_sel);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.checkBox_b);
            this.Controls.Add(this.checkBox_g);
            this.Controls.Add(this.checkBox_r);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown2);
            this.Name = "Form1";
            this.Text = "OptoSigma_v1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.x_pitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_pitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layer_count_val)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delay_t)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_start_point)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_start_point)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_array)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_array)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expo_time_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expo_time_r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expo_time_g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acc_time_val)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed_max_val)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed_min_val)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button homing;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.NumericUpDown x_pitch;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown z_pitch;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button point_move;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button speed_set;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button jog_up;
        private System.Windows.Forms.Button jog_right;
        private System.Windows.Forms.Button jog_down;
        private System.Windows.Forms.Button jog_left;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button job_start;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown x_start_point;
        private System.Windows.Forms.NumericUpDown z_start_point;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown x_array;
        private System.Windows.Forms.NumericUpDown z_array;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_z_posi;
        private System.Windows.Forms.Label label_x_posi;
        private System.Windows.Forms.Button start_point;
        private System.Windows.Forms.NumericUpDown speed_min_val;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown speed_max_val;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown acc_time_val;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown layer_count_val;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button emer_stop;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button shut_con1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.CheckBox checkBox_r;
        private System.Windows.Forms.CheckBox checkBox_g;
        private System.Windows.Forms.CheckBox checkBox_b;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button shut_sel;
        private System.Windows.Forms.ComboBox comboBox_r_mode;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox comboBox_g_mode;
        private System.Windows.Forms.ComboBox comboBox_b_mode;
        private System.Windows.Forms.NumericUpDown expo_time_g;
        private System.Windows.Forms.NumericUpDown expo_time_b;
        private System.Windows.Forms.NumericUpDown expo_time_r;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button three_open;
        private System.Windows.Forms.Button one_open;
        private System.Windows.Forms.Button three_close;
        private System.Windows.Forms.Button all_shut_open;
        private System.Windows.Forms.Button one_close;
        private System.Windows.Forms.Button two_close;
        private System.Windows.Forms.Button all_shut_close;
        private System.Windows.Forms.Button two_open;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button one_shut_open;
        private System.Windows.Forms.NumericUpDown delay_t;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.RadioButton all_open_mode;
        private System.Windows.Forms.RadioButton sequential_open_mode;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
    }
}

