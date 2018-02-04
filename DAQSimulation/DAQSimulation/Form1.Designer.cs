namespace DAQSimulation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.samplingButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.autoSampling = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.samplingBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.autoLogging = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loggingBox = new System.Windows.Forms.TextBox();
            this.loggingButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sensorDisplay = new System.Windows.Forms.TextBox();
            this.samplingTimer = new System.Windows.Forms.Timer(this.components);
            this.loggingTimer = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.minVolt = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.maxVolt = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nmbSensors = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nmbDI = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.logTime = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.smplTime = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.readBox = new System.Windows.Forms.TextBox();
            this.readBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.File = new System.Windows.Forms.TabPage();
            this.Operation = new System.Windows.Forms.TabPage();
            this.csvLine = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.slabel1 = new System.Windows.Forms.Label();
            this.slabel2 = new System.Windows.Forms.Label();
            this.slabel4 = new System.Windows.Forms.Label();
            this.slabel3 = new System.Windows.Forms.Label();
            this.slabel8 = new System.Windows.Forms.Label();
            this.slabel7 = new System.Windows.Forms.Label();
            this.slabel6 = new System.Windows.Forms.Label();
            this.slabel5 = new System.Windows.Forms.Label();
            this.slabel16 = new System.Windows.Forms.Label();
            this.slabel15 = new System.Windows.Forms.Label();
            this.slabel14 = new System.Windows.Forms.Label();
            this.slabel13 = new System.Windows.Forms.Label();
            this.slabel12 = new System.Windows.Forms.Label();
            this.slabel11 = new System.Windows.Forms.Label();
            this.slabel10 = new System.Windows.Forms.Label();
            this.slabel9 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.value16 = new System.Windows.Forms.Label();
            this.value1 = new System.Windows.Forms.Label();
            this.value15 = new System.Windows.Forms.Label();
            this.value2 = new System.Windows.Forms.Label();
            this.value14 = new System.Windows.Forms.Label();
            this.value3 = new System.Windows.Forms.Label();
            this.value13 = new System.Windows.Forms.Label();
            this.value4 = new System.Windows.Forms.Label();
            this.value12 = new System.Windows.Forms.Label();
            this.value5 = new System.Windows.Forms.Label();
            this.value11 = new System.Windows.Forms.Label();
            this.value6 = new System.Windows.Forms.Label();
            this.value10 = new System.Windows.Forms.Label();
            this.value7 = new System.Windows.Forms.Label();
            this.value9 = new System.Windows.Forms.Label();
            this.value8 = new System.Windows.Forms.Label();
            this.latestTime = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.hlpBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minVolt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxVolt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbSensors)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbDI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smplTime)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.File.SuspendLayout();
            this.Operation.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // samplingButton
            // 
            this.samplingButton.Location = new System.Drawing.Point(6, 71);
            this.samplingButton.Name = "samplingButton";
            this.samplingButton.Size = new System.Drawing.Size(99, 23);
            this.samplingButton.TabIndex = 0;
            this.samplingButton.Text = "Sampling";
            this.samplingButton.UseVisualStyleBackColor = true;
            this.samplingButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.autoSampling);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.samplingBox);
            this.groupBox1.Controls.Add(this.samplingButton);
            this.groupBox1.Location = new System.Drawing.Point(6, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 112);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sampling";
            // 
            // autoSampling
            // 
            this.autoSampling.AutoSize = true;
            this.autoSampling.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.autoSampling.Location = new System.Drawing.Point(116, 77);
            this.autoSampling.Name = "autoSampling";
            this.autoSampling.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.autoSampling.Size = new System.Drawing.Size(58, 21);
            this.autoSampling.TabIndex = 2;
            this.autoSampling.Text = "Auto";
            this.autoSampling.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Next Sampling Time:";
            // 
            // samplingBox
            // 
            this.samplingBox.Location = new System.Drawing.Point(128, 40);
            this.samplingBox.Name = "samplingBox";
            this.samplingBox.ReadOnly = true;
            this.samplingBox.Size = new System.Drawing.Size(57, 21);
            this.samplingBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.autoLogging);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.loggingBox);
            this.groupBox2.Controls.Add(this.loggingButton);
            this.groupBox2.Location = new System.Drawing.Point(6, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 94);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logging";
            // 
            // autoLogging
            // 
            this.autoLogging.AutoSize = true;
            this.autoLogging.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.autoLogging.Location = new System.Drawing.Point(116, 66);
            this.autoLogging.Name = "autoLogging";
            this.autoLogging.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.autoLogging.Size = new System.Drawing.Size(58, 21);
            this.autoLogging.TabIndex = 2;
            this.autoLogging.Text = "Auto";
            this.autoLogging.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Next Logging Time:";
            // 
            // loggingBox
            // 
            this.loggingBox.Location = new System.Drawing.Point(128, 25);
            this.loggingBox.Name = "loggingBox";
            this.loggingBox.ReadOnly = true;
            this.loggingBox.Size = new System.Drawing.Size(57, 21);
            this.loggingBox.TabIndex = 0;
            // 
            // loggingButton
            // 
            this.loggingButton.Location = new System.Drawing.Point(6, 61);
            this.loggingButton.Name = "loggingButton";
            this.loggingButton.Size = new System.Drawing.Size(99, 23);
            this.loggingButton.TabIndex = 0;
            this.loggingButton.Text = "Logging on file";
            this.loggingButton.UseVisualStyleBackColor = true;
            this.loggingButton.Click += new System.EventHandler(this.loggingButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.sensorDisplay);
            this.groupBox3.Location = new System.Drawing.Point(253, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(675, 340);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Raw Sensor Values";
            // 
            // sensorDisplay
            // 
            this.sensorDisplay.Location = new System.Drawing.Point(7, 20);
            this.sensorDisplay.Multiline = true;
            this.sensorDisplay.Name = "sensorDisplay";
            this.sensorDisplay.ReadOnly = true;
            this.sensorDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sensorDisplay.Size = new System.Drawing.Size(528, 314);
            this.sensorDisplay.TabIndex = 0;
            // 
            // samplingTimer
            // 
            this.samplingTimer.Tick += new System.EventHandler(this.samplingTimer_Tick);
            // 
            // loggingTimer
            // 
            this.loggingTimer.Tick += new System.EventHandler(this.loggingTimer_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 107);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Minimum voltage";
            // 
            // minVolt
            // 
            this.minVolt.Location = new System.Drawing.Point(128, 104);
            this.minVolt.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.minVolt.Name = "minVolt";
            this.minVolt.Size = new System.Drawing.Size(42, 21);
            this.minVolt.TabIndex = 10;
            this.minVolt.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Maximum voltage";
            // 
            // maxVolt
            // 
            this.maxVolt.Location = new System.Drawing.Point(128, 76);
            this.maxVolt.Name = "maxVolt";
            this.maxVolt.Size = new System.Drawing.Size(42, 21);
            this.maxVolt.TabIndex = 8;
            this.maxVolt.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Analog Sensors";
            // 
            // nmbSensors
            // 
            this.nmbSensors.Location = new System.Drawing.Point(128, 48);
            this.nmbSensors.Name = "nmbSensors";
            this.nmbSensors.Size = new System.Drawing.Size(42, 21);
            this.nmbSensors.TabIndex = 6;
            this.nmbSensors.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.nmbDI);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.numericUpDown1);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.logTime);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.smplTime);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.nmbSensors);
            this.groupBox4.Controls.Add(this.minVolt);
            this.groupBox4.Controls.Add(this.maxVolt);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 227);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DAQ Properties";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Digital Sensors";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // nmbDI
            // 
            this.nmbDI.Location = new System.Drawing.Point(128, 22);
            this.nmbDI.Name = "nmbDI";
            this.nmbDI.Size = new System.Drawing.Size(42, 21);
            this.nmbDI.TabIndex = 18;
            this.nmbDI.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nmbDI.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 191);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Resolution";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(128, 188);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(42, 21);
            this.numericUpDown1.TabIndex = 16;
            this.numericUpDown1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 166);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Logging Time(s)";
            // 
            // logTime
            // 
            this.logTime.DecimalPlaces = 1;
            this.logTime.Location = new System.Drawing.Point(128, 163);
            this.logTime.Name = "logTime";
            this.logTime.Size = new System.Drawing.Size(42, 21);
            this.logTime.TabIndex = 14;
            this.logTime.Value = new decimal(new int[] {
            58,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 137);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sampling Time(s)";
            // 
            // smplTime
            // 
            this.smplTime.DecimalPlaces = 1;
            this.smplTime.Location = new System.Drawing.Point(128, 134);
            this.smplTime.Name = "smplTime";
            this.smplTime.Size = new System.Drawing.Size(42, 21);
            this.smplTime.TabIndex = 12;
            this.smplTime.Value = new decimal(new int[] {
            16,
            0,
            0,
            65536});
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.csvLine);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.readBox);
            this.groupBox5.Controls.Add(this.readBtn);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.pathBox);
            this.groupBox5.Location = new System.Drawing.Point(212, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(716, 344);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "CSV File";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // readBox
            // 
            this.readBox.Location = new System.Drawing.Point(10, 24);
            this.readBox.Multiline = true;
            this.readBox.Name = "readBox";
            this.readBox.ReadOnly = true;
            this.readBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.readBox.Size = new System.Drawing.Size(700, 260);
            this.readBox.TabIndex = 14;
            // 
            // readBtn
            // 
            this.readBtn.Location = new System.Drawing.Point(9, 315);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(54, 23);
            this.readBtn.TabIndex = 14;
            this.readBtn.Text = "Read";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(680, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "File path:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(69, 290);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(605, 21);
            this.pathBox.TabIndex = 0;
            this.pathBox.Text = "logfile.txt";
            this.pathBox.TextChanged += new System.EventHandler(this.pathBox_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.File);
            this.tabControl1.Controls.Add(this.Operation);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(942, 386);
            this.tabControl1.TabIndex = 14;
            // 
            // File
            // 
            this.File.Controls.Add(this.button2);
            this.File.Controls.Add(this.hlpBtn);
            this.File.Controls.Add(this.groupBox1);
            this.File.Controls.Add(this.groupBox2);
            this.File.Controls.Add(this.groupBox3);
            this.File.Location = new System.Drawing.Point(4, 25);
            this.File.Name = "File";
            this.File.Padding = new System.Windows.Forms.Padding(3);
            this.File.Size = new System.Drawing.Size(934, 357);
            this.File.TabIndex = 0;
            this.File.Text = "Data";
            this.File.UseVisualStyleBackColor = true;
            // 
            // Operation
            // 
            this.Operation.Controls.Add(this.groupBox5);
            this.Operation.Controls.Add(this.groupBox4);
            this.Operation.Location = new System.Drawing.Point(4, 25);
            this.Operation.Name = "Operation";
            this.Operation.Padding = new System.Windows.Forms.Padding(3);
            this.Operation.Size = new System.Drawing.Size(934, 357);
            this.Operation.TabIndex = 1;
            this.Operation.Text = "Settings";
            this.Operation.UseVisualStyleBackColor = true;
            // 
            // csvLine
            // 
            this.csvLine.Location = new System.Drawing.Point(670, 317);
            this.csvLine.Name = "csvLine";
            this.csvLine.ReadOnly = true;
            this.csvLine.Size = new System.Drawing.Size(40, 21);
            this.csvLine.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(518, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Number of lines in CSV file:";
            // 
            // slabel1
            // 
            this.slabel1.AutoSize = true;
            this.slabel1.Location = new System.Drawing.Point(6, 37);
            this.slabel1.Name = "slabel1";
            this.slabel1.Size = new System.Drawing.Size(20, 16);
            this.slabel1.TabIndex = 5;
            this.slabel1.Text = "S1";
            // 
            // slabel2
            // 
            this.slabel2.AutoSize = true;
            this.slabel2.Location = new System.Drawing.Point(6, 53);
            this.slabel2.Name = "slabel2";
            this.slabel2.Size = new System.Drawing.Size(20, 16);
            this.slabel2.TabIndex = 6;
            this.slabel2.Text = "S2";
            // 
            // slabel4
            // 
            this.slabel4.AutoSize = true;
            this.slabel4.Location = new System.Drawing.Point(6, 85);
            this.slabel4.Name = "slabel4";
            this.slabel4.Size = new System.Drawing.Size(20, 16);
            this.slabel4.TabIndex = 8;
            this.slabel4.Text = "S4";
            // 
            // slabel3
            // 
            this.slabel3.AutoSize = true;
            this.slabel3.Location = new System.Drawing.Point(6, 69);
            this.slabel3.Name = "slabel3";
            this.slabel3.Size = new System.Drawing.Size(20, 16);
            this.slabel3.TabIndex = 7;
            this.slabel3.Text = "S3";
            // 
            // slabel8
            // 
            this.slabel8.AutoSize = true;
            this.slabel8.Location = new System.Drawing.Point(6, 150);
            this.slabel8.Name = "slabel8";
            this.slabel8.Size = new System.Drawing.Size(20, 16);
            this.slabel8.TabIndex = 12;
            this.slabel8.Text = "S8";
            // 
            // slabel7
            // 
            this.slabel7.AutoSize = true;
            this.slabel7.Location = new System.Drawing.Point(6, 134);
            this.slabel7.Name = "slabel7";
            this.slabel7.Size = new System.Drawing.Size(20, 16);
            this.slabel7.TabIndex = 11;
            this.slabel7.Text = "S7";
            // 
            // slabel6
            // 
            this.slabel6.AutoSize = true;
            this.slabel6.Location = new System.Drawing.Point(6, 118);
            this.slabel6.Name = "slabel6";
            this.slabel6.Size = new System.Drawing.Size(20, 16);
            this.slabel6.TabIndex = 10;
            this.slabel6.Text = "S6";
            // 
            // slabel5
            // 
            this.slabel5.AutoSize = true;
            this.slabel5.Location = new System.Drawing.Point(6, 102);
            this.slabel5.Name = "slabel5";
            this.slabel5.Size = new System.Drawing.Size(20, 16);
            this.slabel5.TabIndex = 9;
            this.slabel5.Text = "S5";
            // 
            // slabel16
            // 
            this.slabel16.AutoSize = true;
            this.slabel16.Location = new System.Drawing.Point(6, 279);
            this.slabel16.Name = "slabel16";
            this.slabel16.Size = new System.Drawing.Size(26, 16);
            this.slabel16.TabIndex = 20;
            this.slabel16.Text = "S16";
            // 
            // slabel15
            // 
            this.slabel15.AutoSize = true;
            this.slabel15.Location = new System.Drawing.Point(6, 263);
            this.slabel15.Name = "slabel15";
            this.slabel15.Size = new System.Drawing.Size(26, 16);
            this.slabel15.TabIndex = 19;
            this.slabel15.Text = "S15";
            // 
            // slabel14
            // 
            this.slabel14.AutoSize = true;
            this.slabel14.Location = new System.Drawing.Point(6, 247);
            this.slabel14.Name = "slabel14";
            this.slabel14.Size = new System.Drawing.Size(26, 16);
            this.slabel14.TabIndex = 18;
            this.slabel14.Text = "S14";
            // 
            // slabel13
            // 
            this.slabel13.AutoSize = true;
            this.slabel13.Location = new System.Drawing.Point(6, 231);
            this.slabel13.Name = "slabel13";
            this.slabel13.Size = new System.Drawing.Size(26, 16);
            this.slabel13.TabIndex = 17;
            this.slabel13.Text = "S13";
            // 
            // slabel12
            // 
            this.slabel12.AutoSize = true;
            this.slabel12.Location = new System.Drawing.Point(6, 214);
            this.slabel12.Name = "slabel12";
            this.slabel12.Size = new System.Drawing.Size(26, 16);
            this.slabel12.TabIndex = 16;
            this.slabel12.Text = "S12";
            // 
            // slabel11
            // 
            this.slabel11.AutoSize = true;
            this.slabel11.Location = new System.Drawing.Point(6, 198);
            this.slabel11.Name = "slabel11";
            this.slabel11.Size = new System.Drawing.Size(26, 16);
            this.slabel11.TabIndex = 15;
            this.slabel11.Text = "S11";
            // 
            // slabel10
            // 
            this.slabel10.AutoSize = true;
            this.slabel10.Location = new System.Drawing.Point(6, 182);
            this.slabel10.Name = "slabel10";
            this.slabel10.Size = new System.Drawing.Size(26, 16);
            this.slabel10.TabIndex = 14;
            this.slabel10.Text = "S10";
            // 
            // slabel9
            // 
            this.slabel9.AutoSize = true;
            this.slabel9.Location = new System.Drawing.Point(6, 166);
            this.slabel9.Name = "slabel9";
            this.slabel9.Size = new System.Drawing.Size(20, 16);
            this.slabel9.TabIndex = 13;
            this.slabel9.Text = "S9";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.latestTime);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.value16);
            this.groupBox6.Controls.Add(this.value1);
            this.groupBox6.Controls.Add(this.value15);
            this.groupBox6.Controls.Add(this.value2);
            this.groupBox6.Controls.Add(this.value14);
            this.groupBox6.Controls.Add(this.value3);
            this.groupBox6.Controls.Add(this.value13);
            this.groupBox6.Controls.Add(this.value4);
            this.groupBox6.Controls.Add(this.value12);
            this.groupBox6.Controls.Add(this.value5);
            this.groupBox6.Controls.Add(this.value11);
            this.groupBox6.Controls.Add(this.value6);
            this.groupBox6.Controls.Add(this.value10);
            this.groupBox6.Controls.Add(this.value7);
            this.groupBox6.Controls.Add(this.value9);
            this.groupBox6.Controls.Add(this.value8);
            this.groupBox6.Controls.Add(this.slabel16);
            this.groupBox6.Controls.Add(this.slabel1);
            this.groupBox6.Controls.Add(this.slabel15);
            this.groupBox6.Controls.Add(this.slabel2);
            this.groupBox6.Controls.Add(this.slabel14);
            this.groupBox6.Controls.Add(this.slabel3);
            this.groupBox6.Controls.Add(this.slabel13);
            this.groupBox6.Controls.Add(this.slabel4);
            this.groupBox6.Controls.Add(this.slabel12);
            this.groupBox6.Controls.Add(this.slabel5);
            this.groupBox6.Controls.Add(this.slabel11);
            this.groupBox6.Controls.Add(this.slabel6);
            this.groupBox6.Controls.Add(this.slabel10);
            this.groupBox6.Controls.Add(this.slabel7);
            this.groupBox6.Controls.Add(this.slabel9);
            this.groupBox6.Controls.Add(this.slabel8);
            this.groupBox6.Location = new System.Drawing.Point(541, 14);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(134, 320);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Latest filtered values";
            // 
            // value16
            // 
            this.value16.AutoSize = true;
            this.value16.Location = new System.Drawing.Point(41, 279);
            this.value16.Name = "value16";
            this.value16.Size = new System.Drawing.Size(26, 16);
            this.value16.TabIndex = 36;
            this.value16.Text = "S16";
            // 
            // value1
            // 
            this.value1.AutoSize = true;
            this.value1.Location = new System.Drawing.Point(41, 37);
            this.value1.Name = "value1";
            this.value1.Size = new System.Drawing.Size(20, 16);
            this.value1.TabIndex = 21;
            this.value1.Text = "S1";
            // 
            // value15
            // 
            this.value15.AutoSize = true;
            this.value15.Location = new System.Drawing.Point(41, 263);
            this.value15.Name = "value15";
            this.value15.Size = new System.Drawing.Size(26, 16);
            this.value15.TabIndex = 35;
            this.value15.Text = "S15";
            // 
            // value2
            // 
            this.value2.AutoSize = true;
            this.value2.Location = new System.Drawing.Point(41, 53);
            this.value2.Name = "value2";
            this.value2.Size = new System.Drawing.Size(20, 16);
            this.value2.TabIndex = 22;
            this.value2.Text = "S2";
            // 
            // value14
            // 
            this.value14.AutoSize = true;
            this.value14.Location = new System.Drawing.Point(41, 247);
            this.value14.Name = "value14";
            this.value14.Size = new System.Drawing.Size(26, 16);
            this.value14.TabIndex = 34;
            this.value14.Text = "S14";
            // 
            // value3
            // 
            this.value3.AutoSize = true;
            this.value3.Location = new System.Drawing.Point(41, 69);
            this.value3.Name = "value3";
            this.value3.Size = new System.Drawing.Size(20, 16);
            this.value3.TabIndex = 23;
            this.value3.Text = "S3";
            // 
            // value13
            // 
            this.value13.AutoSize = true;
            this.value13.Location = new System.Drawing.Point(41, 231);
            this.value13.Name = "value13";
            this.value13.Size = new System.Drawing.Size(26, 16);
            this.value13.TabIndex = 33;
            this.value13.Text = "S13";
            // 
            // value4
            // 
            this.value4.AutoSize = true;
            this.value4.Location = new System.Drawing.Point(41, 85);
            this.value4.Name = "value4";
            this.value4.Size = new System.Drawing.Size(20, 16);
            this.value4.TabIndex = 24;
            this.value4.Text = "S4";
            // 
            // value12
            // 
            this.value12.AutoSize = true;
            this.value12.Location = new System.Drawing.Point(41, 214);
            this.value12.Name = "value12";
            this.value12.Size = new System.Drawing.Size(26, 16);
            this.value12.TabIndex = 32;
            this.value12.Text = "S12";
            // 
            // value5
            // 
            this.value5.AutoSize = true;
            this.value5.Location = new System.Drawing.Point(41, 102);
            this.value5.Name = "value5";
            this.value5.Size = new System.Drawing.Size(20, 16);
            this.value5.TabIndex = 25;
            this.value5.Text = "S5";
            // 
            // value11
            // 
            this.value11.AutoSize = true;
            this.value11.Location = new System.Drawing.Point(41, 198);
            this.value11.Name = "value11";
            this.value11.Size = new System.Drawing.Size(26, 16);
            this.value11.TabIndex = 31;
            this.value11.Text = "S11";
            // 
            // value6
            // 
            this.value6.AutoSize = true;
            this.value6.Location = new System.Drawing.Point(41, 118);
            this.value6.Name = "value6";
            this.value6.Size = new System.Drawing.Size(20, 16);
            this.value6.TabIndex = 26;
            this.value6.Text = "S6";
            // 
            // value10
            // 
            this.value10.AutoSize = true;
            this.value10.Location = new System.Drawing.Point(41, 182);
            this.value10.Name = "value10";
            this.value10.Size = new System.Drawing.Size(26, 16);
            this.value10.TabIndex = 30;
            this.value10.Text = "S10";
            // 
            // value7
            // 
            this.value7.AutoSize = true;
            this.value7.Location = new System.Drawing.Point(41, 134);
            this.value7.Name = "value7";
            this.value7.Size = new System.Drawing.Size(20, 16);
            this.value7.TabIndex = 27;
            this.value7.Text = "S7";
            // 
            // value9
            // 
            this.value9.AutoSize = true;
            this.value9.Location = new System.Drawing.Point(41, 166);
            this.value9.Name = "value9";
            this.value9.Size = new System.Drawing.Size(20, 16);
            this.value9.TabIndex = 29;
            this.value9.Text = "S9";
            // 
            // value8
            // 
            this.value8.AutoSize = true;
            this.value8.Location = new System.Drawing.Point(41, 150);
            this.value8.Name = "value8";
            this.value8.Size = new System.Drawing.Size(20, 16);
            this.value8.TabIndex = 28;
            this.value8.Text = "S8";
            // 
            // latestTime
            // 
            this.latestTime.AutoSize = true;
            this.latestTime.Location = new System.Drawing.Point(41, 21);
            this.latestTime.Name = "latestTime";
            this.latestTime.Size = new System.Drawing.Size(20, 16);
            this.latestTime.TabIndex = 38;
            this.latestTime.Text = "S1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 16);
            this.label13.TabIndex = 37;
            this.label13.Text = "Time:";
            // 
            // hlpBtn
            // 
            this.hlpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.hlpBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hlpBtn.Location = new System.Drawing.Point(6, 291);
            this.hlpBtn.Name = "hlpBtn";
            this.hlpBtn.Size = new System.Drawing.Size(241, 52);
            this.hlpBtn.TabIndex = 5;
            this.hlpBtn.Text = "Help";
            this.hlpBtn.UseVisualStyleBackColor = false;
            this.hlpBtn.Click += new System.EventHandler(this.hlpBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(6, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 52);
            this.button2.TabIndex = 6;
            this.button2.Text = "Operations";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(959, 403);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DAQ Simulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minVolt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxVolt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbSensors)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbDI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smplTime)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.File.ResumeLayout(false);
            this.Operation.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button samplingButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox samplingBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loggingBox;
        private System.Windows.Forms.Button loggingButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox sensorDisplay;
        private System.Windows.Forms.CheckBox autoSampling;
        private System.Windows.Forms.CheckBox autoLogging;
        private System.Windows.Forms.Timer samplingTimer;
        private System.Windows.Forms.Timer loggingTimer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown minVolt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown maxVolt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmbSensors;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown logTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown smplTime;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.TextBox readBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage File;
        private System.Windows.Forms.TabPage Operation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nmbDI;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox csvLine;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label slabel16;
        private System.Windows.Forms.Label slabel1;
        private System.Windows.Forms.Label slabel15;
        private System.Windows.Forms.Label slabel2;
        private System.Windows.Forms.Label slabel14;
        private System.Windows.Forms.Label slabel3;
        private System.Windows.Forms.Label slabel13;
        private System.Windows.Forms.Label slabel4;
        private System.Windows.Forms.Label slabel12;
        private System.Windows.Forms.Label slabel5;
        private System.Windows.Forms.Label slabel11;
        private System.Windows.Forms.Label slabel6;
        private System.Windows.Forms.Label slabel10;
        private System.Windows.Forms.Label slabel7;
        private System.Windows.Forms.Label slabel9;
        private System.Windows.Forms.Label slabel8;
        private System.Windows.Forms.Label value16;
        private System.Windows.Forms.Label value1;
        private System.Windows.Forms.Label value15;
        private System.Windows.Forms.Label value2;
        private System.Windows.Forms.Label value14;
        private System.Windows.Forms.Label value3;
        private System.Windows.Forms.Label value13;
        private System.Windows.Forms.Label value4;
        private System.Windows.Forms.Label value12;
        private System.Windows.Forms.Label value5;
        private System.Windows.Forms.Label value11;
        private System.Windows.Forms.Label value6;
        private System.Windows.Forms.Label value10;
        private System.Windows.Forms.Label value7;
        private System.Windows.Forms.Label value9;
        private System.Windows.Forms.Label value8;
        private System.Windows.Forms.Label latestTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button hlpBtn;
        private System.Windows.Forms.Button button2;
    }
}

