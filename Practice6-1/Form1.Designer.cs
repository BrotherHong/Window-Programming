namespace Practice6_1
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
            timer1 = new System.Windows.Forms.Timer(components);
            panelButtons = new Panel();
            pboxTarget = new PictureBox();
            btnPaint = new Button();
            btnSelectImg = new Button();
            lblTime = new Label();
            lblMoves = new Label();
            trackBarDisplay = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pboxTarget).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarDisplay).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // panelButtons
            // 
            panelButtons.Location = new Point(39, 47);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(270, 270);
            panelButtons.TabIndex = 0;
            // 
            // pboxTarget
            // 
            pboxTarget.Location = new Point(496, 47);
            pboxTarget.Name = "pboxTarget";
            pboxTarget.Size = new Size(270, 270);
            pboxTarget.TabIndex = 1;
            pboxTarget.TabStop = false;
            // 
            // btnPaint
            // 
            btnPaint.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPaint.Location = new Point(89, 383);
            btnPaint.Name = "btnPaint";
            btnPaint.Size = new Size(174, 32);
            btnPaint.TabIndex = 2;
            btnPaint.Text = "繪製拼圖板";
            btnPaint.UseVisualStyleBackColor = true;
            btnPaint.Click += btnPaint_Click;
            // 
            // btnSelectImg
            // 
            btnSelectImg.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSelectImg.Location = new Point(550, 383);
            btnSelectImg.Name = "btnSelectImg";
            btnSelectImg.Size = new Size(174, 32);
            btnSelectImg.TabIndex = 3;
            btnSelectImg.Text = "選擇圖片";
            btnSelectImg.UseVisualStyleBackColor = true;
            btnSelectImg.Click += btnSelectImg_Click;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.Location = new Point(356, 69);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(94, 20);
            lblTime.TabIndex = 4;
            lblTime.Text = "Time: 00:00";
            // 
            // lblMoves
            // 
            lblMoves.AutoSize = true;
            lblMoves.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMoves.Location = new Point(356, 105);
            lblMoves.Name = "lblMoves";
            lblMoves.Size = new Size(90, 20);
            lblMoves.TabIndex = 5;
            lblMoves.Text = "移動步數: 0";
            // 
            // trackBarDisplay
            // 
            trackBarDisplay.LargeChange = 1;
            trackBarDisplay.Location = new Point(563, 332);
            trackBarDisplay.Maximum = 1;
            trackBarDisplay.Name = "trackBarDisplay";
            trackBarDisplay.Size = new Size(148, 45);
            trackBarDisplay.TabIndex = 6;
            trackBarDisplay.ValueChanged += trackBarDisplay_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(500, 332);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 7;
            label1.Text = "不顯示";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(717, 332);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 8;
            label2.Text = "顯示";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trackBarDisplay);
            Controls.Add(lblMoves);
            Controls.Add(lblTime);
            Controls.Add(btnSelectImg);
            Controls.Add(btnPaint);
            Controls.Add(pboxTarget);
            Controls.Add(panelButtons);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pboxTarget).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarDisplay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Panel panelButtons;
        private PictureBox pboxTarget;
        private Button btnPaint;
        private Button btnSelectImg;
        private Label lblTime;
        private Label lblMoves;
        private TrackBar trackBarDisplay;
        private Label label1;
        private Label label2;
    }
}