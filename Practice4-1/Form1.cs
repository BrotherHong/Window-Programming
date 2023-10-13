namespace Practice4_1
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private int answer = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateAnswer();
            SetButtonImage(btn1, 0);
            SetButtonImage(btn2, 0);
            SetButtonImage(btn3, 0);
            SetButtonImage(btn4, 0);
        }

        private void GenerateAnswer()
        {
            answer = random.Next(10000);
        }

        private void SetButtonImage(Button btn, int index)
        {
            btn.ImageIndex = index;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int number = btn1.ImageIndex;
            number = (number + 1) % 10;
            SetButtonImage(btn1, number);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int number = btn2.ImageIndex;
            number = (number + 1) % 10;
            SetButtonImage(btn2, number);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int number = btn3.ImageIndex;
            number = (number + 1) % 10;
            SetButtonImage(btn3, number);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int number = btn4.ImageIndex;
            number = (number + 1) % 10;
            SetButtonImage(btn4, number);
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            int correctCount = CheckPassword();
            if (correctCount == 4)
            {
                ShowAccepted();
            }
            else
            {
                DialogResult option;
                option = AskRetryOrCancel(correctCount);
                switch (option)
                {
                    case DialogResult.Retry: break;
                    case DialogResult.Cancel: ShowAnswer(); break;
                }
            }
        }

        private int CheckPassword()
        {
            int correct = 0;
            correct += (btn1.ImageIndex == (answer / 1000 % 10) ? 1 : 0);
            correct += (btn2.ImageIndex == (answer / 100 % 10) ? 1 : 0);
            correct += (btn3.ImageIndex == (answer / 10 % 10) ? 1 : 0);
            correct += (btn4.ImageIndex == (answer / 1 % 10) ? 1 : 0);
            return correct;
        }

        private void ShowAccepted()
        {
            MessageBox.Show("解鎖成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private DialogResult AskRetryOrCancel(int correctCount)
        {
            return MessageBox.Show($"猜對{correctCount}個位置", "失敗", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }

        private void ShowAnswer()
        {
            string title = "解答";
            string content = string.Format("答案是{0:0000}", answer);
            MessageBox.Show(content, title, MessageBoxButtons.OK);
        }
    }
}