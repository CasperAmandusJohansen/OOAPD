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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.operationMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
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
            this.label7 = new System.Windows.Forms.Label();
            this.logTime = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.smplTime = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.readBox = new System.Windows.Forms.TextBox();
            this.readBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minVolt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxVolt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbSensors)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smplTime)).BeginInit();
            this.groupBox5.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 112);
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
            this.autoSampling.Size = new System.Drawing.Size(54, 18);
            this.autoSampling.TabIndex = 2;
            this.autoSampling.Text = "Auto";
            this.autoSampling.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Next Sampling Time:";
            // 
            // samplingBox
            // 
            this.samplingBox.Location = new System.Drawing.Point(116, 40);
            this.samplingBox.Name = "samplingBox";
            this.samplingBox.ReadOnly = true;
            this.samplingBox.Size = new System.Drawing.Size(78, 20);
            this.samplingBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.autoLogging);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.loggingBox);
            this.groupBox2.Controls.Add(this.loggingButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 94);
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
            this.autoLogging.Size = new System.Drawing.Size(54, 18);
            this.autoLogging.TabIndex = 2;
            this.autoLogging.Text = "Auto";
            this.autoLogging.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Next Logging Time:";
            // 
            // loggingBox
            // 
            this.loggingBox.Location = new System.Drawing.Point(116, 25);
            this.loggingBox.Name = "loggingBox";
            this.loggingBox.ReadOnly = true;
            this.loggingBox.Size = new System.Drawing.Size(78, 20);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.operationMenu,
            this.helpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(904, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            this.fileMenu.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // operationMenu
            // 
            this.operationMenu.Name = "operationMenu";
            this.operationMenu.Size = new System.Drawing.Size(72, 20);
            this.operationMenu.Text = "Operation";
            this.operationMenu.Click += new System.EventHandler(this.operationMenu_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "Help";
            this.helpMenu.Click += new System.EventHandler(this.helpMenu_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sensorDisplay);
            this.groupBox3.Location = new System.Drawing.Point(219, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 211);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sensor Values";
            // 
            // sensorDisplay
            // 
            this.sensorDisplay.Location = new System.Drawing.Point(7, 20);
            this.sensorDisplay.Multiline = true;
            this.sensorDisplay.Name = "sensorDisplay";
            this.sensorDisplay.ReadOnly = true;
            this.sensorDisplay.Size = new System.Drawing.Size(163, 182);
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
            this.label5.Location = new System.Drawing.Point(6, 99);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Minimum voltage";
            // 
            // minVolt
            // 
            this.minVolt.Location = new System.Drawing.Point(128, 96);
            this.minVolt.Name = "minVolt";
            this.minVolt.Size = new System.Drawing.Size(42, 20);
            this.minVolt.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Maximum voltage";
            // 
            // maxVolt
            // 
            this.maxVolt.Location = new System.Drawing.Point(128, 68);
            this.maxVolt.Name = "maxVolt";
            this.maxVolt.Size = new System.Drawing.Size(42, 20);
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
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number of sensors";
            // 
            // nmbSensors
            // 
            this.nmbSensors.Location = new System.Drawing.Point(128, 40);
            this.nmbSensors.Name = "nmbSensors";
            this.nmbSensors.Size = new System.Drawing.Size(42, 20);
            this.nmbSensors.TabIndex = 6;
            this.nmbSensors.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // groupBox4
            // 
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
            this.groupBox4.Location = new System.Drawing.Point(401, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 212);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DAQ Properties";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 158);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Logging Time(s)";
            // 
            // logTime
            // 
            this.logTime.Location = new System.Drawing.Point(128, 155);
            this.logTime.Name = "logTime";
            this.logTime.Size = new System.Drawing.Size(42, 20);
            this.logTime.TabIndex = 14;
            this.logTime.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 129);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sampling Time(s)";
            // 
            // smplTime
            // 
            this.smplTime.Location = new System.Drawing.Point(128, 126);
            this.smplTime.Name = "smplTime";
            this.smplTime.Size = new System.Drawing.Size(42, 20);
            this.smplTime.TabIndex = 12;
            this.smplTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.readBox);
            this.groupBox5.Controls.Add(this.readBtn);
            this.groupBox5.Controls.Add(this.checkBox1);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.pathBox);
            this.groupBox5.Location = new System.Drawing.Point(608, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(284, 211);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "CSV File Properties";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // readBox
            // 
            this.readBox.Location = new System.Drawing.Point(10, 69);
            this.readBox.Multiline = true;
            this.readBox.Name = "readBox";
            this.readBox.ReadOnly = true;
            this.readBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.readBox.Size = new System.Drawing.Size(268, 102);
            this.readBox.TabIndex = 14;
            // 
            // readBtn
            // 
            this.readBtn.Location = new System.Drawing.Point(10, 181);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(54, 23);
            this.readBtn.TabIndex = 14;
            this.readBtn.Text = "Read";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Location = new System.Drawing.Point(201, 182);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(77, 18);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Overwrite";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "File path:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(60, 43);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(182, 20);
            this.pathBox.TabIndex = 0;
            this.pathBox.Text = "CSV_file1.txt";
            this.pathBox.TextChanged += new System.EventHandler(this.pathBox_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 242);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DAQ Simulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minVolt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxVolt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbSensors)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smplTime)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem operationMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.TextBox readBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

