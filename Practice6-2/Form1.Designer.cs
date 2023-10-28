namespace Practice6_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dateTimePicker1 = new DateTimePicker();
            panel_h1 = new Panel();
            panel_h2 = new Panel();
            panel_m2 = new Panel();
            panel_m1 = new Panel();
            panel_s2 = new Panel();
            panel_s1 = new Panel();
            lbl_t1 = new Label();
            lbl_t2 = new Label();
            btnSelectAlarm = new Button();
            lblAlarmPath = new Label();
            lblSetAlarm = new Label();
            btnAlarmTrigger = new Button();
            lblAmPm = new Label();
            rtextHist = new RichTextBox();
            btnExport = new Button();
            mainTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "tt hh:mm";
            dateTimePicker1.DropDownAlign = LeftRightAlignment.Right;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(640, 215);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(115, 23);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.Value = new DateTime(2023, 10, 27, 21, 25, 8, 0);
            // 
            // panel_h1
            // 
            panel_h1.Location = new Point(41, 29);
            panel_h1.Name = "panel_h1";
            panel_h1.Size = new Size(100, 140);
            panel_h1.TabIndex = 1;
            // 
            // panel_h2
            // 
            panel_h2.Location = new Point(147, 29);
            panel_h2.Name = "panel_h2";
            panel_h2.Size = new Size(100, 140);
            panel_h2.TabIndex = 2;
            // 
            // panel_m2
            // 
            panel_m2.Location = new Point(411, 29);
            panel_m2.Name = "panel_m2";
            panel_m2.Size = new Size(100, 140);
            panel_m2.TabIndex = 4;
            // 
            // panel_m1
            // 
            panel_m1.Location = new Point(305, 29);
            panel_m1.Name = "panel_m1";
            panel_m1.Size = new Size(100, 140);
            panel_m1.TabIndex = 3;
            // 
            // panel_s2
            // 
            panel_s2.Location = new Point(676, 29);
            panel_s2.Name = "panel_s2";
            panel_s2.Size = new Size(100, 140);
            panel_s2.TabIndex = 6;
            // 
            // panel_s1
            // 
            panel_s1.Location = new Point(570, 29);
            panel_s1.Name = "panel_s1";
            panel_s1.Size = new Size(100, 140);
            panel_s1.TabIndex = 5;
            // 
            // lbl_t1
            // 
            lbl_t1.AutoSize = true;
            lbl_t1.BackColor = Color.Transparent;
            lbl_t1.Font = new Font("Microsoft JhengHei UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_t1.Location = new Point(242, 29);
            lbl_t1.Name = "lbl_t1";
            lbl_t1.Size = new Size(76, 122);
            lbl_t1.TabIndex = 7;
            lbl_t1.Text = ":";
            // 
            // lbl_t2
            // 
            lbl_t2.AutoSize = true;
            lbl_t2.BackColor = Color.Transparent;
            lbl_t2.Font = new Font("Microsoft JhengHei UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_t2.Location = new Point(509, 29);
            lbl_t2.Name = "lbl_t2";
            lbl_t2.Size = new Size(76, 122);
            lbl_t2.TabIndex = 8;
            lbl_t2.Text = ":";
            // 
            // btnSelectAlarm
            // 
            btnSelectAlarm.Location = new Point(39, 215);
            btnSelectAlarm.Name = "btnSelectAlarm";
            btnSelectAlarm.Size = new Size(75, 23);
            btnSelectAlarm.TabIndex = 9;
            btnSelectAlarm.Text = "選擇鬧鈴";
            btnSelectAlarm.UseVisualStyleBackColor = true;
            btnSelectAlarm.Click += btnSelectAlarm_Click;
            // 
            // lblAlarmPath
            // 
            lblAlarmPath.AutoSize = true;
            lblAlarmPath.Location = new Point(120, 219);
            lblAlarmPath.Name = "lblAlarmPath";
            lblAlarmPath.Size = new Size(79, 15);
            lblAlarmPath.TabIndex = 10;
            lblAlarmPath.Text = "尚未選擇檔案";
            // 
            // lblSetAlarm
            // 
            lblSetAlarm.AutoSize = true;
            lblSetAlarm.Location = new Point(555, 219);
            lblSetAlarm.Name = "lblSetAlarm";
            lblSetAlarm.Size = new Size(79, 15);
            lblSetAlarm.TabIndex = 11;
            lblSetAlarm.Text = "設定鬧鐘時間";
            // 
            // btnAlarmTrigger
            // 
            btnAlarmTrigger.Location = new Point(761, 215);
            btnAlarmTrigger.Name = "btnAlarmTrigger";
            btnAlarmTrigger.Size = new Size(75, 23);
            btnAlarmTrigger.TabIndex = 12;
            btnAlarmTrigger.Text = "啟動";
            btnAlarmTrigger.UseVisualStyleBackColor = true;
            btnAlarmTrigger.Click += btnAlarmTrigger_Click;
            // 
            // lblAmPm
            // 
            lblAmPm.AutoSize = true;
            lblAmPm.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAmPm.Location = new Point(782, 134);
            lblAmPm.Name = "lblAmPm";
            lblAmPm.Size = new Size(69, 35);
            lblAmPm.TabIndex = 13;
            lblAmPm.Text = "上午";
            // 
            // rtextHist
            // 
            rtextHist.BorderStyle = BorderStyle.FixedSingle;
            rtextHist.Cursor = Cursors.IBeam;
            rtextHist.Location = new Point(873, 29);
            rtextHist.Name = "rtextHist";
            rtextHist.ReadOnly = true;
            rtextHist.Size = new Size(241, 166);
            rtextHist.TabIndex = 14;
            rtextHist.Text = "";
            // 
            // btnExport
            // 
            btnExport.Location = new Point(873, 215);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(75, 23);
            btnExport.TabIndex = 15;
            btnExport.Text = "匯出記錄檔";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // mainTimer
            // 
            mainTimer.Enabled = true;
            mainTimer.Interval = 1000;
            mainTimer.Tick += mainTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 268);
            Controls.Add(btnExport);
            Controls.Add(rtextHist);
            Controls.Add(lblAmPm);
            Controls.Add(btnAlarmTrigger);
            Controls.Add(lblSetAlarm);
            Controls.Add(btnSelectAlarm);
            Controls.Add(panel_s2);
            Controls.Add(panel_s1);
            Controls.Add(panel_m2);
            Controls.Add(panel_m1);
            Controls.Add(panel_h2);
            Controls.Add(panel_h1);
            Controls.Add(dateTimePicker1);
            Controls.Add(lbl_t1);
            Controls.Add(lbl_t2);
            Controls.Add(lblAlarmPath);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Panel panel_h1;
        private Panel panel_h2;
        private Panel panel_m2;
        private Panel panel_m1;
        private Panel panel_s2;
        private Panel panel_s1;
        private Label lbl_t1;
        private Label lbl_t2;
        private Button btnSelectAlarm;
        private Label lblAlarmPath;
        private Label lblSetAlarm;
        private Button btnAlarmTrigger;
        private Label lblAmPm;
        private RichTextBox rtextHist;
        private Button btnExport;
        private System.Windows.Forms.Timer mainTimer;
    }
}