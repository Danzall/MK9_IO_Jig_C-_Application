namespace IO_Jig
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
            this.comms = new System.Windows.Forms.ComboBox();
            this.debug = new System.Windows.Forms.RichTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Connect = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.immob = new System.Windows.Forms.Label();
            this.IGN_D_S = new System.Windows.Forms.TextBox();
            this.Panic_D_S = new System.Windows.Forms.TextBox();
            this.Input_A_D_S = new System.Windows.Forms.TextBox();
            this.Input_B_D_S = new System.Windows.Forms.TextBox();
            this.RPM_D_S = new System.Windows.Forms.TextBox();
            this.Immob_D_S = new System.Windows.Forms.TextBox();
            this.Input_C_D_S = new System.Windows.Forms.TextBox();
            this.Immob_D_T = new System.Windows.Forms.TextBox();
            this.Input_C_D_T = new System.Windows.Forms.TextBox();
            this.RPM_D_T = new System.Windows.Forms.TextBox();
            this.Input_B_D_T = new System.Windows.Forms.TextBox();
            this.Input_A_D_T = new System.Windows.Forms.TextBox();
            this.Panic_D_T = new System.Windows.Forms.TextBox();
            this.IGN_D_T = new System.Windows.Forms.TextBox();
            this.Output_D_T = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Tag_LED_D_T = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Output_D_S = new System.Windows.Forms.TextBox();
            this.Tag_LED_D_S = new System.Windows.Forms.TextBox();
            this.DebugClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Default = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.jStatus = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comms
            // 
            this.comms.FormattingEnabled = true;
            this.comms.Location = new System.Drawing.Point(96, 34);
            this.comms.Name = "comms";
            this.comms.Size = new System.Drawing.Size(121, 21);
            this.comms.TabIndex = 0;
            this.comms.SelectedIndexChanged += new System.EventHandler(this.comms_SelectedIndexChanged);
            // 
            // debug
            // 
            this.debug.Location = new System.Drawing.Point(510, 49);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(256, 331);
            this.debug.TabIndex = 1;
            this.debug.Text = "";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived_1);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(58, 411);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(617, 27);
            this.progressBar1.TabIndex = 5;
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(232, 34);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(73, 23);
            this.Connect.TabIndex = 6;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.Connect);
            this.groupBox1.Controls.Add(this.comms);
            this.groupBox1.Location = new System.Drawing.Point(32, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ignition";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "RPM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Panic";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Input A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Input B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Input C";
            // 
            // immob
            // 
            this.immob.AutoSize = true;
            this.immob.Location = new System.Drawing.Point(16, 98);
            this.immob.Name = "immob";
            this.immob.Size = new System.Drawing.Size(38, 13);
            this.immob.TabIndex = 14;
            this.immob.Text = "Immob";
            // 
            // IGN_D_S
            // 
            this.IGN_D_S.Location = new System.Drawing.Point(89, 84);
            this.IGN_D_S.Name = "IGN_D_S";
            this.IGN_D_S.Size = new System.Drawing.Size(29, 20);
            this.IGN_D_S.TabIndex = 15;
            // 
            // Panic_D_S
            // 
            this.Panic_D_S.Location = new System.Drawing.Point(89, 146);
            this.Panic_D_S.Name = "Panic_D_S";
            this.Panic_D_S.Size = new System.Drawing.Size(29, 20);
            this.Panic_D_S.TabIndex = 16;
            // 
            // Input_A_D_S
            // 
            this.Input_A_D_S.Location = new System.Drawing.Point(89, 175);
            this.Input_A_D_S.Name = "Input_A_D_S";
            this.Input_A_D_S.Size = new System.Drawing.Size(29, 20);
            this.Input_A_D_S.TabIndex = 17;
            // 
            // Input_B_D_S
            // 
            this.Input_B_D_S.Location = new System.Drawing.Point(89, 201);
            this.Input_B_D_S.Name = "Input_B_D_S";
            this.Input_B_D_S.Size = new System.Drawing.Size(29, 20);
            this.Input_B_D_S.TabIndex = 18;
            // 
            // RPM_D_S
            // 
            this.RPM_D_S.Location = new System.Drawing.Point(89, 116);
            this.RPM_D_S.Name = "RPM_D_S";
            this.RPM_D_S.Size = new System.Drawing.Size(29, 20);
            this.RPM_D_S.TabIndex = 19;
            // 
            // Immob_D_S
            // 
            this.Immob_D_S.BackColor = System.Drawing.SystemColors.Window;
            this.Immob_D_S.Location = new System.Drawing.Point(88, 98);
            this.Immob_D_S.Name = "Immob_D_S";
            this.Immob_D_S.Size = new System.Drawing.Size(29, 20);
            this.Immob_D_S.TabIndex = 20;
            // 
            // Input_C_D_S
            // 
            this.Input_C_D_S.Location = new System.Drawing.Point(89, 231);
            this.Input_C_D_S.Name = "Input_C_D_S";
            this.Input_C_D_S.Size = new System.Drawing.Size(29, 20);
            this.Input_C_D_S.TabIndex = 21;
            // 
            // Immob_D_T
            // 
            this.Immob_D_T.Location = new System.Drawing.Point(143, 98);
            this.Immob_D_T.Name = "Immob_D_T";
            this.Immob_D_T.Size = new System.Drawing.Size(29, 20);
            this.Immob_D_T.TabIndex = 22;
            // 
            // Input_C_D_T
            // 
            this.Input_C_D_T.Location = new System.Drawing.Point(144, 231);
            this.Input_C_D_T.Name = "Input_C_D_T";
            this.Input_C_D_T.Size = new System.Drawing.Size(29, 20);
            this.Input_C_D_T.TabIndex = 28;
            // 
            // RPM_D_T
            // 
            this.RPM_D_T.Location = new System.Drawing.Point(144, 116);
            this.RPM_D_T.Name = "RPM_D_T";
            this.RPM_D_T.Size = new System.Drawing.Size(29, 20);
            this.RPM_D_T.TabIndex = 27;
            // 
            // Input_B_D_T
            // 
            this.Input_B_D_T.Location = new System.Drawing.Point(144, 201);
            this.Input_B_D_T.Name = "Input_B_D_T";
            this.Input_B_D_T.Size = new System.Drawing.Size(29, 20);
            this.Input_B_D_T.TabIndex = 26;
            // 
            // Input_A_D_T
            // 
            this.Input_A_D_T.Location = new System.Drawing.Point(144, 175);
            this.Input_A_D_T.Name = "Input_A_D_T";
            this.Input_A_D_T.Size = new System.Drawing.Size(29, 20);
            this.Input_A_D_T.TabIndex = 25;
            // 
            // Panic_D_T
            // 
            this.Panic_D_T.Location = new System.Drawing.Point(144, 146);
            this.Panic_D_T.Name = "Panic_D_T";
            this.Panic_D_T.Size = new System.Drawing.Size(29, 20);
            this.Panic_D_T.TabIndex = 24;
            // 
            // IGN_D_T
            // 
            this.IGN_D_T.Location = new System.Drawing.Point(144, 84);
            this.IGN_D_T.Name = "IGN_D_T";
            this.IGN_D_T.Size = new System.Drawing.Size(29, 20);
            this.IGN_D_T.TabIndex = 23;
            // 
            // Output_D_T
            // 
            this.Output_D_T.Location = new System.Drawing.Point(143, 130);
            this.Output_D_T.Name = "Output_D_T";
            this.Output_D_T.Size = new System.Drawing.Size(29, 20);
            this.Output_D_T.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Output";
            // 
            // Tag_LED_D_T
            // 
            this.Tag_LED_D_T.Location = new System.Drawing.Point(143, 160);
            this.Tag_LED_D_T.Name = "Tag_LED_D_T";
            this.Tag_LED_D_T.Size = new System.Drawing.Size(29, 20);
            this.Tag_LED_D_T.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Tag LED";
            // 
            // Output_D_S
            // 
            this.Output_D_S.Location = new System.Drawing.Point(88, 130);
            this.Output_D_S.Name = "Output_D_S";
            this.Output_D_S.Size = new System.Drawing.Size(29, 20);
            this.Output_D_S.TabIndex = 33;
            // 
            // Tag_LED_D_S
            // 
            this.Tag_LED_D_S.Location = new System.Drawing.Point(88, 160);
            this.Tag_LED_D_S.Name = "Tag_LED_D_S";
            this.Tag_LED_D_S.Size = new System.Drawing.Size(29, 20);
            this.Tag_LED_D_S.TabIndex = 34;
            // 
            // DebugClear
            // 
            this.DebugClear.Location = new System.Drawing.Point(600, 382);
            this.DebugClear.Name = "DebugClear";
            this.DebugClear.Size = new System.Drawing.Size(75, 23);
            this.DebugClear.TabIndex = 35;
            this.DebugClear.Text = "Clear";
            this.DebugClear.UseVisualStyleBackColor = true;
            this.DebugClear.Click += new System.EventHandler(this.DebugClear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Default";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(140, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Triggered";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(141, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Triggered";
            // 
            // Default
            // 
            this.Default.AllowDrop = true;
            this.Default.AutoSize = true;
            this.Default.Location = new System.Drawing.Point(86, 46);
            this.Default.Name = "Default";
            this.Default.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Default.Size = new System.Drawing.Size(41, 13);
            this.Default.TabIndex = 39;
            this.Default.Text = "Default";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IGN_D_S);
            this.groupBox2.Controls.Add(this.Default);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Panic_D_S);
            this.groupBox2.Controls.Add(this.Input_A_D_S);
            this.groupBox2.Controls.Add(this.Input_B_D_S);
            this.groupBox2.Controls.Add(this.RPM_D_S);
            this.groupBox2.Controls.Add(this.Input_C_D_S);
            this.groupBox2.Controls.Add(this.Input_C_D_T);
            this.groupBox2.Controls.Add(this.IGN_D_T);
            this.groupBox2.Controls.Add(this.RPM_D_T);
            this.groupBox2.Controls.Add(this.Panic_D_T);
            this.groupBox2.Controls.Add(this.Input_B_D_T);
            this.groupBox2.Controls.Add(this.Input_A_D_T);
            this.groupBox2.Location = new System.Drawing.Point(36, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 269);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inputs";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Immob_D_S);
            this.groupBox3.Controls.Add(this.immob);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.Immob_D_T);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.Output_D_T);
            this.groupBox3.Controls.Add(this.Tag_LED_D_S);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.Output_D_S);
            this.groupBox3.Controls.Add(this.Tag_LED_D_T);
            this.groupBox3.Location = new System.Drawing.Point(264, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 233);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Outputs";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(537, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Jig Status:";
            // 
            // jStatus
            // 
            this.jStatus.Location = new System.Drawing.Point(599, 20);
            this.jStatus.Name = "jStatus";
            this.jStatus.Size = new System.Drawing.Size(56, 20);
            this.jStatus.TabIndex = 43;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.jStatus);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DebugClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.debug);
            this.Name = "Form1";
            this.Text = "Cellstop IO Jig";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comms;
        private System.Windows.Forms.RichTextBox debug;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label immob;
        private System.Windows.Forms.TextBox IGN_D_S;
        private System.Windows.Forms.TextBox Panic_D_S;
        private System.Windows.Forms.TextBox Input_A_D_S;
        private System.Windows.Forms.TextBox Input_B_D_S;
        private System.Windows.Forms.TextBox RPM_D_S;
        private System.Windows.Forms.TextBox Immob_D_S;
        private System.Windows.Forms.TextBox Input_C_D_S;
        private System.Windows.Forms.TextBox Immob_D_T;
        private System.Windows.Forms.TextBox Input_C_D_T;
        private System.Windows.Forms.TextBox RPM_D_T;
        private System.Windows.Forms.TextBox Input_B_D_T;
        private System.Windows.Forms.TextBox Input_A_D_T;
        private System.Windows.Forms.TextBox Panic_D_T;
        private System.Windows.Forms.TextBox IGN_D_T;
        private System.Windows.Forms.TextBox Output_D_T;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Tag_LED_D_T;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Output_D_S;
        private System.Windows.Forms.TextBox Tag_LED_D_S;
        private System.Windows.Forms.Button DebugClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Default;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox jStatus;
    }
}

