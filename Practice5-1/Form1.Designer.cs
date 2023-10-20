namespace Practice5_1
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
            labelPhase = new Label();
            labelTime = new Label();
            btnStart = new Button();
            tmrGame = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // labelPhase
            // 
            labelPhase.AutoSize = true;
            labelPhase.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelPhase.Location = new Point(332, 37);
            labelPhase.Name = "labelPhase";
            labelPhase.Size = new Size(96, 26);
            labelPhase.TabIndex = 0;
            labelPhase.Text = "準備階段";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelTime.Location = new Point(367, 77);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(27, 30);
            labelTime.TabIndex = 1;
            labelTime.Text = "0";
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.Location = new Point(321, 200);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(115, 43);
            btnStart.TabIndex = 2;
            btnStart.Text = "開始遊戲";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // tmrGame
            // 
            tmrGame.Interval = 1000;
            tmrGame.Tick += tmrGame_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(btnStart);
            Controls.Add(labelTime);
            Controls.Add(labelPhase);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyPress += Form1_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPhase;
        private Label labelTime;
        private Button btnStart;
        private System.Windows.Forms.Timer tmrGame;
    }
}