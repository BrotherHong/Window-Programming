namespace Practice4_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn1 = new Button();
            imgList1 = new ImageList(components);
            btn2 = new Button();
            imgList2 = new ImageList(components);
            btn3 = new Button();
            imgList3 = new ImageList(components);
            btn4 = new Button();
            imgList4 = new ImageList(components);
            btnUnlock = new Button();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.ImageList = imgList1;
            btn1.Location = new Point(141, 114);
            btn1.Name = "btn1";
            btn1.Size = new Size(97, 120);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // imgList1
            // 
            imgList1.ColorDepth = ColorDepth.Depth8Bit;
            imgList1.ImageStream = (ImageListStreamer)resources.GetObject("imgList1.ImageStream");
            imgList1.TransparentColor = Color.Transparent;
            imgList1.Images.SetKeyName(0, "0.jpg");
            imgList1.Images.SetKeyName(1, "1.jpg");
            imgList1.Images.SetKeyName(2, "2.jpg");
            imgList1.Images.SetKeyName(3, "3.jpg");
            imgList1.Images.SetKeyName(4, "4.jpg");
            imgList1.Images.SetKeyName(5, "5.jpg");
            imgList1.Images.SetKeyName(6, "6.jpg");
            imgList1.Images.SetKeyName(7, "7.jpg");
            imgList1.Images.SetKeyName(8, "8.jpg");
            imgList1.Images.SetKeyName(9, "9.jpg");
            // 
            // btn2
            // 
            btn2.ImageList = imgList2;
            btn2.Location = new Point(277, 114);
            btn2.Name = "btn2";
            btn2.Size = new Size(97, 120);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // imgList2
            // 
            imgList2.ColorDepth = ColorDepth.Depth8Bit;
            imgList2.ImageStream = (ImageListStreamer)resources.GetObject("imgList2.ImageStream");
            imgList2.TransparentColor = Color.Transparent;
            imgList2.Images.SetKeyName(0, "0.jpg");
            imgList2.Images.SetKeyName(1, "1.jpg");
            imgList2.Images.SetKeyName(2, "2.jpg");
            imgList2.Images.SetKeyName(3, "3.jpg");
            imgList2.Images.SetKeyName(4, "4.jpg");
            imgList2.Images.SetKeyName(5, "5.jpg");
            imgList2.Images.SetKeyName(6, "6.jpg");
            imgList2.Images.SetKeyName(7, "7.jpg");
            imgList2.Images.SetKeyName(8, "8.jpg");
            imgList2.Images.SetKeyName(9, "9.jpg");
            // 
            // btn3
            // 
            btn3.ImageList = imgList3;
            btn3.Location = new Point(412, 114);
            btn3.Name = "btn3";
            btn3.Size = new Size(97, 120);
            btn3.TabIndex = 2;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // imgList3
            // 
            imgList3.ColorDepth = ColorDepth.Depth8Bit;
            imgList3.ImageStream = (ImageListStreamer)resources.GetObject("imgList3.ImageStream");
            imgList3.TransparentColor = Color.Transparent;
            imgList3.Images.SetKeyName(0, "0.jpg");
            imgList3.Images.SetKeyName(1, "1.jpg");
            imgList3.Images.SetKeyName(2, "2.jpg");
            imgList3.Images.SetKeyName(3, "3.jpg");
            imgList3.Images.SetKeyName(4, "4.jpg");
            imgList3.Images.SetKeyName(5, "5.jpg");
            imgList3.Images.SetKeyName(6, "6.jpg");
            imgList3.Images.SetKeyName(7, "7.jpg");
            imgList3.Images.SetKeyName(8, "8.jpg");
            imgList3.Images.SetKeyName(9, "9.jpg");
            // 
            // btn4
            // 
            btn4.ImageList = imgList4;
            btn4.Location = new Point(548, 114);
            btn4.Name = "btn4";
            btn4.Size = new Size(97, 120);
            btn4.TabIndex = 3;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // imgList4
            // 
            imgList4.ColorDepth = ColorDepth.Depth8Bit;
            imgList4.ImageStream = (ImageListStreamer)resources.GetObject("imgList4.ImageStream");
            imgList4.TransparentColor = Color.Transparent;
            imgList4.Images.SetKeyName(0, "0.jpg");
            imgList4.Images.SetKeyName(1, "1.jpg");
            imgList4.Images.SetKeyName(2, "2.jpg");
            imgList4.Images.SetKeyName(3, "3.jpg");
            imgList4.Images.SetKeyName(4, "4.jpg");
            imgList4.Images.SetKeyName(5, "5.jpg");
            imgList4.Images.SetKeyName(6, "6.jpg");
            imgList4.Images.SetKeyName(7, "7.jpg");
            imgList4.Images.SetKeyName(8, "8.jpg");
            imgList4.Images.SetKeyName(9, "9.jpg");
            // 
            // btnUnlock
            // 
            btnUnlock.Location = new Point(360, 355);
            btnUnlock.Name = "btnUnlock";
            btnUnlock.Size = new Size(75, 23);
            btnUnlock.TabIndex = 4;
            btnUnlock.Text = "解鎖";
            btnUnlock.UseVisualStyleBackColor = true;
            btnUnlock.Click += btnUnlock_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUnlock);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "數字密碼鎖";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private ImageList imgList1;
        private ImageList imgList2;
        private ImageList imgList3;
        private ImageList imgList4;
        private Button btnUnlock;
    }
}