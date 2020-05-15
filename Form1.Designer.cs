namespace SerialCom
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
            this.button1 = new System.Windows.Forms.Button();
            this.ComSel = new System.Windows.Forms.ComboBox();
            this.SendTime = new System.Windows.Forms.Button();
            this.AlarmCtrl_02 = new System.Windows.Forms.CheckBox();
            this.AlarmCtrl_01 = new System.Windows.Forms.CheckBox();
            this.AlarmCtrl_03 = new System.Windows.Forms.CheckBox();
            this.AlCntrl = new System.Windows.Forms.GroupBox();
            this.SerialConn = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.LCD_Control = new System.Windows.Forms.GroupBox();
            this.TimeSet = new System.Windows.Forms.DateTimePicker();
            this.TimDis = new System.Windows.Forms.GroupBox();
            this.rstbtn = new System.Windows.Forms.Button();
            this.stbtn = new System.Windows.Forms.Button();
            this.TimerDisp = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Bio_Mets = new System.Windows.Forms.GroupBox();
            this.BdyTmp = new System.Windows.Forms.CheckBox();
            this.HrtRt = new System.Windows.Forms.CheckBox();
            this.BdyTempDisp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RepDisp = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GetHrtRt = new System.Windows.Forms.Timer(this.components);
            this.GetBdyTmp = new System.Windows.Forms.Timer(this.components);
            this.AlCntrl.SuspendLayout();
            this.SerialConn.SuspendLayout();
            this.LCD_Control.SuspendLayout();
            this.TimDis.SuspendLayout();
            this.Bio_Mets.SuspendLayout();
            this.RepDisp.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.button1.Location = new System.Drawing.Point(10, 42);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ComSel
            // 
            this.ComSel.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ComSel.FormattingEnabled = true;
            this.ComSel.Location = new System.Drawing.Point(136, 68);
            this.ComSel.Margin = new System.Windows.Forms.Padding(2);
            this.ComSel.Name = "ComSel";
            this.ComSel.Size = new System.Drawing.Size(82, 30);
            this.ComSel.TabIndex = 1;
            // 
            // SendTime
            // 
            this.SendTime.Font = new System.Drawing.Font("Tahoma", 15F);
            this.SendTime.Location = new System.Drawing.Point(80, 100);
            this.SendTime.Margin = new System.Windows.Forms.Padding(2);
            this.SendTime.Name = "SendTime";
            this.SendTime.Size = new System.Drawing.Size(128, 42);
            this.SendTime.TabIndex = 4;
            this.SendTime.Text = "Set";
            this.SendTime.UseVisualStyleBackColor = true;
            this.SendTime.Click += new System.EventHandler(this.button2_Click);
            // 
            // AlarmCtrl_02
            // 
            this.AlarmCtrl_02.AutoSize = true;
            this.AlarmCtrl_02.Font = new System.Drawing.Font("Tahoma", 11F);
            this.AlarmCtrl_02.Location = new System.Drawing.Point(20, 73);
            this.AlarmCtrl_02.Margin = new System.Windows.Forms.Padding(2);
            this.AlarmCtrl_02.Name = "AlarmCtrl_02";
            this.AlarmCtrl_02.Size = new System.Drawing.Size(134, 27);
            this.AlarmCtrl_02.TabIndex = 5;
            this.AlarmCtrl_02.Text = "Temp Alarm";
            this.AlarmCtrl_02.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AlarmCtrl_02.UseVisualStyleBackColor = true;
            this.AlarmCtrl_02.CheckedChanged += new System.EventHandler(this.Led1CheckboxClicked);
            // 
            // AlarmCtrl_01
            // 
            this.AlarmCtrl_01.AutoSize = true;
            this.AlarmCtrl_01.Font = new System.Drawing.Font("Tahoma", 11F);
            this.AlarmCtrl_01.Location = new System.Drawing.Point(20, 41);
            this.AlarmCtrl_01.Margin = new System.Windows.Forms.Padding(2);
            this.AlarmCtrl_01.Name = "AlarmCtrl_01";
            this.AlarmCtrl_01.Size = new System.Drawing.Size(195, 27);
            this.AlarmCtrl_01.TabIndex = 6;
            this.AlarmCtrl_01.Text = "Wrong Angle Alarm";
            this.AlarmCtrl_01.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AlarmCtrl_01.UseVisualStyleBackColor = true;
            this.AlarmCtrl_01.CheckedChanged += new System.EventHandler(this.Led2CheckboxClicked);
            // 
            // AlarmCtrl_03
            // 
            this.AlarmCtrl_03.AutoSize = true;
            this.AlarmCtrl_03.Font = new System.Drawing.Font("Tahoma", 11F);
            this.AlarmCtrl_03.Location = new System.Drawing.Point(20, 105);
            this.AlarmCtrl_03.Margin = new System.Windows.Forms.Padding(2);
            this.AlarmCtrl_03.Name = "AlarmCtrl_03";
            this.AlarmCtrl_03.Size = new System.Drawing.Size(98, 27);
            this.AlarmCtrl_03.TabIndex = 7;
            this.AlarmCtrl_03.Text = "Vibrator";
            this.AlarmCtrl_03.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AlarmCtrl_03.UseVisualStyleBackColor = true;
            this.AlarmCtrl_03.CheckedChanged += new System.EventHandler(this.Led3CheckboxClicked);
            // 
            // AlCntrl
            // 
            this.AlCntrl.BackColor = System.Drawing.Color.Transparent;
            this.AlCntrl.Controls.Add(this.AlarmCtrl_03);
            this.AlCntrl.Controls.Add(this.AlarmCtrl_02);
            this.AlCntrl.Controls.Add(this.AlarmCtrl_01);
            this.AlCntrl.Font = new System.Drawing.Font("Tahoma", 13F);
            this.AlCntrl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AlCntrl.Location = new System.Drawing.Point(260, 14);
            this.AlCntrl.Margin = new System.Windows.Forms.Padding(2);
            this.AlCntrl.Name = "AlCntrl";
            this.AlCntrl.Padding = new System.Windows.Forms.Padding(2);
            this.AlCntrl.Size = new System.Drawing.Size(201, 145);
            this.AlCntrl.TabIndex = 8;
            this.AlCntrl.TabStop = false;
            this.AlCntrl.Text = "Device Controls";
            // 
            // SerialConn
            // 
            this.SerialConn.BackColor = System.Drawing.Color.Transparent;
            this.SerialConn.Controls.Add(this.button3);
            this.SerialConn.Controls.Add(this.ComSel);
            this.SerialConn.Controls.Add(this.button1);
            this.SerialConn.Font = new System.Drawing.Font("Tahoma", 15F);
            this.SerialConn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SerialConn.Location = new System.Drawing.Point(10, 11);
            this.SerialConn.Margin = new System.Windows.Forms.Padding(2);
            this.SerialConn.Name = "SerialConn";
            this.SerialConn.Padding = new System.Windows.Forms.Padding(2);
            this.SerialConn.Size = new System.Drawing.Size(234, 145);
            this.SerialConn.TabIndex = 9;
            this.SerialConn.TabStop = false;
            this.SerialConn.Text = "Serial Connection";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.button3.Location = new System.Drawing.Point(10, 89);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LCD_Control
            // 
            this.LCD_Control.BackColor = System.Drawing.Color.Transparent;
            this.LCD_Control.Controls.Add(this.TimeSet);
            this.LCD_Control.Controls.Add(this.SendTime);
            this.LCD_Control.Font = new System.Drawing.Font("Tahoma", 15F);
            this.LCD_Control.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LCD_Control.Location = new System.Drawing.Point(336, 476);
            this.LCD_Control.Margin = new System.Windows.Forms.Padding(2);
            this.LCD_Control.Name = "LCD_Control";
            this.LCD_Control.Padding = new System.Windows.Forms.Padding(2);
            this.LCD_Control.Size = new System.Drawing.Size(278, 161);
            this.LCD_Control.TabIndex = 10;
            this.LCD_Control.TabStop = false;
            this.LCD_Control.Text = "Set Timer";
            // 
            // TimeSet
            // 
            this.TimeSet.CustomFormat = "HH:mm:ss";
            this.TimeSet.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeSet.Location = new System.Drawing.Point(22, 54);
            this.TimeSet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TimeSet.Name = "TimeSet";
            this.TimeSet.ShowUpDown = true;
            this.TimeSet.Size = new System.Drawing.Size(233, 38);
            this.TimeSet.TabIndex = 5;
            this.TimeSet.Value = new System.DateTime(2019, 12, 18, 0, 0, 0, 0);
            // 
            // TimDis
            // 
            this.TimDis.BackColor = System.Drawing.Color.Transparent;
            this.TimDis.Controls.Add(this.rstbtn);
            this.TimDis.Controls.Add(this.stbtn);
            this.TimDis.Controls.Add(this.TimerDisp);
            this.TimDis.Font = new System.Drawing.Font("Tahoma", 15F);
            this.TimDis.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TimDis.Location = new System.Drawing.Point(10, 476);
            this.TimDis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TimDis.Name = "TimDis";
            this.TimDis.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TimDis.Size = new System.Drawing.Size(320, 161);
            this.TimDis.TabIndex = 11;
            this.TimDis.TabStop = false;
            this.TimDis.Text = "Timer";
            // 
            // rstbtn
            // 
            this.rstbtn.Font = new System.Drawing.Font("Tahoma", 15F);
            this.rstbtn.Location = new System.Drawing.Point(166, 96);
            this.rstbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rstbtn.Name = "rstbtn";
            this.rstbtn.Size = new System.Drawing.Size(139, 42);
            this.rstbtn.TabIndex = 2;
            this.rstbtn.Text = "Reset";
            this.rstbtn.UseVisualStyleBackColor = true;
            this.rstbtn.Click += new System.EventHandler(this.rstbtn_Click);
            // 
            // stbtn
            // 
            this.stbtn.Font = new System.Drawing.Font("Tahoma", 15F);
            this.stbtn.Location = new System.Drawing.Point(7, 96);
            this.stbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stbtn.Name = "stbtn";
            this.stbtn.Size = new System.Drawing.Size(139, 42);
            this.stbtn.TabIndex = 1;
            this.stbtn.Text = "Start";
            this.stbtn.UseVisualStyleBackColor = true;
            this.stbtn.Click += new System.EventHandler(this.stbtn_Click);
            // 
            // TimerDisp
            // 
            this.TimerDisp.AutoSize = true;
            this.TimerDisp.BackColor = System.Drawing.Color.Black;
            this.TimerDisp.Font = new System.Drawing.Font("Tahoma", 19F);
            this.TimerDisp.Location = new System.Drawing.Point(56, 41);
            this.TimerDisp.Name = "TimerDisp";
            this.TimerDisp.Size = new System.Drawing.Size(202, 39);
            this.TimerDisp.TabIndex = 0;
            this.TimerDisp.Text = "00:00:00.000";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Bio_Mets
            // 
            this.Bio_Mets.BackColor = System.Drawing.Color.Transparent;
            this.Bio_Mets.Controls.Add(this.BdyTmp);
            this.Bio_Mets.Controls.Add(this.HrtRt);
            this.Bio_Mets.Controls.Add(this.BdyTempDisp);
            this.Bio_Mets.Controls.Add(this.label1);
            this.Bio_Mets.Font = new System.Drawing.Font("Tahoma", 15F);
            this.Bio_Mets.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Bio_Mets.Location = new System.Drawing.Point(470, 10);
            this.Bio_Mets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Bio_Mets.Name = "Bio_Mets";
            this.Bio_Mets.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Bio_Mets.Size = new System.Drawing.Size(146, 191);
            this.Bio_Mets.TabIndex = 12;
            this.Bio_Mets.TabStop = false;
            this.Bio_Mets.Text = "BioMetrics";
            // 
            // BdyTmp
            // 
            this.BdyTmp.AutoSize = true;
            this.BdyTmp.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BdyTmp.Location = new System.Drawing.Point(13, 154);
            this.BdyTmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BdyTmp.Name = "BdyTmp";
            this.BdyTmp.Size = new System.Drawing.Size(133, 27);
            this.BdyTmp.TabIndex = 5;
            this.BdyTmp.Text = "Body Temp.";
            this.BdyTmp.UseVisualStyleBackColor = true;
            this.BdyTmp.CheckedChanged += new System.EventHandler(this.BdyTmp_CheckedChanged);
            // 
            // HrtRt
            // 
            this.HrtRt.AutoSize = true;
            this.HrtRt.Font = new System.Drawing.Font("Tahoma", 11F);
            this.HrtRt.Location = new System.Drawing.Point(14, 75);
            this.HrtRt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HrtRt.Name = "HrtRt";
            this.HrtRt.Size = new System.Drawing.Size(122, 27);
            this.HrtRt.TabIndex = 4;
            this.HrtRt.Text = "Heart Rate";
            this.HrtRt.UseVisualStyleBackColor = true;
            this.HrtRt.CheckedChanged += new System.EventHandler(this.HrtRt_CheckedChanged);
            // 
            // BdyTempDisp
            // 
            this.BdyTempDisp.AutoSize = true;
            this.BdyTempDisp.BackColor = System.Drawing.Color.Black;
            this.BdyTempDisp.Font = new System.Drawing.Font("Tahoma", 19F);
            this.BdyTempDisp.ForeColor = System.Drawing.Color.DarkGreen;
            this.BdyTempDisp.Location = new System.Drawing.Point(31, 110);
            this.BdyTempDisp.Name = "BdyTempDisp";
            this.BdyTempDisp.Size = new System.Drawing.Size(95, 39);
            this.BdyTempDisp.TabIndex = 1;
            this.BdyTempDisp.Text = "00.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19F);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(49, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "00";
            // 
            // RepDisp
            // 
            this.RepDisp.BackColor = System.Drawing.Color.Transparent;
            this.RepDisp.Controls.Add(this.label5);
            this.RepDisp.Controls.Add(this.checkBox4);
            this.RepDisp.Controls.Add(this.progressBar1);
            this.RepDisp.Font = new System.Drawing.Font("Tahoma", 21F);
            this.RepDisp.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RepDisp.Location = new System.Drawing.Point(10, 161);
            this.RepDisp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RepDisp.Name = "RepDisp";
            this.RepDisp.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RepDisp.Size = new System.Drawing.Size(450, 297);
            this.RepDisp.TabIndex = 13;
            this.RepDisp.TabStop = false;
            this.RepDisp.Text = "Start a Set";
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 42);
            this.label5.TabIndex = 2;
            this.label5.Text = "Current State";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.checkBox4.Location = new System.Drawing.Point(7, 262);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(117, 27);
            this.checkBox4.TabIndex = 1;
            this.checkBox4.Text = "Timed Set";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.progressBar1.ForeColor = System.Drawing.Color.LimeGreen;
            this.progressBar1.Location = new System.Drawing.Point(30, 197);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(380, 28);
            this.progressBar1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Russo One", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(463, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "SafetyGymBelt";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(471, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 76);
            this.label7.TabIndex = 15;
            this.label7.Text = "This Software Is A Work In Progress";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(471, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 57);
            this.label8.TabIndex = 16;
            this.label8.Text = "This was made by students in SBE 306 class";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GetHrtRt
            // 
            this.GetHrtRt.Interval = 500;
            this.GetHrtRt.Tick += new System.EventHandler(this.GetHrtRt_Tick);
            // 
            // GetBdyTmp
            // 
            this.GetBdyTmp.Interval = 500;
            this.GetBdyTmp.Tick += new System.EventHandler(this.GetBdyTmp_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(626, 652);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RepDisp);
            this.Controls.Add(this.Bio_Mets);
            this.Controls.Add(this.TimDis);
            this.Controls.Add(this.LCD_Control);
            this.Controls.Add(this.SerialConn);
            this.Controls.Add(this.AlCntrl);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Safety Gym Belt";
            this.AlCntrl.ResumeLayout(false);
            this.AlCntrl.PerformLayout();
            this.SerialConn.ResumeLayout(false);
            this.LCD_Control.ResumeLayout(false);
            this.TimDis.ResumeLayout(false);
            this.TimDis.PerformLayout();
            this.Bio_Mets.ResumeLayout(false);
            this.Bio_Mets.PerformLayout();
            this.RepDisp.ResumeLayout(false);
            this.RepDisp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ComSel;
        private System.Windows.Forms.Button SendTime;
        private System.Windows.Forms.CheckBox AlarmCtrl_02;
        private System.Windows.Forms.CheckBox AlarmCtrl_01;
        private System.Windows.Forms.CheckBox AlarmCtrl_03;
        private System.Windows.Forms.GroupBox AlCntrl;
        private System.Windows.Forms.GroupBox SerialConn;
        private System.Windows.Forms.GroupBox LCD_Control;
        private System.Windows.Forms.GroupBox TimDis;
        private System.Windows.Forms.Button rstbtn;
        private System.Windows.Forms.Button stbtn;
        private System.Windows.Forms.Label TimerDisp;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox Bio_Mets;
        private System.Windows.Forms.Label BdyTempDisp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox RepDisp;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker TimeSet;
        private System.Windows.Forms.CheckBox BdyTmp;
        private System.Windows.Forms.CheckBox HrtRt;
        private System.Windows.Forms.Timer GetHrtRt;
        private System.Windows.Forms.Timer GetBdyTmp;
    }
}
