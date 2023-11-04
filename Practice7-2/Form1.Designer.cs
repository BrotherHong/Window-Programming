namespace Practice7_2
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
            menuStrip1 = new MenuStrip();
            menu_file = new ToolStripMenuItem();
            menuItem_file_new = new ToolStripMenuItem();
            menuItem_file_open = new ToolStripMenuItem();
            menuItem_file_save = new ToolStripMenuItem();
            menuItem_file_saveAs = new ToolStripMenuItem();
            menuItem_file_exit = new ToolStripMenuItem();
            menu_feature = new ToolStripMenuItem();
            menuItem_feature_newWord = new ToolStripMenuItem();
            menuItem_feature_searchWord = new ToolStripMenuItem();
            menu_view = new ToolStripMenuItem();
            menuItem_view_font = new ToolStripMenuItem();
            menuItem_view_showMarkedOnly = new ToolStripMenuItem();
            menuItem_view_clearMark = new ToolStripMenuItem();
            richBoxWords = new RichTextBox();
            panelFeature = new Panel();
            comboWordKind = new ComboBox();
            lblWordKind = new Label();
            cBoxWordKind = new CheckBox();
            tBoxChinese = new TextBox();
            lblChinese = new Label();
            cBoxChinese = new CheckBox();
            tBoxWord = new TextBox();
            lblWord = new Label();
            cBoxWord = new CheckBox();
            btnFeature = new Button();
            menuItem_feature_test = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            panelFeature.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menu_file, menu_feature, menu_view });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menu_file
            // 
            menu_file.DropDownItems.AddRange(new ToolStripItem[] { menuItem_file_new, menuItem_file_open, menuItem_file_save, menuItem_file_saveAs, menuItem_file_exit });
            menu_file.Name = "menu_file";
            menu_file.Size = new Size(43, 20);
            menu_file.Text = "檔案";
            // 
            // menuItem_file_new
            // 
            menuItem_file_new.Name = "menuItem_file_new";
            menuItem_file_new.Size = new Size(122, 22);
            menuItem_file_new.Text = "新增";
            menuItem_file_new.Click += menuItem_file_new_Click;
            // 
            // menuItem_file_open
            // 
            menuItem_file_open.Name = "menuItem_file_open";
            menuItem_file_open.Size = new Size(122, 22);
            menuItem_file_open.Text = "開啟舊檔";
            menuItem_file_open.Click += menuItem_file_open_Click;
            // 
            // menuItem_file_save
            // 
            menuItem_file_save.Name = "menuItem_file_save";
            menuItem_file_save.Size = new Size(122, 22);
            menuItem_file_save.Text = "儲存";
            menuItem_file_save.Click += menuItem_file_save_Click;
            // 
            // menuItem_file_saveAs
            // 
            menuItem_file_saveAs.Name = "menuItem_file_saveAs";
            menuItem_file_saveAs.Size = new Size(122, 22);
            menuItem_file_saveAs.Text = "另存新檔";
            menuItem_file_saveAs.Click += menuItem_file_saveAs_Click;
            // 
            // menuItem_file_exit
            // 
            menuItem_file_exit.Name = "menuItem_file_exit";
            menuItem_file_exit.Size = new Size(122, 22);
            menuItem_file_exit.Text = "離開";
            menuItem_file_exit.Click += menuItem_file_exit_Click;
            // 
            // menu_feature
            // 
            menu_feature.DropDownItems.AddRange(new ToolStripItem[] { menuItem_feature_newWord, menuItem_feature_searchWord, menuItem_feature_test });
            menu_feature.Name = "menu_feature";
            menu_feature.Size = new Size(43, 20);
            menu_feature.Text = "功能";
            // 
            // menuItem_feature_newWord
            // 
            menuItem_feature_newWord.Name = "menuItem_feature_newWord";
            menuItem_feature_newWord.Size = new Size(180, 22);
            menuItem_feature_newWord.Text = "新增單字";
            menuItem_feature_newWord.Click += menuItem_feature_newWord_Click;
            // 
            // menuItem_feature_searchWord
            // 
            menuItem_feature_searchWord.Name = "menuItem_feature_searchWord";
            menuItem_feature_searchWord.Size = new Size(180, 22);
            menuItem_feature_searchWord.Text = "搜尋單字";
            menuItem_feature_searchWord.Click += menuItem_feature_searchWord_Click;
            // 
            // menu_view
            // 
            menu_view.DropDownItems.AddRange(new ToolStripItem[] { menuItem_view_font, menuItem_view_showMarkedOnly, menuItem_view_clearMark });
            menu_view.Name = "menu_view";
            menu_view.Size = new Size(43, 20);
            menu_view.Text = "檢視";
            // 
            // menuItem_view_font
            // 
            menuItem_view_font.Name = "menuItem_view_font";
            menuItem_view_font.Size = new Size(158, 22);
            menuItem_view_font.Text = "字型大小";
            menuItem_view_font.Click += menuItem_view_font_Click;
            // 
            // menuItem_view_showMarkedOnly
            // 
            menuItem_view_showMarkedOnly.Name = "menuItem_view_showMarkedOnly";
            menuItem_view_showMarkedOnly.Size = new Size(158, 22);
            menuItem_view_showMarkedOnly.Text = "只顯示標記單字";
            menuItem_view_showMarkedOnly.Click += menuItem_view_showMarkedOnly_Click;
            // 
            // menuItem_view_clearMark
            // 
            menuItem_view_clearMark.Name = "menuItem_view_clearMark";
            menuItem_view_clearMark.Size = new Size(158, 22);
            menuItem_view_clearMark.Text = "清除標記";
            menuItem_view_clearMark.Click += menuItem_view_clearMark_Click;
            // 
            // richBoxWords
            // 
            richBoxWords.Cursor = Cursors.IBeam;
            richBoxWords.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richBoxWords.Location = new Point(12, 27);
            richBoxWords.Name = "richBoxWords";
            richBoxWords.ReadOnly = true;
            richBoxWords.Size = new Size(586, 411);
            richBoxWords.TabIndex = 1;
            richBoxWords.Text = "";
            richBoxWords.WordWrap = false;
            // 
            // panelFeature
            // 
            panelFeature.Controls.Add(comboWordKind);
            panelFeature.Controls.Add(lblWordKind);
            panelFeature.Controls.Add(cBoxWordKind);
            panelFeature.Controls.Add(tBoxChinese);
            panelFeature.Controls.Add(lblChinese);
            panelFeature.Controls.Add(cBoxChinese);
            panelFeature.Controls.Add(tBoxWord);
            panelFeature.Controls.Add(lblWord);
            panelFeature.Controls.Add(cBoxWord);
            panelFeature.Controls.Add(btnFeature);
            panelFeature.Location = new Point(604, 27);
            panelFeature.Name = "panelFeature";
            panelFeature.Size = new Size(184, 411);
            panelFeature.TabIndex = 2;
            // 
            // comboWordKind
            // 
            comboWordKind.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboWordKind.FormattingEnabled = true;
            comboWordKind.Location = new Point(51, 284);
            comboWordKind.Name = "comboWordKind";
            comboWordKind.Size = new Size(121, 28);
            comboWordKind.TabIndex = 9;
            // 
            // lblWordKind
            // 
            lblWordKind.AutoSize = true;
            lblWordKind.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblWordKind.Location = new Point(51, 257);
            lblWordKind.Name = "lblWordKind";
            lblWordKind.Size = new Size(41, 20);
            lblWordKind.TabIndex = 8;
            lblWordKind.Text = "詞性";
            // 
            // cBoxWordKind
            // 
            cBoxWordKind.AutoSize = true;
            cBoxWordKind.Location = new Point(20, 288);
            cBoxWordKind.Name = "cBoxWordKind";
            cBoxWordKind.Size = new Size(15, 14);
            cBoxWordKind.TabIndex = 7;
            cBoxWordKind.UseVisualStyleBackColor = true;
            // 
            // tBoxChinese
            // 
            tBoxChinese.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxChinese.Location = new Point(51, 195);
            tBoxChinese.Name = "tBoxChinese";
            tBoxChinese.Size = new Size(100, 28);
            tBoxChinese.TabIndex = 6;
            // 
            // lblChinese
            // 
            lblChinese.AutoSize = true;
            lblChinese.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblChinese.Location = new Point(51, 172);
            lblChinese.Name = "lblChinese";
            lblChinese.Size = new Size(41, 20);
            lblChinese.TabIndex = 5;
            lblChinese.Text = "中文";
            // 
            // cBoxChinese
            // 
            cBoxChinese.AutoSize = true;
            cBoxChinese.Location = new Point(20, 199);
            cBoxChinese.Name = "cBoxChinese";
            cBoxChinese.Size = new Size(15, 14);
            cBoxChinese.TabIndex = 4;
            cBoxChinese.UseVisualStyleBackColor = true;
            // 
            // tBoxWord
            // 
            tBoxWord.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tBoxWord.Location = new Point(51, 107);
            tBoxWord.Name = "tBoxWord";
            tBoxWord.Size = new Size(100, 28);
            tBoxWord.TabIndex = 3;
            // 
            // lblWord
            // 
            lblWord.AutoSize = true;
            lblWord.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblWord.Location = new Point(51, 84);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(41, 20);
            lblWord.TabIndex = 2;
            lblWord.Text = "單字";
            // 
            // cBoxWord
            // 
            cBoxWord.AutoSize = true;
            cBoxWord.Location = new Point(20, 111);
            cBoxWord.Name = "cBoxWord";
            cBoxWord.Size = new Size(15, 14);
            cBoxWord.TabIndex = 1;
            cBoxWord.UseVisualStyleBackColor = true;
            // 
            // btnFeature
            // 
            btnFeature.Location = new Point(106, 385);
            btnFeature.Name = "btnFeature";
            btnFeature.Size = new Size(75, 23);
            btnFeature.TabIndex = 0;
            btnFeature.Text = "功能";
            btnFeature.UseVisualStyleBackColor = true;
            btnFeature.Click += btnFeature_Click;
            // 
            // menuItem_feature_test
            // 
            menuItem_feature_test.Name = "menuItem_feature_test";
            menuItem_feature_test.Size = new Size(180, 22);
            menuItem_feature_test.Text = "單字測驗";
            menuItem_feature_test.Click += menuItem_feature_test_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFeature);
            Controls.Add(richBoxWords);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "單字卡";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelFeature.ResumeLayout(false);
            panelFeature.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menu_file;
        private ToolStripMenuItem menuItem_file_new;
        private ToolStripMenuItem menuItem_file_open;
        private ToolStripMenuItem menuItem_file_save;
        private ToolStripMenuItem menuItem_file_saveAs;
        private ToolStripMenuItem menuItem_file_exit;
        private ToolStripMenuItem menu_feature;
        private ToolStripMenuItem menuItem_feature_newWord;
        private ToolStripMenuItem menuItem_feature_searchWord;
        private ToolStripMenuItem menu_view;
        private ToolStripMenuItem menuItem_view_font;
        private RichTextBox richBoxWords;
        private Panel panelFeature;
        private TextBox tBoxWord;
        private Label lblWord;
        private CheckBox cBoxWord;
        private Button btnFeature;
        private Label lblWordKind;
        private CheckBox cBoxWordKind;
        private TextBox tBoxChinese;
        private Label lblChinese;
        private CheckBox cBoxChinese;
        private ComboBox comboWordKind;
        private ToolStripMenuItem menuItem_view_showMarkedOnly;
        private ToolStripMenuItem menuItem_view_clearMark;
        private ToolStripMenuItem menuItem_feature_test;
    }
}