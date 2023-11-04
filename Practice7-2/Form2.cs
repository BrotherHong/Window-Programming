

namespace Practice7_2
{
    public partial class Form2 : Form
    {
        private List<Vocabulary> vocabularies;
        private Font fontStyle;

        private int currentIndex;

        public Form2(List<Vocabulary> vocabularies, Font fontStyle)
        {
            InitializeComponent();
            this.vocabularies = vocabularies;
            this.fontStyle = fontStyle;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblWord.Font = fontStyle;
            lblChinese.Font = fontStyle;
            lblWordKind.Font = fontStyle;

            GoNext();
        }

        private void GoNext()
        {
            // randomly choose an index of vocabularies
            currentIndex = new Random().Next(vocabularies.Count);

            // set vocabulary display
            lblWord.Text = $"單字: {vocabularies[currentIndex].Word}";

            // set mark
            cBoxMark.Checked = vocabularies[currentIndex].Marked;

            // hide the answer
            HideChineseAndKind();
        }

        private void HideChineseAndKind()
        {
            lblChinese.Text = "中文: ";
            lblWordKind.Text = "詞性: ";
        }

        private void ShowChineseAndKind()
        {
            lblChinese.Text = $"中文: {vocabularies[currentIndex].Chinese}";
            lblWordKind.Text = $"詞性: {vocabularies[currentIndex].WordKind}";
        }

        private void cBoxMark_CheckedChanged(object sender, EventArgs e)
        {
            vocabularies[currentIndex].Marked = cBoxMark.Checked;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            ShowChineseAndKind();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            GoNext();
        }
    }
}
