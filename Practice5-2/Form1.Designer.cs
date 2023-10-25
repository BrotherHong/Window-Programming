namespace Practice5_2
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
            components = new System.ComponentModel.Container();
            panelStart = new Panel();
            btnStart = new Button();
            panelPrepare = new Panel();
            btnCaster = new Button();
            btnSaber = new Button();
            btnBerserker = new Button();
            lblPrepareRemain = new Label();
            lblPrepare = new Label();
            panelBattle = new Panel();
            lblTurn = new Label();
            btnUltimate = new Button();
            btnSkill = new Button();
            btnNormalAttack = new Button();
            lblBeastAtk = new Label();
            lblBeastCharge = new Label();
            lblBeastHp = new Label();
            lblBeast = new Label();
            lblHeroAtk = new Label();
            lblHeroCharge = new Label();
            lblHeroHp = new Label();
            lblHero = new Label();
            lblBattleTime = new Label();
            lblTimeTitle = new Label();
            timer = new System.Windows.Forms.Timer(components);
            battleTick = new System.Windows.Forms.Timer(components);
            panelStart.SuspendLayout();
            panelPrepare.SuspendLayout();
            panelBattle.SuspendLayout();
            SuspendLayout();
            // 
            // panelStart
            // 
            panelStart.Controls.Add(btnStart);
            panelStart.Location = new Point(0, 0);
            panelStart.Name = "panelStart";
            panelStart.Size = new Size(800, 500);
            panelStart.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.Location = new Point(293, 211);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(188, 53);
            btnStart.TabIndex = 0;
            btnStart.Text = "開始遊戲";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // panelPrepare
            // 
            panelPrepare.Controls.Add(btnCaster);
            panelPrepare.Controls.Add(btnSaber);
            panelPrepare.Controls.Add(btnBerserker);
            panelPrepare.Controls.Add(lblPrepareRemain);
            panelPrepare.Controls.Add(lblPrepare);
            panelPrepare.Location = new Point(0, 0);
            panelPrepare.Name = "panelPrepare";
            panelPrepare.Size = new Size(800, 500);
            panelPrepare.TabIndex = 0;
            // 
            // btnCaster
            // 
            btnCaster.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCaster.Location = new Point(496, 211);
            btnCaster.Name = "btnCaster";
            btnCaster.Size = new Size(103, 45);
            btnCaster.TabIndex = 4;
            btnCaster.Text = "Caster";
            btnCaster.UseVisualStyleBackColor = true;
            btnCaster.Click += btnCaster_Click;
            // 
            // btnSaber
            // 
            btnSaber.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaber.Location = new Point(333, 211);
            btnSaber.Name = "btnSaber";
            btnSaber.Size = new Size(103, 45);
            btnSaber.TabIndex = 3;
            btnSaber.Text = "Saber";
            btnSaber.UseVisualStyleBackColor = true;
            btnSaber.Click += btnSaber_Click;
            // 
            // btnBerserker
            // 
            btnBerserker.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBerserker.Location = new Point(166, 211);
            btnBerserker.Name = "btnBerserker";
            btnBerserker.Size = new Size(103, 45);
            btnBerserker.TabIndex = 2;
            btnBerserker.Text = "Berserker";
            btnBerserker.UseVisualStyleBackColor = true;
            btnBerserker.Click += btnBerserker_Click;
            // 
            // lblPrepareRemain
            // 
            lblPrepareRemain.AutoSize = true;
            lblPrepareRemain.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrepareRemain.Location = new Point(370, 92);
            lblPrepareRemain.Name = "lblPrepareRemain";
            lblPrepareRemain.Size = new Size(47, 35);
            lblPrepareRemain.TabIndex = 1;
            lblPrepareRemain.Text = "10";
            lblPrepareRemain.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrepare
            // 
            lblPrepare.AutoSize = true;
            lblPrepare.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrepare.Location = new Point(324, 48);
            lblPrepare.Name = "lblPrepare";
            lblPrepare.Size = new Size(123, 35);
            lblPrepare.TabIndex = 0;
            lblPrepare.Text = "準備階段";
            // 
            // panelBattle
            // 
            panelBattle.Controls.Add(lblTurn);
            panelBattle.Controls.Add(btnUltimate);
            panelBattle.Controls.Add(btnSkill);
            panelBattle.Controls.Add(btnNormalAttack);
            panelBattle.Controls.Add(lblBeastAtk);
            panelBattle.Controls.Add(lblBeastCharge);
            panelBattle.Controls.Add(lblBeastHp);
            panelBattle.Controls.Add(lblBeast);
            panelBattle.Controls.Add(lblHeroAtk);
            panelBattle.Controls.Add(lblHeroCharge);
            panelBattle.Controls.Add(lblHeroHp);
            panelBattle.Controls.Add(lblHero);
            panelBattle.Controls.Add(lblBattleTime);
            panelBattle.Controls.Add(lblTimeTitle);
            panelBattle.Location = new Point(0, 0);
            panelBattle.Name = "panelBattle";
            panelBattle.Size = new Size(800, 500);
            panelBattle.TabIndex = 0;
            // 
            // lblTurn
            // 
            lblTurn.AutoSize = true;
            lblTurn.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTurn.Location = new Point(324, 407);
            lblTurn.Name = "lblTurn";
            lblTurn.Size = new Size(154, 35);
            lblTurn.TabIndex = 13;
            lblTurn.Text = "Caster turn";
            // 
            // btnUltimate
            // 
            btnUltimate.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnUltimate.Location = new Point(464, 233);
            btnUltimate.Name = "btnUltimate";
            btnUltimate.Size = new Size(93, 41);
            btnUltimate.TabIndex = 12;
            btnUltimate.Text = "寶具";
            btnUltimate.UseVisualStyleBackColor = true;
            btnUltimate.Click += btnUltimate_Click;
            // 
            // btnSkill
            // 
            btnSkill.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSkill.Location = new Point(343, 233);
            btnSkill.Name = "btnSkill";
            btnSkill.Size = new Size(93, 41);
            btnSkill.TabIndex = 11;
            btnSkill.Text = "技能";
            btnSkill.UseVisualStyleBackColor = true;
            btnSkill.Click += btnSkill_Click;
            // 
            // btnNormalAttack
            // 
            btnNormalAttack.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNormalAttack.Location = new Point(223, 233);
            btnNormalAttack.Name = "btnNormalAttack";
            btnNormalAttack.Size = new Size(93, 41);
            btnNormalAttack.TabIndex = 10;
            btnNormalAttack.Text = "普攻";
            btnNormalAttack.UseVisualStyleBackColor = true;
            btnNormalAttack.Click += btnNormalAttack_Click;
            // 
            // lblBeastAtk
            // 
            lblBeastAtk.AutoSize = true;
            lblBeastAtk.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblBeastAtk.Location = new Point(627, 285);
            lblBeastAtk.Name = "lblBeastAtk";
            lblBeastAtk.Size = new Size(109, 26);
            lblBeastAtk.TabIndex = 9;
            lblBeastAtk.Text = "Attack：2";
            // 
            // lblBeastCharge
            // 
            lblBeastCharge.AutoSize = true;
            lblBeastCharge.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblBeastCharge.Location = new Point(604, 259);
            lblBeastCharge.Name = "lblBeastCharge";
            lblBeastCharge.Size = new Size(135, 26);
            lblBeastCharge.TabIndex = 8;
            lblBeastCharge.Text = "Charge：0%";
            // 
            // lblBeastHp
            // 
            lblBeastHp.AutoSize = true;
            lblBeastHp.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblBeastHp.Location = new Point(632, 233);
            lblBeastHp.Name = "lblBeastHp";
            lblBeastHp.Size = new Size(98, 26);
            lblBeastHp.TabIndex = 7;
            lblBeastHp.Text = "Hp：500";
            // 
            // lblBeast
            // 
            lblBeast.AutoSize = true;
            lblBeast.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblBeast.Location = new Point(642, 207);
            lblBeast.Name = "lblBeast";
            lblBeast.Size = new Size(67, 26);
            lblBeast.TabIndex = 6;
            lblBeast.Text = "Beast";
            // 
            // lblHeroAtk
            // 
            lblHeroAtk.AutoSize = true;
            lblHeroAtk.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeroAtk.Location = new Point(63, 285);
            lblHeroAtk.Name = "lblHeroAtk";
            lblHeroAtk.Size = new Size(109, 26);
            lblHeroAtk.TabIndex = 5;
            lblHeroAtk.Text = "Attack：2";
            // 
            // lblHeroCharge
            // 
            lblHeroCharge.AutoSize = true;
            lblHeroCharge.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeroCharge.Location = new Point(40, 259);
            lblHeroCharge.Name = "lblHeroCharge";
            lblHeroCharge.Size = new Size(135, 26);
            lblHeroCharge.TabIndex = 4;
            lblHeroCharge.Text = "Charge：0%";
            // 
            // lblHeroHp
            // 
            lblHeroHp.AutoSize = true;
            lblHeroHp.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeroHp.Location = new Point(68, 233);
            lblHeroHp.Name = "lblHeroHp";
            lblHeroHp.Size = new Size(98, 26);
            lblHeroHp.TabIndex = 3;
            lblHeroHp.Text = "Hp：100";
            // 
            // lblHero
            // 
            lblHero.AutoSize = true;
            lblHero.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblHero.Location = new Point(78, 207);
            lblHero.Name = "lblHero";
            lblHero.Size = new Size(76, 26);
            lblHero.TabIndex = 2;
            lblHero.Text = "Caster";
            // 
            // lblBattleTime
            // 
            lblBattleTime.Anchor = AnchorStyles.None;
            lblBattleTime.AutoSize = true;
            lblBattleTime.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblBattleTime.Location = new Point(361, 70);
            lblBattleTime.Name = "lblBattleTime";
            lblBattleTime.Size = new Size(63, 35);
            lblBattleTime.TabIndex = 1;
            lblBattleTime.Text = "000";
            lblBattleTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTimeTitle
            // 
            lblTimeTitle.AutoSize = true;
            lblTimeTitle.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTimeTitle.Location = new Point(358, 35);
            lblTimeTitle.Name = "lblTimeTitle";
            lblTimeTitle.Size = new Size(69, 35);
            lblTimeTitle.TabIndex = 0;
            lblTimeTitle.Text = "時間";
            // 
            // timer
            // 
            timer.Interval = 1000;
            // 
            // battleTick
            // 
            battleTick.Tick += battleTick_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(panelBattle);
            Controls.Add(panelPrepare);
            Controls.Add(panelStart);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelStart.ResumeLayout(false);
            panelPrepare.ResumeLayout(false);
            panelPrepare.PerformLayout();
            panelBattle.ResumeLayout(false);
            panelBattle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelStart;
        private Panel panelPrepare;
        private Panel panelBattle;
        private Label lblPrepare;
        private Button btnStart;
        private Label lblPrepareRemain;
        private Button btnCaster;
        private Button btnSaber;
        private Button btnBerserker;
        private System.Windows.Forms.Timer timer;
        private Label lblBattleTime;
        private Label lblTimeTitle;
        private Label lblHeroAtk;
        private Label lblHeroCharge;
        private Label lblHeroHp;
        private Label lblHero;
        private Label lblBeastAtk;
        private Label lblBeastCharge;
        private Label lblBeastHp;
        private Label lblBeast;
        private Button btnUltimate;
        private Button btnSkill;
        private Button btnNormalAttack;
        private Label lblTurn;
        private System.Windows.Forms.Timer battleTick;
    }
}