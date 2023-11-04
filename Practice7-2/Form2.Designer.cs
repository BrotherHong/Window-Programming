namespace Practice7_2
{
    partial class Form2
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
            panel1 = new Panel();
            lblWordKind = new Label();
            lblChinese = new Label();
            lblWord = new Label();
            btnNext = new Button();
            btnCheck = new Button();
            cBoxMark = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(lblWordKind);
            panel1.Controls.Add(lblChinese);
            panel1.Controls.Add(lblWord);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(569, 426);
            panel1.TabIndex = 0;
            // 
            // lblWordKind
            // 
            lblWordKind.AutoSize = true;
            lblWordKind.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblWordKind.Location = new Point(46, 319);
            lblWordKind.Name = "lblWordKind";
            lblWordKind.Size = new Size(75, 35);
            lblWordKind.TabIndex = 2;
            lblWordKind.Text = "詞性:";
            // 
            // lblChinese
            // 
            lblChinese.AutoSize = true;
            lblChinese.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblChinese.Location = new Point(46, 173);
            lblChinese.Name = "lblChinese";
            lblChinese.Size = new Size(75, 35);
            lblChinese.TabIndex = 1;
            lblChinese.Text = "中文:";
            // 
            // lblWord
            // 
            lblWord.AutoSize = true;
            lblWord.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblWord.Location = new Point(46, 45);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(126, 35);
            lblWord.TabIndex = 0;
            lblWord.Text = "單字: lala";
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.Location = new Point(626, 385);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(125, 36);
            btnNext.TabIndex = 1;
            btnNext.Text = "下一個";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCheck.Location = new Point(626, 331);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(125, 36);
            btnCheck.TabIndex = 2;
            btnCheck.Text = "查看";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // cBoxMark
            // 
            cBoxMark.AutoSize = true;
            cBoxMark.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cBoxMark.Location = new Point(626, 283);
            cBoxMark.Name = "cBoxMark";
            cBoxMark.Size = new Size(60, 24);
            cBoxMark.TabIndex = 3;
            cBoxMark.Text = "標記";
            cBoxMark.UseVisualStyleBackColor = true;
            cBoxMark.CheckedChanged += cBoxMark_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cBoxMark);
            Controls.Add(btnCheck);
            Controls.Add(btnNext);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "單字測驗";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnNext;
        private Button btnCheck;
        private CheckBox cBoxMark;
        private Label lblChinese;
        private Label lblWord;
        private Label lblWordKind;
    }
}