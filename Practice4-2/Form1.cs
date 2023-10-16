using System.Drawing;

namespace Practice4_2
{
    internal enum LandDetail : uint
    {
        NONE = 0b00,
        WATER = 0b01,
        FERTILIZED = 0b10,
        GROWTH = WATER | FERTILIZED,
    }

    internal enum LandState : int
    {
        DIRT = 0,
        SEED = 1,
        CROP = 2,
        FRUIT = 3,
    }

    public partial class Form1 : Form
    {
        private static readonly string IMG_DIR = @"..\..\..\img4_2";
        private Image imgDirt;
        private Image imgSeed;
        private Image imgCrop;
        private Image imgMelon;
        private Image[] imgStates;
        private Button[] buttons;

        private int money = 100;
        private int amtSeed = 5;
        private int amtFert = 5;
        private int amtFruit = 0;

        private LandState[] landStates;
        private LandDetail[] landDetails;

        public Form1()
        {
            buttons = new Button[12];
            imgDirt = new Bitmap(IMG_DIR + @"\dirt.jpeg");
            imgSeed = new Bitmap(IMG_DIR + @"\seed.jpg");
            imgCrop = new Bitmap(IMG_DIR + @"\crop.jpg");
            imgMelon = new Bitmap(IMG_DIR + @"\watermelon.jpg");
            imgStates = new Image[4] { imgDirt, imgSeed, imgCrop, imgMelon };

            landStates = new LandState[12];
            landDetails = new LandDetail[12];

            InitializeComponent();
            InitializeButtonsFarm();

            rbtnSeed.Select();
        }

        private void InitializeButtonsFarm()
        {
            int padding = 6;
            int sizeX = 100, sizeY = 100;


            for (int r = 0; r < 4; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    int idx = r * 3 + c;
                    buttons[idx] = new Button();
                    buttons[idx].Name = $"btn{idx}";
                    buttons[idx].Text = "";
                    buttons[idx].Size = new Size(sizeX, sizeY);
                    buttons[idx].UseVisualStyleBackColor = true;
                    buttons[idx].TabIndex = idx + 1;
                    buttons[idx].Location = new Point(padding * (c + 1) + sizeX * c, padding * (r + 1) + sizeY * r);
                    buttons[idx].Click += farmButton_Click!;
                    buttons[idx].BackgroundImageLayout = ImageLayout.Stretch;
                    buttons[idx].BackgroundImage = imgDirt;

                    landStates[idx] = LandState.DIRT;
                    landDetails[idx] = LandDetail.NONE;

                    tabFarm.Controls.Add(buttons[idx]);
                }
            }

        }

        private void farmButton_Click(object sender, EventArgs e)
        {
            if (sender is not Button) return;
            Button btn = (Button)sender;
            int index = btn.TabIndex - 1;

            if (rbtnWater.Checked)
            {
                if (landStates[index] == LandState.DIRT) return;
                if (landStates[index] == LandState.FRUIT) return;

                landDetails[index] |= LandDetail.WATER;

            } else if (rbtnSeed.Checked)
            {
                if (landStates[index] != LandState.DIRT) return;

                if (amtSeed > 0)
                {
                    amtSeed--;
                    UpgradeLand(index);
                } else
                {
                    MessageBox.Show("種子用完了", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            } else if (rbtnFert.Checked)
            {
                if (landStates[index] == LandState.DIRT) return;
                if (landStates[index] == LandState.FRUIT) return;
                if ((landDetails[index] & LandDetail.FERTILIZED) != 0) return;

                if (amtFert > 0)
                {
                    amtFert--;
                    landDetails[index] |= LandDetail.FERTILIZED;
                }
                else
                {
                    MessageBox.Show("肥料用完了", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            } else if (rbtnCut.Checked)
            {
                if (landStates[index] != LandState.FRUIT) return;
                amtFruit++;
                UpgradeLand(index);
            }

            // Check if land can go to next stage
            if (landDetails[index] == LandDetail.GROWTH)
            {
                UpgradeLand(index);
            }
        }

        private void UpgradeLand(int index)
        {
            Button btn = buttons[index];
            landStates[index] = (LandState) (((int)landStates[index] + 1) % 4);
            landDetails[index] = LandDetail.NONE;
            btn.BackgroundImage = imgStates[(int)landStates[index]];
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            cboxSeed.Checked = false;
            cboxFert.Checked = false;
            cboxFruit.Checked = false;
            UpdateStore();
        }

        private void UpdateStore()
        {
            labelMoney.Text = $"金錢:{money}";
            labelSeed.Text = $"擁有:{amtSeed}";
            labelFert.Text = $"擁有:{amtFert}";
            labelFruit.Text = $"擁有:{amtFruit}";
        }

        private void btnBuySell_Click(object sender, EventArgs e)
        {
            // sell fruit
            if (cboxFruit.Checked == true && amtFruit > 0)
            {
                money += 40;
                amtFruit--;
            }

            // buy seed
            if (cboxSeed.Checked == true && money >= 10)
            {
                money -= 10;
                amtSeed++;
            }

            // buy fert
            if (cboxFert.Checked == true && money >= 10)
            {
                money -= 10;
                amtFert++;
            }

            UpdateStore();
        }
    }
}