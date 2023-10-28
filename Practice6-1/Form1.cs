namespace Practice6_1
{
    public partial class Form1 : Form
    {
        private static readonly int PIC_SIZE = 270;
        private static readonly int CUT_SIZE = 90;
        private Button[] buttons;

        private Image targetImg;
        private Image[] buttonImg;
        private int[] imgIndex;

        int seconds = 0;
        int moves = 0;

        bool beginning = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButtons();
            Reset();
        }

        private void GenerateButtons()
        {
            imgIndex = new int[9];
            buttonImg = new Image[9];
            buttons = new Button[9];
            for (int i = 0; i < 9; i++)
            {
                buttons[i] = new Button();
                buttons[i].Name = $"btn{i}";
                buttons[i].Text = "";
                buttons[i].Size = new Size(CUT_SIZE, CUT_SIZE);
                buttons[i].Location = new Point((i % 3) * CUT_SIZE, (i / 3) * CUT_SIZE);
                buttons[i].UseVisualStyleBackColor = true;
                buttons[i].TabIndex = i;
                buttons[i].Click += btnX_Click;
                panelButtons.Controls.Add(buttons[i]);

                imgIndex[i] = i;
            }
        }

        private void Reset()
        {
            timer1.Stop();
            beginning = false;
            seconds = 0;
            moves = 0;
            lblTime.Text = "Time: 00:00";
            lblMoves.Text = "移動步數: 0";
            pboxTarget.Image = null;
            targetImg = null;
            trackBarDisplay.Value = 1;
            for (int i = 0; i < 9; i++)
            {
                buttons[i].BackgroundImage = null;
                buttons[i].Enabled = false;

                buttonImg[i] = null;

                imgIndex[i] = i;
            }
        }

        private void Restart()
        {
            timer1.Stop();
            beginning = false;
            seconds = 0;
            moves = 0;
            lblTime.Text = "Time: 00:00";
            lblMoves.Text = "移動步數: 0";
        }

        private void btnX_Click(object sender, EventArgs args)
        {
            Button btn = (Button)sender;
            int id = btn.TabIndex;
            int r = id / 3, c = id % 3;

            int targetId = -1;

            if (r - 1 >= 0 && imgIndex[(r - 1) * 3 + c] == 8)
            {
                targetId = (r - 1) * 3 + c;
            }
            else if (r + 1 < 3 && imgIndex[(r + 1) * 3 + c] == 8)
            {
                targetId = (r + 1) * 3 + c;
            }
            else if (c - 1 >= 0 && imgIndex[r * 3 + (c - 1)] == 8)
            {
                targetId = r * 3 + (c - 1);
            }
            else if (c + 1 < 3 && imgIndex[r * 3 + (c + 1)] == 8)
            {
                targetId = r * 3 + (c + 1);
            }

            if (targetId != -1)
            {
                int temp = imgIndex[id];
                imgIndex[id] = imgIndex[targetId];
                imgIndex[targetId] = temp;

                // update moves
                moves++;
                lblMoves.Text = $"移動步數: {moves}";

                UpdateButtonImg();
                CheckComplete();
            }
        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            if (targetImg == null)
            {
                MessageBox.Show("請先選擇圖片", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (beginning)
            {
                Restart();
            }
            PaintButtons(targetImg);
            timer1.Start();
            beginning = true;
        }

        private void btnSelectImg_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                DialogResult result = ofd.ShowDialog();

                string path = ofd.FileName;
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(path))
                {
                    targetImg = ResizeImage(new Bitmap(path), new Size(PIC_SIZE, PIC_SIZE));
                    pboxTarget.Image = targetImg;
                }
            }
        }

        private void trackBarDisplay_ValueChanged(object sender, EventArgs e)
        {
            int newVal = trackBarDisplay.Value;
            if (newVal == 0)
            {
                pboxTarget.Hide();
            }
            else if (newVal == 1)
            {
                pboxTarget.Show();
            }
        }

        private void PaintButtons(Image img)
        {
            // Assert img size is (270,270)
            // init buttonImg
            Graphics g = null;
            for (int i = 0; i < 9; i++)
            {
                int r = i / 3, c = i % 3;
                Rectangle section = new Rectangle(new Point(c * CUT_SIZE, r * CUT_SIZE), new Size(CUT_SIZE, CUT_SIZE));
                buttonImg[i] = new Bitmap(section.Width, section.Height);
                g = Graphics.FromImage(buttonImg[i]);
                g.DrawImage(img, 0, 0, section, GraphicsUnit.Pixel);
            }
            g!.Dispose();

            // set background image
            for (int i = 0; i < 9; i++)
            {
                buttons[i].Enabled = true;
            }
            ShuffleArray(ref imgIndex);
            UpdateButtonImg();
        }

        private void UpdateButtonImg()
        {
            for (int i = 0; i < 9; i++)
            {
                int index = imgIndex[i];
                buttons[i].BackgroundImage = buttonImg[index];
                if (index == 8)
                {
                    buttons[i].Visible = false;
                } else
                {
                    buttons[i].Visible = true;
                }
            }
        }

        private void CheckComplete()
        {
            for (int i = 0; i < 9; i++)
            {
                if (imgIndex[i] != i) return;
            }

            timer1.Stop();
            beginning = false;

            string msg = "";
            msg += "你獲勝了!\n";
            msg += $"完成時間: {GetTimeString(seconds)}\n";
            msg += $"{lblMoves.Text}\n";

            MessageBox.Show(msg, "Win!", MessageBoxButtons.OK);

            Restart();
            for (int i = 0; i < 9; i++)
            {
                buttons[i].Enabled = false;
            }
        }

        private static void ShuffleArray(ref int[] arr)
        {
            Random random = new Random();
            arr = arr.OrderBy(n => random.Next()).ToArray();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            string time = GetTimeString(seconds);
            lblTime.Text = $"Time: {time}";
        }

        private static Image ResizeImage(Image img, Size size)
        {
            Bitmap ret = new Bitmap(size.Width, size.Height);
            Graphics g = Graphics.FromImage(ret);
            g.DrawImage(img, 0, 0, size.Width, size.Height);
            g.Dispose();
            return ret;
        }

        private static string GetTimeString(int sec)
        {
            TimeSpan t = TimeSpan.FromSeconds(sec);
            return string.Format("{0:00}:{1:00}", t.Minutes, t.Seconds);
        }

        
    }
}