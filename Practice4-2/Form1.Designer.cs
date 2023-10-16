namespace Practice4_2
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
            tabControl1 = new TabControl();
            tabFarm = new TabPage();
            groupTools = new GroupBox();
            rbtnCut = new RadioButton();
            rbtnFert = new RadioButton();
            rbtnSeed = new RadioButton();
            rbtnWater = new RadioButton();
            tabStore = new TabPage();
            btnBuySell = new Button();
            labelFruit = new Label();
            cboxFruit = new CheckBox();
            labelFert = new Label();
            cboxFert = new CheckBox();
            labelSeed = new Label();
            cboxSeed = new CheckBox();
            labelMoney = new Label();
            tabControl1.SuspendLayout();
            tabFarm.SuspendLayout();
            groupTools.SuspendLayout();
            tabStore.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabFarm);
            tabControl1.Controls.Add(tabStore);
            tabControl1.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.ItemSize = new Size(96, 40);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(750, 480);
            tabControl1.TabIndex = 0;
            tabControl1.Selected += tabControl1_Selected;
            // 
            // tabFarm
            // 
            tabFarm.BorderStyle = BorderStyle.FixedSingle;
            tabFarm.Controls.Add(groupTools);
            tabFarm.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabFarm.Location = new Point(4, 44);
            tabFarm.Name = "tabFarm";
            tabFarm.Padding = new Padding(3);
            tabFarm.Size = new Size(742, 432);
            tabFarm.TabIndex = 0;
            tabFarm.Text = "農場";
            tabFarm.UseVisualStyleBackColor = true;
            // 
            // groupTools
            // 
            groupTools.Controls.Add(rbtnCut);
            groupTools.Controls.Add(rbtnFert);
            groupTools.Controls.Add(rbtnSeed);
            groupTools.Controls.Add(rbtnWater);
            groupTools.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupTools.Location = new Point(357, 304);
            groupTools.Name = "groupTools";
            groupTools.Size = new Size(346, 74);
            groupTools.TabIndex = 0;
            groupTools.TabStop = false;
            groupTools.Text = "工具";
            // 
            // rbtnCut
            // 
            rbtnCut.AutoSize = true;
            rbtnCut.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnCut.Location = new Point(253, 36);
            rbtnCut.Name = "rbtnCut";
            rbtnCut.Size = new Size(66, 28);
            rbtnCut.TabIndex = 3;
            rbtnCut.TabStop = true;
            rbtnCut.Text = "鐮刀";
            rbtnCut.UseVisualStyleBackColor = true;
            // 
            // rbtnFert
            // 
            rbtnFert.AutoSize = true;
            rbtnFert.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnFert.Location = new Point(181, 36);
            rbtnFert.Name = "rbtnFert";
            rbtnFert.Size = new Size(66, 28);
            rbtnFert.TabIndex = 2;
            rbtnFert.TabStop = true;
            rbtnFert.Text = "肥料";
            rbtnFert.UseVisualStyleBackColor = true;
            // 
            // rbtnSeed
            // 
            rbtnSeed.AutoSize = true;
            rbtnSeed.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnSeed.Location = new Point(109, 36);
            rbtnSeed.Name = "rbtnSeed";
            rbtnSeed.Size = new Size(66, 28);
            rbtnSeed.TabIndex = 1;
            rbtnSeed.TabStop = true;
            rbtnSeed.Text = "種子";
            rbtnSeed.UseVisualStyleBackColor = true;
            // 
            // rbtnWater
            // 
            rbtnWater.AutoSize = true;
            rbtnWater.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnWater.Location = new Point(18, 36);
            rbtnWater.Name = "rbtnWater";
            rbtnWater.Size = new Size(85, 28);
            rbtnWater.TabIndex = 0;
            rbtnWater.TabStop = true;
            rbtnWater.Text = "澆水壺";
            rbtnWater.UseVisualStyleBackColor = true;
            // 
            // tabStore
            // 
            tabStore.BorderStyle = BorderStyle.FixedSingle;
            tabStore.Controls.Add(btnBuySell);
            tabStore.Controls.Add(labelFruit);
            tabStore.Controls.Add(cboxFruit);
            tabStore.Controls.Add(labelFert);
            tabStore.Controls.Add(cboxFert);
            tabStore.Controls.Add(labelSeed);
            tabStore.Controls.Add(cboxSeed);
            tabStore.Controls.Add(labelMoney);
            tabStore.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabStore.Location = new Point(4, 44);
            tabStore.Name = "tabStore";
            tabStore.Padding = new Padding(3);
            tabStore.Size = new Size(742, 432);
            tabStore.TabIndex = 1;
            tabStore.Text = "商店";
            tabStore.UseVisualStyleBackColor = true;
            // 
            // btnBuySell
            // 
            btnBuySell.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuySell.Location = new Point(298, 323);
            btnBuySell.Name = "btnBuySell";
            btnBuySell.Size = new Size(109, 41);
            btnBuySell.TabIndex = 7;
            btnBuySell.Text = "買/賣";
            btnBuySell.UseVisualStyleBackColor = true;
            btnBuySell.Click += btnBuySell_Click;
            // 
            // labelFruit
            // 
            labelFruit.AutoSize = true;
            labelFruit.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelFruit.Location = new Point(529, 199);
            labelFruit.Name = "labelFruit";
            labelFruit.Size = new Size(72, 26);
            labelFruit.TabIndex = 6;
            labelFruit.Text = "擁有:X";
            // 
            // cboxFruit
            // 
            cboxFruit.AutoSize = true;
            cboxFruit.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cboxFruit.Location = new Point(528, 154);
            cboxFruit.Name = "cboxFruit";
            cboxFruit.Size = new Size(73, 30);
            cboxFruit.TabIndex = 5;
            cboxFruit.Text = "果實";
            cboxFruit.UseVisualStyleBackColor = true;
            // 
            // labelFert
            // 
            labelFert.AutoSize = true;
            labelFert.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelFert.Location = new Point(321, 199);
            labelFert.Name = "labelFert";
            labelFert.Size = new Size(72, 26);
            labelFert.TabIndex = 4;
            labelFert.Text = "擁有:X";
            // 
            // cboxFert
            // 
            cboxFert.AutoSize = true;
            cboxFert.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cboxFert.Location = new Point(320, 154);
            cboxFert.Name = "cboxFert";
            cboxFert.Size = new Size(73, 30);
            cboxFert.TabIndex = 3;
            cboxFert.Text = "肥料";
            cboxFert.UseVisualStyleBackColor = true;
            // 
            // labelSeed
            // 
            labelSeed.AutoSize = true;
            labelSeed.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelSeed.Location = new Point(116, 199);
            labelSeed.Name = "labelSeed";
            labelSeed.Size = new Size(72, 26);
            labelSeed.TabIndex = 2;
            labelSeed.Text = "擁有:X";
            // 
            // cboxSeed
            // 
            cboxSeed.AutoSize = true;
            cboxSeed.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cboxSeed.Location = new Point(115, 154);
            cboxSeed.Name = "cboxSeed";
            cboxSeed.Size = new Size(73, 30);
            cboxSeed.TabIndex = 1;
            cboxSeed.Text = "種子";
            cboxSeed.UseVisualStyleBackColor = true;
            // 
            // labelMoney
            // 
            labelMoney.AutoSize = true;
            labelMoney.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelMoney.Location = new Point(309, 63);
            labelMoney.Name = "labelMoney";
            labelMoney.Size = new Size(98, 26);
            labelMoney.TabIndex = 0;
            labelMoney.Text = "金錢:XXX";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 504);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "種田小遊戲";
            tabControl1.ResumeLayout(false);
            tabFarm.ResumeLayout(false);
            groupTools.ResumeLayout(false);
            groupTools.PerformLayout();
            tabStore.ResumeLayout(false);
            tabStore.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabFarm;
        private TabPage tabStore;
        private GroupBox groupTools;
        private RadioButton rbtnCut;
        private RadioButton rbtnFert;
        private RadioButton rbtnSeed;
        private RadioButton rbtnWater;
        private CheckBox cboxSeed;
        private Label labelMoney;
        private Label labelSeed;
        private Button btnBuySell;
        private Label labelFruit;
        private CheckBox cboxFruit;
        private Label labelFert;
        private CheckBox cboxFert;
    }
}