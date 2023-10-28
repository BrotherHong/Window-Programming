using System.Media;

namespace Practice6_2
{
    public partial class Form1 : Form
    {
        private PictureBox[,] pbox_h1;
        private PictureBox[,] pbox_h2;
        private PictureBox[,] pbox_m1;
        private PictureBox[,] pbox_m2;
        private PictureBox[,] pbox_s1;
        private PictureBox[,] pbox_s2;

        private SoundPlayer alarmPlayer;
        private string alarmPath;

        private List<string> history;

        private bool alarmStarted;

        public Form1()
        {
            alarmPath = null;
            history = new List<string>();
            alarmStarted = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeTimePanel();
            dateTimePicker1.Value = DateTime.Now;
            UpdateTimeBoard();
            mainTimer.Start();
        }

        private void InitializeTimePanel()
        {
            pbox_h1 = new PictureBox[7, 5];
            pbox_h2 = new PictureBox[7, 5];
            pbox_m1 = new PictureBox[7, 5];
            pbox_m2 = new PictureBox[7, 5];
            pbox_s1 = new PictureBox[7, 5];
            pbox_s2 = new PictureBox[7, 5];
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    pbox_h1[i, j] = NewTimePictureBox(i, j);
                    pbox_h2[i, j] = NewTimePictureBox(i, j);
                    pbox_m1[i, j] = NewTimePictureBox(i, j);
                    pbox_m2[i, j] = NewTimePictureBox(i, j);
                    pbox_s1[i, j] = NewTimePictureBox(i, j);
                    pbox_s2[i, j] = NewTimePictureBox(i, j);

                    panel_h1.Controls.Add(pbox_h1[i, j]);
                    panel_h2.Controls.Add(pbox_h2[i, j]);
                    panel_m1.Controls.Add(pbox_m1[i, j]);
                    panel_m2.Controls.Add(pbox_m2[i, j]);
                    panel_s1.Controls.Add(pbox_s1[i, j]);
                    panel_s2.Controls.Add(pbox_s2[i, j]);
                }
            }
        }

        private PictureBox NewTimePictureBox(int r, int c)
        {
            const int pboxSize = 20;

            PictureBox pb = new PictureBox();
            pb.BackColor = Color.White;
            pb.Size = new Size(pboxSize, pboxSize);
            pb.Location = new Point(c * pboxSize, r * pboxSize);
            pb.BorderStyle = BorderStyle.FixedSingle;

            return pb;
        }

        private void UpdateTimeBoard()
        {
            DateTime now = DateTime.Now;
            string timeStr = now.ToString("hhmmsstt");
            SetDisplayNumber(pbox_h1, timeStr[0] - '0');
            SetDisplayNumber(pbox_h2, timeStr[1] - '0');
            SetDisplayNumber(pbox_m1, timeStr[2] - '0');
            SetDisplayNumber(pbox_m2, timeStr[3] - '0');
            SetDisplayNumber(pbox_s1, timeStr[4] - '0');
            SetDisplayNumber(pbox_s2, timeStr[5] - '0');
            lblAmPm.Text = timeStr.Substring(6, 2);
        }

        private void SetDisplayNumber(PictureBox[,] pb, int number)
        {
            if (number < 0 || number > 9) return;
            // Clear
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    pb[i, j].BackColor = Color.White;
                }
            }
            // Set
            foreach (int[] pair in displayPosition[number])
            {
                int i = pair[0], j = pair[1];
                pb[i, j].BackColor = Color.Blue;
            }
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            UpdateTimeBoard();
            if (alarmStarted)
            {
                DateTime now = DateTime.Now;
                DateTime set = dateTimePicker1.Value;
                if (now.Hour == set.Hour && now.Minute == set.Minute && now.Second == 0)
                {
                    alarmPlayer.Load();
                    alarmPlayer.PlayLooping();
                    RecordHistory("鬧鐘響鈴");
                    MessageBox.Show("時間到! 該起床囉~", "鬧鐘!!!", MessageBoxButtons.OK);
                }
            }
        }

        private void btnSelectAlarm_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Title = "請選擇一個音樂檔案";
                ofd.Filter = "Audio File (*.mp3;*.wav)|*.mp3;*.wav";

                DialogResult result = ofd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    alarmPath = ofd.FileName;
                    lblAlarmPath.Text = alarmPath;
                    alarmPlayer = new SoundPlayer(alarmPath);
                    RecordHistory("已設定鬧鈴");
                }
            }
        }

        private void btnAlarmTrigger_Click(object sender, EventArgs e)
        {
            if (alarmPath == null)
            {
                RecordHistory("錯誤訊息!");
                MessageBox.Show("請先設定鬧鈴!", "錯誤訊息", MessageBoxButtons.OK);
                return;
            }
            if (alarmStarted)
            {
                alarmStarted = false;
                btnAlarmTrigger.Text = "啟動";
                alarmPlayer.Stop();
                RecordHistory("已關閉鬧鐘");
            }
            else
            {
                alarmStarted = true;
                btnAlarmTrigger.Text = "停止";
                RecordHistory("已設定鬧鐘");
            }
        }

        private void RecordHistory(string msg)
        {
            string timestamp = DateTime.Now.ToString("yyyy/MM/dd tt hh:mm:ss");
            history.Add($"{timestamp}: {msg}");
            rtextHist.Lines = history.ToArray();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Title = "匯出記錄檔";
                sfd.Filter = "TXT (*.txt)|*.txt";

                DialogResult result = sfd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string path = sfd.FileName;
                    FileInfo fileInfo = new FileInfo(path);
                    StreamWriter sw = fileInfo.CreateText();
                    foreach (string line in history)
                    {
                        sw.WriteLine(line);
                    }
                    sw.Flush();
                    sw.Close();
                    RecordHistory("已匯出記錄檔");
                }
            }
        }
    }
}