namespace Practice5_1
{
    public enum GamePhase
    {
        NONE,
        PREPARE,
        PLAYER,
    }

    public partial class Form1 : Form
    {
        private static readonly int ANS_COUNT = 3;

        private Button[] wordButtons;
        private GamePhase gamePhase;

        private int remainTime = 0;
        private int[] answer;
        private List<int> inputs;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            Controls.Remove(labelPhase);
            Controls.Remove(labelTime);
            InitializeWordButtons();

            gamePhase = GamePhase.NONE;
            answer = new int[36];
            inputs = new List<int>();
        }

        private void InitializeWordButtons()
        {
            wordButtons = new Button[36];

            int startX = 67;
            int startY = 150;
            int sizeX = 50;
            int sizeY = 50;
            int padding = 6;

            for (char c = '0'; c <= '9'; c++)
            {
                int idx = CharToIndex(c);
                wordButtons[idx] = new Button();
                wordButtons[idx].Name = $"btn{c.ToString()}";
                wordButtons[idx].Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
                wordButtons[idx].Text = c.ToString();
                wordButtons[idx].Size = new Size(sizeX, sizeY);
                wordButtons[idx].Location = new Point(startX + (idx % 12) * (sizeX + padding), startY + (idx / 12) * (sizeY + padding));
                wordButtons[idx].UseVisualStyleBackColor = true;
                wordButtons[idx].TabIndex = idx;
                wordButtons[idx].Click += btnWord_Click;
            }
            for (char c = 'A'; c <= 'Z'; c++)
            {
                int idx = CharToIndex(c);
                wordButtons[idx] = new Button();
                wordButtons[idx].Name = $"btn{c.ToString()}";
                wordButtons[idx].Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
                wordButtons[idx].Text = c.ToString();
                wordButtons[idx].Size = new Size(sizeX, sizeY);
                wordButtons[idx].Location = new Point(startX + (idx % 12) * (sizeX + padding), startY + (idx / 12) * (sizeY + padding));
                wordButtons[idx].UseVisualStyleBackColor = true;
                wordButtons[idx].TabIndex = idx;
                wordButtons[idx].Click += btnWord_Click;
            }
        }

        private void Reset()
        {
            gamePhase = GamePhase.NONE;
            foreach (Button btn in wordButtons)
            {
                btn.BackColor = Color.Transparent;
                Controls.Remove(btn);
            }
            Controls.Remove(labelPhase);
            Controls.Remove(labelTime);
            Controls.Add(btnStart);
        }

        private int CharToIndex(char c)
        {
            if ('0' <= c && c <= '9')
            {
                return c - '0';
            }
            else if ('A' <= c && c <= 'Z')
            {
                return c - 'A' + 10;
            }
            return -1;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Controls.Remove(btnStart);
            Controls.Add(labelPhase);
            Controls.Add(labelTime);
            for (int i = 0; i < wordButtons.Length; i++)
            {
                Controls.Add(wordButtons[i]);
            }

            StartPreparePhase();
            StartTimer(5);
        }

        private void StartPreparePhase()
        {
            gamePhase = GamePhase.PREPARE;
            labelPhase.Text = "準備階段";

            Random rand = new Random();
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = i;
            }
            answer = answer.OrderBy(n => rand.Next()).ToArray();

            for (int i = 0; i < ANS_COUNT; i++)
            {
                int idx = answer[i];
                wordButtons[idx].BackColor = Color.LightGreen;
            }
        }

        private void StartPlayerPhase()
        {
            gamePhase = GamePhase.PLAYER;
            labelPhase.Text = "玩家階段";
            inputs.Clear();
            for (int i = 0; i < answer.Length; i++)
            {
                int idx = answer[i];
                wordButtons[idx].BackColor = Color.Transparent;
            }
        }

        private void StartTimer(int seconds)
        {
            remainTime = seconds;
            tmrGame.Enabled = true;
        }

        private void StopTimer()
        {
            remainTime = 0;
            tmrGame.Enabled = false;
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            if (gamePhase == GamePhase.PREPARE) return;
            if (gamePhase == GamePhase.PLAYER)
            {
                Button btn = (Button)sender;
                if (btn.BackColor == Color.Transparent)
                {
                    btn.BackColor = Color.LightBlue;
                    inputs.Add(btn.TabIndex);
                }
                else
                {
                    btn.BackColor = Color.Transparent;
                    inputs.Remove(btn.TabIndex);
                }
            }
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            labelTime.Text = remainTime.ToString();
            if (gamePhase == GamePhase.PREPARE)
            {
                if (remainTime == 0)
                {
                    StopTimer();
                    StartPlayerPhase();
                    StartTimer(5);
                }
                else
                {
                    remainTime--;
                }
            }
            else if (gamePhase == GamePhase.PLAYER)
            {
                if (remainTime == 0)
                {
                    StopTimer();
                    ProcessResult();
                }
                else
                {
                    remainTime--;
                }
            }
        }

        private void ProcessResult()
        {
            bool pass = true;
            for (int i = 0; i < inputs.Count; i++)
            {
                int idx = inputs[i];
                if (IsAnswer(idx))
                {
                    wordButtons[idx].BackColor = Color.LightGreen;
                }
                else
                {
                    wordButtons[idx].BackColor = Color.Red;
                    pass = false;
                }
            }

            for (int i = 0; i < ANS_COUNT; i++)
            {
                int idx = answer[i];
                if (!inputs.Contains(idx))
                {
                    wordButtons[idx].BackColor = Color.Red;
                    pass = false;
                }
            }

            string msg = pass ? "You Win!" : "You Lose!\nTry Again!";
            MessageBox.Show(msg, "GameOver", MessageBoxButtons.OK);
            Reset();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = char.ToUpper(e.KeyChar);
            int idx = CharToIndex(ch);
            if (idx == -1) return;
            wordButtons[idx].PerformClick();
        }

        private bool IsAnswer(int index)
        {
            for (int i = 0; i < ANS_COUNT; i++)
            {
                if (answer[i] == index) return true;
            }
            return false;
        }
    }
}