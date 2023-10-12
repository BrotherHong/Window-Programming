using System.Text;

namespace Practice3_1
{
    public partial class Form1 : Form
    {
        private static string[] analysis = {
            "桃花運大漲",
            "家庭遭逢變故",
            "事業平步青雲，有升官可能",
            "事業起伏大",
            "親人病情好轉",
            "被財神眷顧",
            "近期一帆風順" };

        private static string[] suggest = {
            "少做壞事，夜路走多了總匯三明治",
            "保持謙虛，一山還有一山高，雞蛋還有雞蛋糕",
            "善待他人，不要任意嘲笑別人，除非你忍不住",
            "早點睡覺，不要仗著自己長得醜，就任意熬夜",
            "小心小人，可謂浮雲能蔽日，輕舟已過萬重山",
            "不要偷懶，你在睡覺的時候，美國人還在上班阿",
            "健康第一，定期身體檢查並謹記醫生怎麼說，doctor!",
            "穩定情緒，今天不開心沒關係，反正明天也不會開心",
        };

        private Random random;

        public Form1()
        {
            random = new Random();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowPanelEnter();
        }

        private void ShowPanelEnter()
        {
            InitializePanelEnter();
            panelResult.Visible = false;
            panelEnter.Visible = true;
        }

        private void InitializePanelEnter()
        {
            txtEnterName.Text = "";
            txtEnterGender.Text = "";
            txtEnterBirth.Text = "";
            txtEnterDate.Text = "";
            txtEnterCatDog.Text = "";
            labelHintName.Text = "";
            labelHintGender.Text = "";
            labelHintBirth.Text = "";
            labelHintDate.Text = "";
            labelHintCatDog.Text = "";
        }

        private void ShowPanelResult()
        {
            InitializePanelResult();
            panelEnter.Visible = false;
            panelResult.Visible = true;
        }

        private void InitializePanelResult()
        {
            labelResultName.Text = txtEnterName.Text;
            labelResultGender.Text = txtEnterGender.Text;
            labelResultBirth.Text = txtEnterBirth.Text;
            labelResultDate.Text = txtEnterDate.Text;
            labelResultCatDog.Text = txtEnterCatDog.Text;

            labelResultAnalysis.Text = GenerateAnalysis();
        }

        private string GenerateAnalysis()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("運勢:{0}", analysis[random.Next(analysis.Length)]));
            sb.AppendLine();
            sb.AppendLine(string.Format("建議:{0}", suggest[random.Next(suggest.Length)]));

            return sb.ToString();
        }

        private void btnToResult_Click(object sender, EventArgs e)
        {
            bool pass = true;

            pass = CheckTextBoxNull(txtEnterName, labelHintName) && pass;
            pass = CheckTextBoxNull(txtEnterGender, labelHintGender) && CheckGender(txtEnterGender, labelHintGender) && pass;
            pass = CheckTextBoxNull(txtEnterBirth, labelHintBirth) && pass;
            pass = CheckTextBoxNull(txtEnterDate, labelHintDate) && pass;
            pass = CheckTextBoxNull(txtEnterCatDog, labelHintCatDog) && CheckCatDog(txtEnterCatDog, labelHintCatDog) && pass;

            if (pass)
            {
                ShowPanelResult();
            }
        }

        private bool CheckTextBoxNull(TextBox box, Label hint)
        {
            if (box.Text.Length == 0)
            {
                hint.Text = "此欄未填寫";
                return false;
            }
            hint.Text = "";
            return true;
        }

        private bool CheckGender(TextBox box, Label hint)
        {
            if (box.Text != "男" && box.Text != "女")
            {
                hint.Text = "輸入應為男or女";
                return false;
            }
            hint.Text = "";
            return true;
        }

        private bool CheckCatDog(TextBox box, Label hint)
        {
            if (box.Text != "貓" && box.Text != "狗")
            {
                hint.Text = "輸入應為貓or狗";
                return false;
            }
            hint.Text = "";
            return true;
        }

        private void btnBackEnter_Click(object sender, EventArgs e)
        {
            ShowPanelEnter();
        }
    }
}