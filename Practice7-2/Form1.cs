

namespace Practice7_2
{
    public enum Feature
    {
        NONE, NEW_WORD, SEARCH_WORD,
    }

    public partial class Form1 : Form
    {
        private Feature currentFeature;
        private List<Vocabulary> vocabularies;
        private string savePath;
        private bool showMarkedOnly;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HideFeaturePanel();

            currentFeature = Feature.NONE;
            vocabularies = new List<Vocabulary>();
            savePath = null;
            showMarkedOnly = false;

            comboWordKind.Items.AddRange(new string[] { "n", "v", "adj", "adv", "prep", "conj", "phr", "abbr", "pron", "other" });
        }

        private void ResetAll()
        {
            vocabularies.Clear();
            UpdateWordsRichText();
            ResetAndCloseFeaturePanel();
            savePath = null;
        }

        private void ResetAndCloseFeaturePanel()
        {
            HideFeaturePanel();
            currentFeature = Feature.NONE;
            menuItem_feature_newWord.Text = "新增單字";
            menuItem_feature_searchWord.Text = "搜尋單字";
            UpdateWordsRichText();
        }

        private void menuItem_feature_newWord_Click(object sender, EventArgs e)
        {
            if (currentFeature != Feature.NEW_WORD)
            {
                currentFeature = Feature.NEW_WORD;
                menuItem_feature_newWord.Text = "新增單字(v)";
                menuItem_feature_searchWord.Text = "搜尋單字";
                SetupNewWordPanel();
                ShowFeaturePanel();
            }
            else
            {
                // hide feature
                ResetAndCloseFeaturePanel();
            }
            UpdateWordsRichText();
        }

        private void menuItem_feature_searchWord_Click(object sender, EventArgs e)
        {
            if (currentFeature != Feature.SEARCH_WORD)
            {
                currentFeature = Feature.SEARCH_WORD;
                menuItem_feature_newWord.Text = "新增單字";
                menuItem_feature_searchWord.Text = "搜尋單字(v)";
                SetupSearchWordPanel();
                ShowFeaturePanel();
            }
            else
            {
                // hide feature
                ResetAndCloseFeaturePanel();
            }
            UpdateWordsRichText();
        }

        private void ShowFeaturePanel()
        {
            Controls.Add(panelFeature);
            int width = (panelFeature.Left - 6) - richBoxWords.Left;
            int height = richBoxWords.Size.Height;
            richBoxWords.Size = new Size(width, height);
        }

        private void HideFeaturePanel()
        {
            Controls.Remove(panelFeature);
            int width = panelFeature.Right - richBoxWords.Left;
            int height = richBoxWords.Size.Height;
            richBoxWords.Size = new Size(width, height);
        }

        private void SetupNewWordPanel()
        {
            // Disable check box
            panelFeature.Controls.Remove(cBoxWord);
            panelFeature.Controls.Remove(cBoxChinese);
            panelFeature.Controls.Remove(cBoxWordKind);

            // Reset
            tBoxWord.Text = "";
            tBoxChinese.Text = "";
            comboWordKind.Text = "";

            btnFeature.Text = "新增";
        }

        private void SetupSearchWordPanel()
        {
            // enable check box
            panelFeature.Controls.Add(cBoxWord);
            panelFeature.Controls.Add(cBoxChinese);
            panelFeature.Controls.Add(cBoxWordKind);

            // Reset

            cBoxWord.Checked = false;
            cBoxChinese.Checked = false;
            cBoxWordKind.Checked = false;

            tBoxWord.Text = "";
            tBoxChinese.Text = "";
            comboWordKind.Text = "";

            btnFeature.Text = "搜尋";
        }

        private void btnFeature_Click(object sender, EventArgs e)
        {
            if (currentFeature == Feature.NEW_WORD)
            {
                // New Word
                string word = tBoxWord.Text;
                string chinese = tBoxChinese.Text;
                string wordKind = comboWordKind.Text;

                if (string.IsNullOrWhiteSpace(word)
                    || string.IsNullOrWhiteSpace(chinese)
                    || string.IsNullOrWhiteSpace(wordKind))
                {
                    MessageBox.Show("輸入資料不得為空或空白", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Vocabulary vocab = new Vocabulary(word, chinese, wordKind);
                vocabularies.Add(vocab);

                // Update Rich Box
                UpdateWordsRichText();

                // Reset
                SetupNewWordPanel();

            }
            else if (currentFeature == Feature.SEARCH_WORD)
            {
                // Search Word
                string word = tBoxWord.Text;
                string chinese = tBoxChinese.Text;
                string wordKind = comboWordKind.Text;

                bool wordCheck = cBoxWord.Checked;
                bool chineseCheck = cBoxChinese.Checked;
                bool kindCheck = cBoxWordKind.Checked;

                if ((wordCheck && string.IsNullOrWhiteSpace(word))
                    || (chineseCheck && string.IsNullOrWhiteSpace(chinese))
                    || (kindCheck && string.IsNullOrWhiteSpace(wordKind)))
                {
                    MessageBox.Show("搜尋資料不得為空或空白", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update Rich Box
                UpdateWordsRichText();
            }
        }

        private void UpdateWordsRichText()
        {
            if (currentFeature != Feature.SEARCH_WORD)
            {
                richBoxWords.Lines = vocabularies
                                .Where(v => showMarkedOnly ? v.Marked : true)
                                .Select(v => v.ToString())
                                .ToArray();
            }
            else
            {
                string word = tBoxWord.Text;
                string chinese = tBoxChinese.Text;
                string wordKind = comboWordKind.Text;

                bool wordCheck = cBoxWord.Checked;
                bool chineseCheck = cBoxChinese.Checked;
                bool kindCheck = cBoxWordKind.Checked;

                // Assert they are all valid

                var result = vocabularies.AsEnumerable();

                if (wordCheck) result = result.Where(v => v.Word == word);
                if (chineseCheck) result = result.Where(v => v.Chinese == chinese);
                if (kindCheck) result = result.Where(v => v.WordKind == wordKind);

                if (showMarkedOnly) result = result.Where(v => v.Marked);

                richBoxWords.Lines = result.Select(v => v.ToString()).ToArray();
            }
        }

        private void menuItem_view_font_Click(object sender, EventArgs e)
        {
            using (var fd = new FontDialog())
            {
                fd.Font = richBoxWords.Font;
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    richBoxWords.Font = fd.Font;
                }
            }
        }

        private void menuItem_view_showMarkedOnly_Click(object sender, EventArgs e)
        {
            if (!showMarkedOnly)
            {
                menuItem_view_showMarkedOnly.Text = "只顯示標記單字(v)";
                showMarkedOnly = true;
            }
            else
            {
                menuItem_view_showMarkedOnly.Text = "只顯示標記單字";
                showMarkedOnly = false;
            }
            UpdateWordsRichText();
        }

        private void menuItem_view_clearMark_Click(object sender, EventArgs e)
        {
            vocabularies.ForEach(v => v.Marked = false);
            UpdateWordsRichText();
        }

        private void menuItem_feature_test_Click(object sender, EventArgs e)
        {
            if (vocabularies.Count == 0)
            {
                MessageBox.Show("請先新增單字! 以開始進行測驗!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Form2 wordTestingForm = new Form2(vocabularies, richBoxWords.Font);
            this.Hide();
            wordTestingForm.ShowDialog();
            this.Show();
            UpdateWordsRichText();
        }
    }
}