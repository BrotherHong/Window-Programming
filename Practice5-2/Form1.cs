using Practice5_2.Servants;
using System.Text;

namespace Practice5_2
{
    public enum MovesType
    {
        UNCHOOSE,
        NORMAL_ATTACK,
        SKILL,
        ULTIMATE,
    }

    public partial class Form1 : Form
    {
        private MyTimer gameTimer;
        private Beast beast;
        private List<Servant> hero;

        // 0b100 -> Berserker ; 0b010 -> Saber ; 0b001 -> Caster
        private int choose;

        private bool waitForClick;
        private MovesType moveType;
        private int round;
        private List<Servant> battleOrder;
        private int orderIndex;

        public Form1()
        {
            InitializeComponent();
            hero = new List<Servant>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            Controls.Add(panelStart);
            Controls.Remove(panelPrepare);
            Controls.Remove(panelBattle);

            hero.Clear();
            beast = new Beast();
            choose = 0b000;
            waitForClick = false;
        }


        /**
         * Start Page Panel
         */
        private void btnStart_Click(object sender, EventArgs e)
        {
            StartPreparePhase();
        }

        /**
        * Prepare Phase Panel
        */

        private void StartPreparePhase()
        {
            Controls.Add(panelPrepare);
            Controls.Remove(panelStart);
            Controls.Remove(panelBattle);

            lblPrepareRemain.Text = "10";
            gameTimer = new MyTimer(timer, prepare_Tick_Action);
            gameTimer.StartCountDown(10);
        }

        private void prepare_Tick_Action(int remain, int elapsed)
        {
            lblPrepareRemain.Text = remain.ToString();
            if (remain == 0)
            {
                gameTimer.Stop();
                if (choose == 0b000) choose = 0b110;
                else if (choose == 0b100) choose = 0b110;
                else if (choose == 0b010) choose = 0b110;
                else if (choose == 0b001) choose = 0b101;

                if ((choose & 0b100) > 0)
                {
                    hero.Add(new Berserker());
                }
                if ((choose & 0b010) > 0)
                {
                    hero.Add(new Saber());
                }
                if ((choose & 0b001) > 0)
                {
                    hero.Add(new Caster());
                }
                btnBerserker.BackColor = Color.Transparent;
                btnCaster.BackColor = Color.Transparent;
                btnSaber.BackColor = Color.Transparent;
                StartBattlePhase();
            }
        }

        private void btnBerserker_Click(object sender, EventArgs e)
        {
            if ((choose ^ 0b100) == 0b111)
            {
                MyHelper.ShowInfo("只能選兩個Servant!");
                return;
            }
            choose ^= 0b100;
            btnBerserker.BackColor = ((choose & 0b100) > 0 ? Color.LightGreen : Color.Transparent);
        }

        private void btnSaber_Click(object sender, EventArgs e)
        {
            if ((choose ^ 0b010) == 0b111)
            {
                MyHelper.ShowInfo("只能選兩個Servant!");
                return;
            }
            choose ^= 0b010;
            btnSaber.BackColor = ((choose & 0b010) > 0 ? Color.LightGreen : Color.Transparent);
        }

        private void btnCaster_Click(object sender, EventArgs e)
        {
            if ((choose ^ 0b001) == 0b111)
            {
                MyHelper.ShowInfo("只能選兩個Servant!");
                return;
            }
            choose ^= 0b001;
            btnCaster.BackColor = ((choose & 0b001) > 0 ? Color.LightGreen : Color.Transparent);
        }

        /**
        * Battle Phase Panel
        */

        private void StartBattlePhase()
        {
            Controls.Remove(panelPrepare);
            Controls.Add(panelBattle);

            lblBattleTime.Text = 0.ToString("00#");
            gameTimer = new MyTimer(timer, battle_Tick_Action);
            gameTimer.StartCounting();

            RunBattle();
        }

        private void battle_Tick_Action(int remain, int elapsed)
        {
            lblBattleTime.Text = elapsed.ToString("00#");
        }

        private void RunBattle()
        {
            // For each round
            // Determine the order of attacker
            // If Hero
            //      Wait for button click
            //      Check Beast is dead or not
            // else if Beast
            //      Beast attack
            //      Check if any hero dead
            // Next round

            battleOrder = GetOrderOfAttacker();
            orderIndex = 0;
            round = 1;
            waitForClick = false;
            moveType = MovesType.UNCHOOSE;

            battleTick.Enabled = true;
        }

        private void battleTick_Tick(object sender, EventArgs e)
        {
            battleTick.Enabled = false;
            if (waitForClick)
            {
                battleTick.Enabled = true;
                return;
            }
            

            Servant servant = battleOrder[orderIndex];

            UpdateBoard(servant);
            if (servant is Beast)
            {
                if (round % 4 == 0)
                {
                    beast.UseSkill();
                    UpdateBoard(servant);
                    ShowBattleInfo($"{beast.Character}使用了技能\n當前Atk：{beast.Atk}");
                }
                if (beast.Charge == 100)
                {
                    beast.UseUltimate(hero.ToArray());
                    UpdateBoard(servant);
                    ShowBattleInfo($"{beast.Character}使用了寶具\n對全體隊友造成了{beast.Atk * 2}點傷害!");
                }
                else // Normal attack
                {
                    foreach (Servant s in hero) beast.NormalAttack(s);
                    beast.Charge += 20;
                    UpdateBoard(servant);
                    ShowBattleInfo($"{beast.Character}對全體隊友造成{beast.Atk}點傷害");
                }
                CheckHero();
            }
            else
            {
                if (moveType == MovesType.UNCHOOSE)
                {
                    waitForClick = true;
                    battleTick.Enabled = true;
                    return;
                }
                try
                {
                    switch (moveType)
                    {
                        case MovesType.NORMAL_ATTACK:
                            bool critical = servant.NormalAttack(beast);
                            UpdateBoard(servant);
                            if (critical) ShowBattleInfo($"對{beast.Character}造成了{servant.Atk * 2}點爆擊傷害");
                            break;
                        case MovesType.SKILL:
                            servant.UseSkill();
                            UpdateBoard(servant);
                            ShowBattleInfo($"{servant.Character}使用了技能");
                            waitForClick = true;
                            battleTick.Enabled = true;
                            return;
                        case MovesType.ULTIMATE:
                            switch (servant)
                            {
                                case Berserker:
                                    servant.UseUltimate(beast);
                                    break;
                                case Caster:
                                    servant.UseUltimate(hero.ToArray());
                                    break;
                                case Saber:
                                    servant.UseUltimate(beast);
                                    break;
                            }
                            UpdateBoard(servant);
                            InfoUltimate(servant);
                            break;
                    }
                    moveType = MovesType.UNCHOOSE;
                }
                catch (Exception ex)
                {
                    ShowBattleInfo(ex.Message);
                    moveType = MovesType.UNCHOOSE;
                    battleTick.Enabled = true;
                    return;
                }
            }

            if (beast.Hp <= 0)
            {
                battleTick.Enabled = false;
                gameTimer.Stop();
                ShowBattleInfo($"You Win!\n通關時間：{gameTimer.ElapsedSeconds()}");
                Reset();
                return;
            }
            else if (hero.Count == 0)
            {
                battleTick.Enabled = false;
                gameTimer.Stop();
                ShowBattleInfo($"You Lose\n戰鬥時間：{gameTimer.ElapsedSeconds()}");
                Reset();
                return;
            }
            else
            {
                // Go Next Servant
                do
                {
                    orderIndex++;
                    if (orderIndex == battleOrder.Count)
                    {
                        orderIndex = 0;
                        GoNextRound();
                    }
                } while (battleOrder[orderIndex].Hp <= 0);
                battleTick.Enabled = true;
            }
        }

        private void btnNormalAttack_Click(object sender, EventArgs e)
        {
            if (!waitForClick) return;
            moveType = MovesType.NORMAL_ATTACK;
            waitForClick = false;
        }

        private void btnSkill_Click(object sender, EventArgs e)
        {
            if (!waitForClick) return;
            moveType = MovesType.SKILL;
            waitForClick = false;
        }

        private void btnUltimate_Click(object sender, EventArgs e)
        {
            if (!waitForClick) return;
            moveType = MovesType.ULTIMATE;
            waitForClick = false;
        }

        private List<Servant> GetOrderOfAttacker()
        {
            List<Servant> order = new List<Servant>();
            foreach (Servant s in hero) order.Add(s);
            order.Add(beast);
            order.Sort((s1, s2) => s1.Speed - s2.Speed);
            return order;
        }

        private void GoNextRound()
        {
            foreach (Servant servant in hero)
            {
                servant.Cooling -= 1;
            }
            beast.Cooling -= 1;
            round++;
        }

        private void CheckHero()
        {
            foreach (Servant s in battleOrder)
            {
                if (s is not Beast && hero.Contains(s) && s.Hp <= 0)
                {
                    hero.Remove(s);
                    ShowBattleInfo($"{s.Character}倒下了!");
                }
            }
        }

        private void UpdateBoard(Servant servant)
        {
            lblTurn.Text = $"{servant.Character} Turn";

            Servant h;

            if (servant is Beast)
            {
                h = hero.Find(s => s.Character == lblHero.Text);
                if (h == null) return;
            }
            else
            {
                h = servant;
            }

            lblHero.Text = h.Character;
            lblHeroHp.Text = $"Hp：{h.Hp}";
            lblHeroCharge.Text = $"Charge：{h.Charge}%";
            lblHeroAtk.Text = $"Atk：{h.Atk}";

            lblBeastHp.Text = $"Hp：{beast.Hp}";
            lblBeastCharge.Text = $"Charge：{beast.Charge}%";
            lblBeastAtk.Text = $"Atk：{beast.Atk}";
        }

        private void ShowBattleInfo(string msg)
        {
            // battleTick.Enabled = false;
            MyHelper.ShowInfo(msg);
            // battleTick.Enabled = true;
        }

        private void InfoUltimate(Servant s)
        {
            if (s is Berserker)
            {
                ShowBattleInfo($"{s.Character}使用了寶具:\n對{beast.Character}造成{s.Atk + 50}點傷害");
            }
            else if (s is Caster)
            {
                ShowBattleInfo($"{s.Character}使用了寶具:\n全體隊友加1點攻擊，回復10點血量");
            }
            else if (s is Saber)
            {
                ShowBattleInfo($"{s.Character}使用了寶具:\n對{beast.Character}造成{s.Atk + 25}點傷害並回復5點血量");
            }
        }


    }
}