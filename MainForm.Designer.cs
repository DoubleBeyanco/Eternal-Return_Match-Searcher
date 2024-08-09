namespace Ethernal_Return_Match_Seacher
{
    partial class MainForm
    {
        public delegate void OnClickDelegate(string _input);
        private OnClickDelegate onClickCallback;
        public OnClickDelegate OnClickCallback { set { onClickCallback = value; } }

        public delegate void OnSearchDelegate();
        private OnSearchDelegate onSearchCallback;
        public OnSearchDelegate OnSerarchCallback { set {  onSearchCallback = value; } }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            TextLabel1 = new Label();
            Input_nick = new TextBox();
            Btn_Search = new Button();
            Player1_GroupBox = new GroupBox();
            groupBox3 = new GroupBox();
            P1_M3_CharacterCode = new Label();
            label67 = new Label();
            P1_M3_WinRate = new Label();
            label65 = new Label();
            label51 = new Label();
            P1_M3_totalGames = new Label();
            P1_M3_Top3Rate = new Label();
            label53 = new Label();
            P1_M3_AvgRank = new Label();
            label61 = new Label();
            label55 = new Label();
            P1_M3_maxKill = new Label();
            P1_M3_wins = new Label();
            label59 = new Label();
            label57 = new Label();
            P1_M3_Top3 = new Label();
            groupBox2 = new GroupBox();
            P1_M2_WinRate = new Label();
            label49 = new Label();
            P1_M2_CharacterCode = new Label();
            label47 = new Label();
            P1_M2_totalGames = new Label();
            label36 = new Label();
            P1_M2_maxKill = new Label();
            label34 = new Label();
            P1_M2_Top3 = new Label();
            label31 = new Label();
            P1_M2_wins = new Label();
            label26 = new Label();
            P1_M2_AvgRank = new Label();
            label16 = new Label();
            P1_M2_Top3Rate = new Label();
            label13 = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            P1_M1_CharacterCode = new Label();
            label2 = new Label();
            P1_M1_totalGames = new Label();
            label7 = new Label();
            P1_M1_maxKill = new Label();
            label8 = new Label();
            P1_M1_Top3 = new Label();
            label10 = new Label();
            P1_M1_wins = new Label();
            label11 = new Label();
            P1_M1_AvgRank = new Label();
            label24 = new Label();
            P1_M1_Top3Rate = new Label();
            label15 = new Label();
            P1_M1_WinRate = new Label();
            P1_Avg_Assist_Text = new Label();
            P1_Avg_TK_Text = new Label();
            P1_Avg_Kill_Text = new Label();
            P1_Avg_Assist = new Label();
            P1_Avg_Kill = new Label();
            P1_Avg_TK = new Label();
            P1_RP_Calc = new Label();
            Player1_Text = new Label();
            Player1 = new Label();
            P1_Avg_Rank_Text = new Label();
            P1_Avg_Dmg_Text = new Label();
            P1_totalGame_Text = new Label();
            P1_Top3_Text = new Label();
            P1_Top2_Text = new Label();
            P1_WinRate_Text = new Label();
            P1_RP_Text = new Label();
            P1_Avg_Rank = new Label();
            P1_Avg_Dmg = new Label();
            P1_totalGame = new Label();
            P1_Top3 = new Label();
            P1_Top2 = new Label();
            P1_WinRate = new Label();
            P1_RP = new Label();
            button1 = new Button();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            P2_M3_CharacterCode = new Label();
            P2_M3_maxKill = new Label();
            P2_M3_wins = new Label();
            P2_M3_Top3 = new Label();
            P2_M3_totalGames = new Label();
            label5 = new Label();
            P2_M3_WinRate = new Label();
            label9 = new Label();
            label12 = new Label();
            P2_M3_Top3Rate = new Label();
            label19 = new Label();
            P2_M3_AvgRank = new Label();
            label22 = new Label();
            label23 = new Label();
            label28 = new Label();
            label29 = new Label();
            groupBox6 = new GroupBox();
            P2_M2_WinRate = new Label();
            P2_M2_Top3Rate = new Label();
            label33 = new Label();
            P2_M2_CharacterCode = new Label();
            label37 = new Label();
            P2_M2_totalGames = new Label();
            label42 = new Label();
            P2_M2_maxKill = new Label();
            label44 = new Label();
            P2_M2_Top3 = new Label();
            label46 = new Label();
            P2_M2_wins = new Label();
            label50 = new Label();
            P2_M2_AvgRank = new Label();
            label54 = new Label();
            label58 = new Label();
            groupBox7 = new GroupBox();
            label60 = new Label();
            P2_M1_CharacterCode = new Label();
            label64 = new Label();
            P2_M1_totalGames = new Label();
            label70 = new Label();
            P2_M1_maxKill = new Label();
            label72 = new Label();
            P2_M1_Top3 = new Label();
            label74 = new Label();
            P2_M1_wins = new Label();
            label76 = new Label();
            P2_M1_AvgRank = new Label();
            label78 = new Label();
            P2_M1_Top3Rate = new Label();
            label80 = new Label();
            P2_M1_WinRate = new Label();
            P2_Avg_Assist_Text = new Label();
            P2_Avg_TK_Text = new Label();
            P2_Avg_Kill_Text = new Label();
            label85 = new Label();
            label86 = new Label();
            label87 = new Label();
            P2_RP_Calc = new Label();
            Player2_Text = new Label();
            label90 = new Label();
            P2_Avg_Rank_Text = new Label();
            P2_Avg_Dmg_Text = new Label();
            P2_totalGame_Text = new Label();
            P2_Top3_Text = new Label();
            P2_Top2_Text = new Label();
            P2_WinRate_Text = new Label();
            P2_RP_Text = new Label();
            label98 = new Label();
            label99 = new Label();
            label100 = new Label();
            label101 = new Label();
            label102 = new Label();
            label103 = new Label();
            label104 = new Label();
            groupBox8 = new GroupBox();
            groupBox9 = new GroupBox();
            P3_M3_CharacterCode = new Label();
            P3_M3_maxKill = new Label();
            P3_M3_wins = new Label();
            P3_M3_totalGames = new Label();
            P3_M3_Top3 = new Label();
            label106 = new Label();
            P3_M3_WinRate = new Label();
            label108 = new Label();
            label109 = new Label();
            P3_M3_Top3Rate = new Label();
            label113 = new Label();
            P3_M3_AvgRank = new Label();
            label116 = new Label();
            label117 = new Label();
            label120 = new Label();
            label121 = new Label();
            groupBox10 = new GroupBox();
            P3_M2_WinRate = new Label();
            label124 = new Label();
            P3_M2_CharacterCode = new Label();
            label126 = new Label();
            P3_M2_totalGames = new Label();
            label130 = new Label();
            P3_M2_maxKill = new Label();
            label132 = new Label();
            P3_M2_Top3 = new Label();
            label134 = new Label();
            P3_M2_wins = new Label();
            label136 = new Label();
            P3_M2_AvgRank = new Label();
            label138 = new Label();
            P3_M2_Top3Rate = new Label();
            label140 = new Label();
            groupBox11 = new GroupBox();
            label141 = new Label();
            P3_M1_CharacterCode = new Label();
            label143 = new Label();
            P3_M1_totalGames = new Label();
            label147 = new Label();
            P3_M1_maxKill = new Label();
            label149 = new Label();
            P3_M1_Top3 = new Label();
            label151 = new Label();
            P3_M1_wins = new Label();
            label153 = new Label();
            P3_M1_AvgRank = new Label();
            label155 = new Label();
            P3_M1_Top3Rate = new Label();
            label157 = new Label();
            P3_M1_WinRate = new Label();
            P3_Avg_Assist_Text = new Label();
            P3_Avg_TK_Text = new Label();
            P3_Avg_Kill_Text = new Label();
            label162 = new Label();
            label163 = new Label();
            label164 = new Label();
            P3_RP_Calc = new Label();
            Player3_Text = new Label();
            label167 = new Label();
            P3_Avg_Rank_Text = new Label();
            P3_Avg_Dmg_Text = new Label();
            P3_totalGame_Text = new Label();
            P3_Top3_Text = new Label();
            P3_Top2_Text = new Label();
            P3_WinRate_Text = new Label();
            P3_RP_Text = new Label();
            label175 = new Label();
            label176 = new Label();
            label177 = new Label();
            label178 = new Label();
            label179 = new Label();
            label180 = new Label();
            label181 = new Label();
            Process_Text = new Label();
            pictureBox1 = new PictureBox();
            Player1_GroupBox.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TextLabel1
            // 
            TextLabel1.AutoSize = true;
            TextLabel1.Font = new Font("Maplestory", 8.999999F);
            TextLabel1.Location = new Point(519, 11);
            TextLabel1.Name = "TextLabel1";
            TextLabel1.Size = new Size(76, 13);
            TextLabel1.TabIndex = 0;
            TextLabel1.Text = "개인 유저 검색";
            // 
            // Input_nick
            // 
            Input_nick.Font = new Font("Maplestory", 8.999999F);
            Input_nick.Location = new Point(601, 7);
            Input_nick.Name = "Input_nick";
            Input_nick.Size = new Size(100, 21);
            Input_nick.TabIndex = 1;
            Input_nick.TextChanged += txtbox_TextChanged;
            // 
            // Btn_Search
            // 
            Btn_Search.Font = new Font("Maplestory", 8.999999F);
            Btn_Search.Location = new Point(707, 6);
            Btn_Search.Name = "Btn_Search";
            Btn_Search.Size = new Size(75, 23);
            Btn_Search.TabIndex = 2;
            Btn_Search.Text = "Search";
            Btn_Search.UseVisualStyleBackColor = true;
            Btn_Search.Click += SearchBtn_Click;
            // 
            // Player1_GroupBox
            // 
            Player1_GroupBox.Controls.Add(groupBox3);
            Player1_GroupBox.Controls.Add(groupBox2);
            Player1_GroupBox.Controls.Add(groupBox1);
            Player1_GroupBox.Controls.Add(P1_Avg_Assist_Text);
            Player1_GroupBox.Controls.Add(P1_Avg_TK_Text);
            Player1_GroupBox.Controls.Add(P1_Avg_Kill_Text);
            Player1_GroupBox.Controls.Add(P1_Avg_Assist);
            Player1_GroupBox.Controls.Add(P1_Avg_Kill);
            Player1_GroupBox.Controls.Add(P1_Avg_TK);
            Player1_GroupBox.Controls.Add(P1_RP_Calc);
            Player1_GroupBox.Controls.Add(Player1_Text);
            Player1_GroupBox.Controls.Add(Player1);
            Player1_GroupBox.Controls.Add(P1_Avg_Rank_Text);
            Player1_GroupBox.Controls.Add(P1_Avg_Dmg_Text);
            Player1_GroupBox.Controls.Add(P1_totalGame_Text);
            Player1_GroupBox.Controls.Add(P1_Top3_Text);
            Player1_GroupBox.Controls.Add(P1_Top2_Text);
            Player1_GroupBox.Controls.Add(P1_WinRate_Text);
            Player1_GroupBox.Controls.Add(P1_RP_Text);
            Player1_GroupBox.Controls.Add(P1_Avg_Rank);
            Player1_GroupBox.Controls.Add(P1_Avg_Dmg);
            Player1_GroupBox.Controls.Add(P1_totalGame);
            Player1_GroupBox.Controls.Add(P1_Top3);
            Player1_GroupBox.Controls.Add(P1_Top2);
            Player1_GroupBox.Controls.Add(P1_WinRate);
            Player1_GroupBox.Controls.Add(P1_RP);
            Player1_GroupBox.Font = new Font("Maplestory", 8.999999F);
            Player1_GroupBox.Location = new Point(8, 30);
            Player1_GroupBox.Name = "Player1_GroupBox";
            Player1_GroupBox.Size = new Size(286, 491);
            Player1_GroupBox.TabIndex = 3;
            Player1_GroupBox.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(P1_M3_CharacterCode);
            groupBox3.Controls.Add(label67);
            groupBox3.Controls.Add(P1_M3_WinRate);
            groupBox3.Controls.Add(label65);
            groupBox3.Controls.Add(label51);
            groupBox3.Controls.Add(P1_M3_totalGames);
            groupBox3.Controls.Add(P1_M3_Top3Rate);
            groupBox3.Controls.Add(label53);
            groupBox3.Controls.Add(P1_M3_AvgRank);
            groupBox3.Controls.Add(label61);
            groupBox3.Controls.Add(label55);
            groupBox3.Controls.Add(P1_M3_maxKill);
            groupBox3.Controls.Add(P1_M3_wins);
            groupBox3.Controls.Add(label59);
            groupBox3.Controls.Add(label57);
            groupBox3.Controls.Add(P1_M3_Top3);
            groupBox3.Location = new Point(6, 382);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(275, 100);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            // 
            // P1_M3_CharacterCode
            // 
            P1_M3_CharacterCode.AutoSize = true;
            P1_M3_CharacterCode.Font = new Font("Maplestory", 9.75F);
            P1_M3_CharacterCode.Location = new Point(63, 13);
            P1_M3_CharacterCode.Name = "P1_M3_CharacterCode";
            P1_M3_CharacterCode.Size = new Size(37, 14);
            P1_M3_CharacterCode.TabIndex = 59;
            P1_M3_CharacterCode.Text = "Text";
            // 
            // label67
            // 
            label67.AutoSize = true;
            label67.Font = new Font("Maplestory", 9.75F);
            label67.Location = new Point(15, 13);
            label67.Name = "label67";
            label67.Size = new Size(48, 14);
            label67.TabIndex = 58;
            label67.Text = "Most3";
            // 
            // P1_M3_WinRate
            // 
            P1_M3_WinRate.AutoSize = true;
            P1_M3_WinRate.Location = new Point(145, 77);
            P1_M3_WinRate.Name = "P1_M3_WinRate";
            P1_M3_WinRate.Size = new Size(33, 13);
            P1_M3_WinRate.TabIndex = 75;
            P1_M3_WinRate.Text = "Text";
            // 
            // label65
            // 
            label65.AutoSize = true;
            label65.Location = new Point(10, 36);
            label65.Name = "label65";
            label65.Size = new Size(54, 13);
            label65.TabIndex = 60;
            label65.Text = "총 게임 수";
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.Location = new Point(117, 77);
            label51.Name = "label51";
            label51.Size = new Size(27, 13);
            label51.TabIndex = 74;
            label51.Text = "승률";
            // 
            // P1_M3_totalGames
            // 
            P1_M3_totalGames.AutoSize = true;
            P1_M3_totalGames.Location = new Point(64, 36);
            P1_M3_totalGames.Name = "P1_M3_totalGames";
            P1_M3_totalGames.Size = new Size(33, 13);
            P1_M3_totalGames.TabIndex = 61;
            P1_M3_totalGames.Text = "Text";
            // 
            // P1_M3_Top3Rate
            // 
            P1_M3_Top3Rate.AutoSize = true;
            P1_M3_Top3Rate.Location = new Point(65, 77);
            P1_M3_Top3Rate.Name = "P1_M3_Top3Rate";
            P1_M3_Top3Rate.Size = new Size(33, 13);
            P1_M3_Top3Rate.TabIndex = 73;
            P1_M3_Top3Rate.Text = "Text";
            // 
            // label53
            // 
            label53.AutoSize = true;
            label53.Location = new Point(9, 77);
            label53.Name = "label53";
            label53.Size = new Size(48, 13);
            label53.TabIndex = 72;
            label53.Text = "Top3 %";
            // 
            // P1_M3_AvgRank
            // 
            P1_M3_AvgRank.AutoSize = true;
            P1_M3_AvgRank.Location = new Point(145, 36);
            P1_M3_AvgRank.Name = "P1_M3_AvgRank";
            P1_M3_AvgRank.Size = new Size(33, 13);
            P1_M3_AvgRank.TabIndex = 71;
            P1_M3_AvgRank.Text = "Text";
            // 
            // label61
            // 
            label61.AutoSize = true;
            label61.Location = new Point(190, 36);
            label61.Name = "label61";
            label61.Size = new Size(42, 13);
            label61.TabIndex = 64;
            label61.Text = "최대 킬";
            // 
            // label55
            // 
            label55.AutoSize = true;
            label55.Location = new Point(98, 36);
            label55.Name = "label55";
            label55.Size = new Size(50, 13);
            label55.TabIndex = 70;
            label55.Text = "평균 등수";
            // 
            // P1_M3_maxKill
            // 
            P1_M3_maxKill.AutoSize = true;
            P1_M3_maxKill.Location = new Point(235, 36);
            P1_M3_maxKill.Name = "P1_M3_maxKill";
            P1_M3_maxKill.Size = new Size(33, 13);
            P1_M3_maxKill.TabIndex = 65;
            P1_M3_maxKill.Text = "Text";
            // 
            // P1_M3_wins
            // 
            P1_M3_wins.AutoSize = true;
            P1_M3_wins.Location = new Point(145, 56);
            P1_M3_wins.Name = "P1_M3_wins";
            P1_M3_wins.Size = new Size(33, 13);
            P1_M3_wins.TabIndex = 69;
            P1_M3_wins.Text = "Text";
            // 
            // label59
            // 
            label59.AutoSize = true;
            label59.Location = new Point(9, 56);
            label59.Name = "label59";
            label59.Size = new Size(58, 13);
            label59.TabIndex = 66;
            label59.Text = "Top3 횟수";
            // 
            // label57
            // 
            label57.AutoSize = true;
            label57.Location = new Point(103, 56);
            label57.Name = "label57";
            label57.Size = new Size(45, 13);
            label57.TabIndex = 68;
            label57.Text = "1등 횟수";
            // 
            // P1_M3_Top3
            // 
            P1_M3_Top3.AutoSize = true;
            P1_M3_Top3.Location = new Point(65, 56);
            P1_M3_Top3.Name = "P1_M3_Top3";
            P1_M3_Top3.Size = new Size(33, 13);
            P1_M3_Top3.TabIndex = 67;
            P1_M3_Top3.Text = "Text";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(P1_M2_WinRate);
            groupBox2.Controls.Add(label49);
            groupBox2.Controls.Add(P1_M2_CharacterCode);
            groupBox2.Controls.Add(label47);
            groupBox2.Controls.Add(P1_M2_totalGames);
            groupBox2.Controls.Add(label36);
            groupBox2.Controls.Add(P1_M2_maxKill);
            groupBox2.Controls.Add(label34);
            groupBox2.Controls.Add(P1_M2_Top3);
            groupBox2.Controls.Add(label31);
            groupBox2.Controls.Add(P1_M2_wins);
            groupBox2.Controls.Add(label26);
            groupBox2.Controls.Add(P1_M2_AvgRank);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(P1_M2_Top3Rate);
            groupBox2.Controls.Add(label13);
            groupBox2.Location = new Point(6, 282);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(275, 100);
            groupBox2.TabIndex = 77;
            groupBox2.TabStop = false;
            // 
            // P1_M2_WinRate
            // 
            P1_M2_WinRate.AutoSize = true;
            P1_M2_WinRate.Location = new Point(145, 77);
            P1_M2_WinRate.Name = "P1_M2_WinRate";
            P1_M2_WinRate.Size = new Size(33, 13);
            P1_M2_WinRate.TabIndex = 57;
            P1_M2_WinRate.Text = "Text";
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.Font = new Font("Maplestory", 9.75F);
            label49.Location = new Point(14, 13);
            label49.Name = "label49";
            label49.Size = new Size(48, 14);
            label49.TabIndex = 40;
            label49.Text = "Most2";
            // 
            // P1_M2_CharacterCode
            // 
            P1_M2_CharacterCode.AutoSize = true;
            P1_M2_CharacterCode.Font = new Font("Maplestory", 9.75F);
            P1_M2_CharacterCode.Location = new Point(62, 13);
            P1_M2_CharacterCode.Name = "P1_M2_CharacterCode";
            P1_M2_CharacterCode.Size = new Size(37, 14);
            P1_M2_CharacterCode.TabIndex = 41;
            P1_M2_CharacterCode.Text = "Text";
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.Location = new Point(9, 36);
            label47.Name = "label47";
            label47.Size = new Size(54, 13);
            label47.TabIndex = 42;
            label47.Text = "총 게임 수";
            // 
            // P1_M2_totalGames
            // 
            P1_M2_totalGames.AutoSize = true;
            P1_M2_totalGames.Location = new Point(63, 36);
            P1_M2_totalGames.Name = "P1_M2_totalGames";
            P1_M2_totalGames.Size = new Size(33, 13);
            P1_M2_totalGames.TabIndex = 43;
            P1_M2_totalGames.Text = "Text";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(190, 36);
            label36.Name = "label36";
            label36.Size = new Size(42, 13);
            label36.TabIndex = 46;
            label36.Text = "최대 킬";
            // 
            // P1_M2_maxKill
            // 
            P1_M2_maxKill.AutoSize = true;
            P1_M2_maxKill.Location = new Point(234, 36);
            P1_M2_maxKill.Name = "P1_M2_maxKill";
            P1_M2_maxKill.Size = new Size(33, 13);
            P1_M2_maxKill.TabIndex = 47;
            P1_M2_maxKill.Text = "Text";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(8, 56);
            label34.Name = "label34";
            label34.Size = new Size(58, 13);
            label34.TabIndex = 48;
            label34.Text = "Top3 횟수";
            // 
            // P1_M2_Top3
            // 
            P1_M2_Top3.AutoSize = true;
            P1_M2_Top3.Location = new Point(64, 56);
            P1_M2_Top3.Name = "P1_M2_Top3";
            P1_M2_Top3.Size = new Size(33, 13);
            P1_M2_Top3.TabIndex = 49;
            P1_M2_Top3.Text = "Text";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(103, 56);
            label31.Name = "label31";
            label31.Size = new Size(45, 13);
            label31.TabIndex = 50;
            label31.Text = "1등 횟수";
            // 
            // P1_M2_wins
            // 
            P1_M2_wins.AutoSize = true;
            P1_M2_wins.Location = new Point(145, 56);
            P1_M2_wins.Name = "P1_M2_wins";
            P1_M2_wins.Size = new Size(33, 13);
            P1_M2_wins.TabIndex = 51;
            P1_M2_wins.Text = "Text";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(100, 36);
            label26.Name = "label26";
            label26.Size = new Size(50, 13);
            label26.TabIndex = 52;
            label26.Text = "평균 등수";
            // 
            // P1_M2_AvgRank
            // 
            P1_M2_AvgRank.AutoSize = true;
            P1_M2_AvgRank.Location = new Point(147, 36);
            P1_M2_AvgRank.Name = "P1_M2_AvgRank";
            P1_M2_AvgRank.Size = new Size(33, 13);
            P1_M2_AvgRank.TabIndex = 53;
            P1_M2_AvgRank.Text = "Text";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(8, 77);
            label16.Name = "label16";
            label16.Size = new Size(48, 13);
            label16.TabIndex = 54;
            label16.Text = "Top3 %";
            // 
            // P1_M2_Top3Rate
            // 
            P1_M2_Top3Rate.AutoSize = true;
            P1_M2_Top3Rate.Location = new Point(64, 77);
            P1_M2_Top3Rate.Name = "P1_M2_Top3Rate";
            P1_M2_Top3Rate.Size = new Size(33, 13);
            P1_M2_Top3Rate.TabIndex = 55;
            P1_M2_Top3Rate.Text = "Text";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(117, 77);
            label13.Name = "label13";
            label13.Size = new Size(27, 13);
            label13.TabIndex = 56;
            label13.Text = "승률";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(P1_M1_CharacterCode);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(P1_M1_totalGames);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(P1_M1_maxKill);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(P1_M1_Top3);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(P1_M1_wins);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(P1_M1_AvgRank);
            groupBox1.Controls.Add(label24);
            groupBox1.Controls.Add(P1_M1_Top3Rate);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(P1_M1_WinRate);
            groupBox1.Location = new Point(5, 179);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(275, 100);
            groupBox1.TabIndex = 76;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Maplestory", 9.75F);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(46, 14);
            label1.TabIndex = 22;
            label1.Text = "Most1";
            // 
            // P1_M1_CharacterCode
            // 
            P1_M1_CharacterCode.AutoSize = true;
            P1_M1_CharacterCode.Font = new Font("Maplestory", 9.75F);
            P1_M1_CharacterCode.Location = new Point(60, 13);
            P1_M1_CharacterCode.Name = "P1_M1_CharacterCode";
            P1_M1_CharacterCode.Size = new Size(37, 14);
            P1_M1_CharacterCode.TabIndex = 23;
            P1_M1_CharacterCode.Text = "Text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 37);
            label2.Name = "label2";
            label2.Size = new Size(54, 13);
            label2.TabIndex = 24;
            label2.Text = "총 게임 수";
            // 
            // P1_M1_totalGames
            // 
            P1_M1_totalGames.AutoSize = true;
            P1_M1_totalGames.Location = new Point(64, 37);
            P1_M1_totalGames.Name = "P1_M1_totalGames";
            P1_M1_totalGames.Size = new Size(33, 13);
            P1_M1_totalGames.TabIndex = 25;
            P1_M1_totalGames.Text = "Text";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(191, 37);
            label7.Name = "label7";
            label7.Size = new Size(42, 13);
            label7.TabIndex = 28;
            label7.Text = "최대 킬";
            // 
            // P1_M1_maxKill
            // 
            P1_M1_maxKill.AutoSize = true;
            P1_M1_maxKill.Location = new Point(235, 37);
            P1_M1_maxKill.Name = "P1_M1_maxKill";
            P1_M1_maxKill.Size = new Size(33, 13);
            P1_M1_maxKill.TabIndex = 29;
            P1_M1_maxKill.Text = "Text";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 57);
            label8.Name = "label8";
            label8.Size = new Size(58, 13);
            label8.TabIndex = 30;
            label8.Text = "Top3 횟수";
            // 
            // P1_M1_Top3
            // 
            P1_M1_Top3.AutoSize = true;
            P1_M1_Top3.Location = new Point(65, 57);
            P1_M1_Top3.Name = "P1_M1_Top3";
            P1_M1_Top3.Size = new Size(33, 13);
            P1_M1_Top3.TabIndex = 31;
            P1_M1_Top3.Text = "Text";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(106, 57);
            label10.Name = "label10";
            label10.Size = new Size(45, 13);
            label10.TabIndex = 32;
            label10.Text = "1등 횟수";
            // 
            // P1_M1_wins
            // 
            P1_M1_wins.AutoSize = true;
            P1_M1_wins.Location = new Point(148, 57);
            P1_M1_wins.Name = "P1_M1_wins";
            P1_M1_wins.Size = new Size(33, 13);
            P1_M1_wins.TabIndex = 33;
            P1_M1_wins.Text = "Text";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(101, 37);
            label11.Name = "label11";
            label11.Size = new Size(50, 13);
            label11.TabIndex = 34;
            label11.Text = "평균 등수";
            // 
            // P1_M1_AvgRank
            // 
            P1_M1_AvgRank.AutoSize = true;
            P1_M1_AvgRank.Location = new Point(148, 37);
            P1_M1_AvgRank.Name = "P1_M1_AvgRank";
            P1_M1_AvgRank.Size = new Size(33, 13);
            P1_M1_AvgRank.TabIndex = 35;
            P1_M1_AvgRank.Text = "Text";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(9, 78);
            label24.Name = "label24";
            label24.Size = new Size(48, 13);
            label24.TabIndex = 36;
            label24.Text = "Top3 %";
            // 
            // P1_M1_Top3Rate
            // 
            P1_M1_Top3Rate.AutoSize = true;
            P1_M1_Top3Rate.Location = new Point(65, 78);
            P1_M1_Top3Rate.Name = "P1_M1_Top3Rate";
            P1_M1_Top3Rate.Size = new Size(33, 13);
            P1_M1_Top3Rate.TabIndex = 37;
            P1_M1_Top3Rate.Text = "Text";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(120, 78);
            label15.Name = "label15";
            label15.Size = new Size(27, 13);
            label15.TabIndex = 38;
            label15.Text = "승률";
            // 
            // P1_M1_WinRate
            // 
            P1_M1_WinRate.AutoSize = true;
            P1_M1_WinRate.Location = new Point(148, 78);
            P1_M1_WinRate.Name = "P1_M1_WinRate";
            P1_M1_WinRate.Size = new Size(33, 13);
            P1_M1_WinRate.TabIndex = 39;
            P1_M1_WinRate.Text = "Text";
            // 
            // P1_Avg_Assist_Text
            // 
            P1_Avg_Assist_Text.AutoSize = true;
            P1_Avg_Assist_Text.Font = new Font("Maplestory", 8.999999F);
            P1_Avg_Assist_Text.Location = new Point(206, 161);
            P1_Avg_Assist_Text.Name = "P1_Avg_Assist_Text";
            P1_Avg_Assist_Text.Size = new Size(33, 13);
            P1_Avg_Assist_Text.TabIndex = 18;
            P1_Avg_Assist_Text.Text = "Text";
            P1_Avg_Assist_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P1_Avg_TK_Text
            // 
            P1_Avg_TK_Text.AutoSize = true;
            P1_Avg_TK_Text.Font = new Font("Maplestory", 8.999999F);
            P1_Avg_TK_Text.Location = new Point(206, 82);
            P1_Avg_TK_Text.Name = "P1_Avg_TK_Text";
            P1_Avg_TK_Text.Size = new Size(33, 13);
            P1_Avg_TK_Text.TabIndex = 17;
            P1_Avg_TK_Text.Text = "Text";
            P1_Avg_TK_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P1_Avg_Kill_Text
            // 
            P1_Avg_Kill_Text.AutoSize = true;
            P1_Avg_Kill_Text.Font = new Font("Maplestory", 8.999999F);
            P1_Avg_Kill_Text.Location = new Point(206, 121);
            P1_Avg_Kill_Text.Name = "P1_Avg_Kill_Text";
            P1_Avg_Kill_Text.Size = new Size(33, 13);
            P1_Avg_Kill_Text.TabIndex = 17;
            P1_Avg_Kill_Text.Text = "Text";
            P1_Avg_Kill_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P1_Avg_Assist
            // 
            P1_Avg_Assist.AutoSize = true;
            P1_Avg_Assist.Font = new Font("Maplestory", 8.999999F);
            P1_Avg_Assist.Location = new Point(206, 144);
            P1_Avg_Assist.Name = "P1_Avg_Assist";
            P1_Avg_Assist.Size = new Size(53, 13);
            P1_Avg_Assist.TabIndex = 9;
            P1_Avg_Assist.Text = "평균 어시";
            // 
            // P1_Avg_Kill
            // 
            P1_Avg_Kill.AutoSize = true;
            P1_Avg_Kill.Font = new Font("Maplestory", 8.999999F);
            P1_Avg_Kill.Location = new Point(206, 104);
            P1_Avg_Kill.Name = "P1_Avg_Kill";
            P1_Avg_Kill.Size = new Size(41, 13);
            P1_Avg_Kill.TabIndex = 8;
            P1_Avg_Kill.Text = "평균 킬";
            // 
            // P1_Avg_TK
            // 
            P1_Avg_TK.AutoSize = true;
            P1_Avg_TK.Font = new Font("Maplestory", 8.999999F);
            P1_Avg_TK.Location = new Point(206, 65);
            P1_Avg_TK.Name = "P1_Avg_TK";
            P1_Avg_TK.Size = new Size(46, 13);
            P1_Avg_TK.TabIndex = 7;
            P1_Avg_TK.Text = "평균 TK";
            // 
            // P1_RP_Calc
            // 
            P1_RP_Calc.AutoSize = true;
            P1_RP_Calc.Font = new Font("Maplestory", 8.999999F);
            P1_RP_Calc.Location = new Point(116, 41);
            P1_RP_Calc.Name = "P1_RP_Calc";
            P1_RP_Calc.Size = new Size(33, 13);
            P1_RP_Calc.TabIndex = 21;
            P1_RP_Calc.Text = "Text";
            // 
            // Player1_Text
            // 
            Player1_Text.AutoSize = true;
            Player1_Text.Font = new Font("Maplestory", 9.75F);
            Player1_Text.Location = new Point(85, 19);
            Player1_Text.Name = "Player1_Text";
            Player1_Text.Size = new Size(55, 14);
            Player1_Text.TabIndex = 20;
            Player1_Text.Text = "Player1";
            // 
            // Player1
            // 
            Player1.AutoSize = true;
            Player1.Font = new Font("Maplestory", 9.75F);
            Player1.Location = new Point(18, 19);
            Player1.Name = "Player1";
            Player1.Size = new Size(75, 14);
            Player1.TabIndex = 19;
            Player1.Text = "NickName :";
            // 
            // P1_Avg_Rank_Text
            // 
            P1_Avg_Rank_Text.AutoSize = true;
            P1_Avg_Rank_Text.Font = new Font("Maplestory", 8.999999F);
            P1_Avg_Rank_Text.Location = new Point(105, 161);
            P1_Avg_Rank_Text.Name = "P1_Avg_Rank_Text";
            P1_Avg_Rank_Text.Size = new Size(33, 13);
            P1_Avg_Rank_Text.TabIndex = 16;
            P1_Avg_Rank_Text.Text = "Text";
            P1_Avg_Rank_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P1_Avg_Dmg_Text
            // 
            P1_Avg_Dmg_Text.AutoSize = true;
            P1_Avg_Dmg_Text.Font = new Font("Maplestory", 8.999999F);
            P1_Avg_Dmg_Text.Location = new Point(105, 121);
            P1_Avg_Dmg_Text.Name = "P1_Avg_Dmg_Text";
            P1_Avg_Dmg_Text.Size = new Size(33, 13);
            P1_Avg_Dmg_Text.TabIndex = 15;
            P1_Avg_Dmg_Text.Text = "Text";
            P1_Avg_Dmg_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P1_totalGame_Text
            // 
            P1_totalGame_Text.AutoSize = true;
            P1_totalGame_Text.Font = new Font("Maplestory", 8.999999F);
            P1_totalGame_Text.Location = new Point(105, 82);
            P1_totalGame_Text.Name = "P1_totalGame_Text";
            P1_totalGame_Text.Size = new Size(33, 13);
            P1_totalGame_Text.TabIndex = 14;
            P1_totalGame_Text.Text = "Text";
            P1_totalGame_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P1_Top3_Text
            // 
            P1_Top3_Text.AutoSize = true;
            P1_Top3_Text.Font = new Font("Maplestory", 8.999999F);
            P1_Top3_Text.Location = new Point(17, 161);
            P1_Top3_Text.Name = "P1_Top3_Text";
            P1_Top3_Text.Size = new Size(33, 13);
            P1_Top3_Text.TabIndex = 13;
            P1_Top3_Text.Text = "Text";
            P1_Top3_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P1_Top2_Text
            // 
            P1_Top2_Text.AutoSize = true;
            P1_Top2_Text.Font = new Font("Maplestory", 8.999999F);
            P1_Top2_Text.Location = new Point(17, 121);
            P1_Top2_Text.Name = "P1_Top2_Text";
            P1_Top2_Text.Size = new Size(33, 13);
            P1_Top2_Text.TabIndex = 12;
            P1_Top2_Text.Text = "Text";
            P1_Top2_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P1_WinRate_Text
            // 
            P1_WinRate_Text.AutoSize = true;
            P1_WinRate_Text.Font = new Font("Maplestory", 8.999999F);
            P1_WinRate_Text.Location = new Point(17, 82);
            P1_WinRate_Text.Name = "P1_WinRate_Text";
            P1_WinRate_Text.Size = new Size(33, 13);
            P1_WinRate_Text.TabIndex = 11;
            P1_WinRate_Text.Text = "Text";
            P1_WinRate_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P1_RP_Text
            // 
            P1_RP_Text.AutoSize = true;
            P1_RP_Text.Font = new Font("Maplestory", 8.999999F);
            P1_RP_Text.Location = new Point(68, 41);
            P1_RP_Text.Name = "P1_RP_Text";
            P1_RP_Text.Size = new Size(33, 13);
            P1_RP_Text.TabIndex = 10;
            P1_RP_Text.Text = "Text";
            // 
            // P1_Avg_Rank
            // 
            P1_Avg_Rank.AutoSize = true;
            P1_Avg_Rank.Font = new Font("Maplestory", 8.999999F);
            P1_Avg_Rank.Location = new Point(105, 144);
            P1_Avg_Rank.Name = "P1_Avg_Rank";
            P1_Avg_Rank.Size = new Size(52, 13);
            P1_Avg_Rank.TabIndex = 6;
            P1_Avg_Rank.Text = "평균 순위";
            // 
            // P1_Avg_Dmg
            // 
            P1_Avg_Dmg.AutoSize = true;
            P1_Avg_Dmg.Font = new Font("Maplestory", 8.999999F);
            P1_Avg_Dmg.Location = new Point(105, 104);
            P1_Avg_Dmg.Name = "P1_Avg_Dmg";
            P1_Avg_Dmg.Size = new Size(53, 13);
            P1_Avg_Dmg.TabIndex = 5;
            P1_Avg_Dmg.Text = "평균 딜량";
            // 
            // P1_totalGame
            // 
            P1_totalGame.AutoSize = true;
            P1_totalGame.Font = new Font("Maplestory", 8.999999F);
            P1_totalGame.Location = new Point(105, 65);
            P1_totalGame.Name = "P1_totalGame";
            P1_totalGame.Size = new Size(41, 13);
            P1_totalGame.TabIndex = 4;
            P1_totalGame.Text = "게임 수";
            // 
            // P1_Top3
            // 
            P1_Top3.AutoSize = true;
            P1_Top3.Font = new Font("Maplestory", 8.999999F);
            P1_Top3.Location = new Point(17, 144);
            P1_Top3.Name = "P1_Top3";
            P1_Top3.Size = new Size(38, 13);
            P1_Top3.TabIndex = 3;
            P1_Top3.Text = "Top 3";
            // 
            // P1_Top2
            // 
            P1_Top2.AutoSize = true;
            P1_Top2.Font = new Font("Maplestory", 8.999999F);
            P1_Top2.Location = new Point(17, 104);
            P1_Top2.Name = "P1_Top2";
            P1_Top2.Size = new Size(38, 13);
            P1_Top2.TabIndex = 2;
            P1_Top2.Text = "Top 2";
            // 
            // P1_WinRate
            // 
            P1_WinRate.AutoSize = true;
            P1_WinRate.Font = new Font("Maplestory", 8.999999F);
            P1_WinRate.Location = new Point(17, 65);
            P1_WinRate.Name = "P1_WinRate";
            P1_WinRate.Size = new Size(27, 13);
            P1_WinRate.TabIndex = 1;
            P1_WinRate.Text = "승률";
            // 
            // P1_RP
            // 
            P1_RP.AutoSize = true;
            P1_RP.Font = new Font("Maplestory", 8.999999F);
            P1_RP.Location = new Point(43, 41);
            P1_RP.Name = "P1_RP";
            P1_RP.Size = new Size(29, 13);
            P1_RP.TabIndex = 0;
            P1_RP.Text = "RP :";
            // 
            // button1
            // 
            button1.Font = new Font("Maplestory", 8.999999F);
            button1.Location = new Point(14, 6);
            button1.Name = "button1";
            button1.Size = new Size(79, 26);
            button1.TabIndex = 6;
            button1.Text = "매치 탐색";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Controls.Add(groupBox6);
            groupBox4.Controls.Add(groupBox7);
            groupBox4.Controls.Add(P2_Avg_Assist_Text);
            groupBox4.Controls.Add(P2_Avg_TK_Text);
            groupBox4.Controls.Add(P2_Avg_Kill_Text);
            groupBox4.Controls.Add(label85);
            groupBox4.Controls.Add(label86);
            groupBox4.Controls.Add(label87);
            groupBox4.Controls.Add(P2_RP_Calc);
            groupBox4.Controls.Add(Player2_Text);
            groupBox4.Controls.Add(label90);
            groupBox4.Controls.Add(P2_Avg_Rank_Text);
            groupBox4.Controls.Add(P2_Avg_Dmg_Text);
            groupBox4.Controls.Add(P2_totalGame_Text);
            groupBox4.Controls.Add(P2_Top3_Text);
            groupBox4.Controls.Add(P2_Top2_Text);
            groupBox4.Controls.Add(P2_WinRate_Text);
            groupBox4.Controls.Add(P2_RP_Text);
            groupBox4.Controls.Add(label98);
            groupBox4.Controls.Add(label99);
            groupBox4.Controls.Add(label100);
            groupBox4.Controls.Add(label101);
            groupBox4.Controls.Add(label102);
            groupBox4.Controls.Add(label103);
            groupBox4.Controls.Add(label104);
            groupBox4.Font = new Font("Maplestory", 8.999999F);
            groupBox4.Location = new Point(309, 30);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(286, 491);
            groupBox4.TabIndex = 78;
            groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(P2_M3_CharacterCode);
            groupBox5.Controls.Add(P2_M3_maxKill);
            groupBox5.Controls.Add(P2_M3_wins);
            groupBox5.Controls.Add(P2_M3_Top3);
            groupBox5.Controls.Add(P2_M3_totalGames);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(P2_M3_WinRate);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(P2_M3_Top3Rate);
            groupBox5.Controls.Add(label19);
            groupBox5.Controls.Add(P2_M3_AvgRank);
            groupBox5.Controls.Add(label22);
            groupBox5.Controls.Add(label23);
            groupBox5.Controls.Add(label28);
            groupBox5.Controls.Add(label29);
            groupBox5.Location = new Point(6, 382);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(275, 100);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            // 
            // P2_M3_CharacterCode
            // 
            P2_M3_CharacterCode.AutoSize = true;
            P2_M3_CharacterCode.Font = new Font("Maplestory", 9.75F);
            P2_M3_CharacterCode.Location = new Point(64, 14);
            P2_M3_CharacterCode.Name = "P2_M3_CharacterCode";
            P2_M3_CharacterCode.Size = new Size(37, 14);
            P2_M3_CharacterCode.TabIndex = 81;
            P2_M3_CharacterCode.Text = "Text";
            // 
            // P2_M3_maxKill
            // 
            P2_M3_maxKill.AutoSize = true;
            P2_M3_maxKill.Location = new Point(234, 36);
            P2_M3_maxKill.Name = "P2_M3_maxKill";
            P2_M3_maxKill.Size = new Size(33, 13);
            P2_M3_maxKill.TabIndex = 80;
            P2_M3_maxKill.Text = "Text";
            // 
            // P2_M3_wins
            // 
            P2_M3_wins.AutoSize = true;
            P2_M3_wins.Location = new Point(145, 56);
            P2_M3_wins.Name = "P2_M3_wins";
            P2_M3_wins.Size = new Size(33, 13);
            P2_M3_wins.TabIndex = 79;
            P2_M3_wins.Text = "Text";
            // 
            // P2_M3_Top3
            // 
            P2_M3_Top3.AutoSize = true;
            P2_M3_Top3.Location = new Point(66, 56);
            P2_M3_Top3.Name = "P2_M3_Top3";
            P2_M3_Top3.Size = new Size(33, 13);
            P2_M3_Top3.TabIndex = 77;
            P2_M3_Top3.Text = "Text";
            // 
            // P2_M3_totalGames
            // 
            P2_M3_totalGames.AutoSize = true;
            P2_M3_totalGames.Location = new Point(66, 36);
            P2_M3_totalGames.Name = "P2_M3_totalGames";
            P2_M3_totalGames.Size = new Size(33, 13);
            P2_M3_totalGames.TabIndex = 76;
            P2_M3_totalGames.Text = "Text";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Maplestory", 9.75F);
            label5.Location = new Point(15, 14);
            label5.Name = "label5";
            label5.Size = new Size(48, 14);
            label5.TabIndex = 58;
            label5.Text = "Most3";
            // 
            // P2_M3_WinRate
            // 
            P2_M3_WinRate.AutoSize = true;
            P2_M3_WinRate.Location = new Point(145, 77);
            P2_M3_WinRate.Name = "P2_M3_WinRate";
            P2_M3_WinRate.Size = new Size(33, 13);
            P2_M3_WinRate.TabIndex = 75;
            P2_M3_WinRate.Text = "Text";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 36);
            label9.Name = "label9";
            label9.Size = new Size(54, 13);
            label9.TabIndex = 60;
            label9.Text = "총 게임 수";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(117, 77);
            label12.Name = "label12";
            label12.Size = new Size(27, 13);
            label12.TabIndex = 74;
            label12.Text = "승률";
            // 
            // P2_M3_Top3Rate
            // 
            P2_M3_Top3Rate.AutoSize = true;
            P2_M3_Top3Rate.Location = new Point(65, 77);
            P2_M3_Top3Rate.Name = "P2_M3_Top3Rate";
            P2_M3_Top3Rate.Size = new Size(33, 13);
            P2_M3_Top3Rate.TabIndex = 73;
            P2_M3_Top3Rate.Text = "Text";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(9, 77);
            label19.Name = "label19";
            label19.Size = new Size(48, 13);
            label19.TabIndex = 72;
            label19.Text = "Top3 %";
            // 
            // P2_M3_AvgRank
            // 
            P2_M3_AvgRank.AutoSize = true;
            P2_M3_AvgRank.Location = new Point(146, 36);
            P2_M3_AvgRank.Name = "P2_M3_AvgRank";
            P2_M3_AvgRank.Size = new Size(33, 13);
            P2_M3_AvgRank.TabIndex = 71;
            P2_M3_AvgRank.Text = "Text";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(190, 36);
            label22.Name = "label22";
            label22.Size = new Size(42, 13);
            label22.TabIndex = 64;
            label22.Text = "최대 킬";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(99, 36);
            label23.Name = "label23";
            label23.Size = new Size(50, 13);
            label23.TabIndex = 70;
            label23.Text = "평균 등수";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(9, 56);
            label28.Name = "label28";
            label28.Size = new Size(58, 13);
            label28.TabIndex = 66;
            label28.Text = "Top3 횟수";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(103, 56);
            label29.Name = "label29";
            label29.Size = new Size(45, 13);
            label29.TabIndex = 68;
            label29.Text = "1등 횟수";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(P2_M2_WinRate);
            groupBox6.Controls.Add(P2_M2_Top3Rate);
            groupBox6.Controls.Add(label33);
            groupBox6.Controls.Add(P2_M2_CharacterCode);
            groupBox6.Controls.Add(label37);
            groupBox6.Controls.Add(P2_M2_totalGames);
            groupBox6.Controls.Add(label42);
            groupBox6.Controls.Add(P2_M2_maxKill);
            groupBox6.Controls.Add(label44);
            groupBox6.Controls.Add(P2_M2_Top3);
            groupBox6.Controls.Add(label46);
            groupBox6.Controls.Add(P2_M2_wins);
            groupBox6.Controls.Add(label50);
            groupBox6.Controls.Add(P2_M2_AvgRank);
            groupBox6.Controls.Add(label54);
            groupBox6.Controls.Add(label58);
            groupBox6.Location = new Point(6, 282);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(275, 100);
            groupBox6.TabIndex = 77;
            groupBox6.TabStop = false;
            // 
            // P2_M2_WinRate
            // 
            P2_M2_WinRate.AutoSize = true;
            P2_M2_WinRate.Location = new Point(145, 77);
            P2_M2_WinRate.Name = "P2_M2_WinRate";
            P2_M2_WinRate.Size = new Size(33, 13);
            P2_M2_WinRate.TabIndex = 58;
            P2_M2_WinRate.Text = "Text";
            // 
            // P2_M2_Top3Rate
            // 
            P2_M2_Top3Rate.AutoSize = true;
            P2_M2_Top3Rate.Location = new Point(64, 77);
            P2_M2_Top3Rate.Name = "P2_M2_Top3Rate";
            P2_M2_Top3Rate.Size = new Size(33, 13);
            P2_M2_Top3Rate.TabIndex = 57;
            P2_M2_Top3Rate.Text = "Text";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Maplestory", 9.75F);
            label33.Location = new Point(14, 13);
            label33.Name = "label33";
            label33.Size = new Size(48, 14);
            label33.TabIndex = 40;
            label33.Text = "Most2";
            // 
            // P2_M2_CharacterCode
            // 
            P2_M2_CharacterCode.AutoSize = true;
            P2_M2_CharacterCode.Font = new Font("Maplestory", 9.75F);
            P2_M2_CharacterCode.Location = new Point(62, 13);
            P2_M2_CharacterCode.Name = "P2_M2_CharacterCode";
            P2_M2_CharacterCode.Size = new Size(37, 14);
            P2_M2_CharacterCode.TabIndex = 41;
            P2_M2_CharacterCode.Text = "Text";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(9, 36);
            label37.Name = "label37";
            label37.Size = new Size(54, 13);
            label37.TabIndex = 42;
            label37.Text = "총 게임 수";
            // 
            // P2_M2_totalGames
            // 
            P2_M2_totalGames.AutoSize = true;
            P2_M2_totalGames.Location = new Point(63, 36);
            P2_M2_totalGames.Name = "P2_M2_totalGames";
            P2_M2_totalGames.Size = new Size(33, 13);
            P2_M2_totalGames.TabIndex = 43;
            P2_M2_totalGames.Text = "Text";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Location = new Point(190, 36);
            label42.Name = "label42";
            label42.Size = new Size(42, 13);
            label42.TabIndex = 46;
            label42.Text = "최대 킬";
            // 
            // P2_M2_maxKill
            // 
            P2_M2_maxKill.AutoSize = true;
            P2_M2_maxKill.Location = new Point(234, 36);
            P2_M2_maxKill.Name = "P2_M2_maxKill";
            P2_M2_maxKill.Size = new Size(33, 13);
            P2_M2_maxKill.TabIndex = 47;
            P2_M2_maxKill.Text = "Text";
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Location = new Point(8, 56);
            label44.Name = "label44";
            label44.Size = new Size(58, 13);
            label44.TabIndex = 48;
            label44.Text = "Top3 횟수";
            // 
            // P2_M2_Top3
            // 
            P2_M2_Top3.AutoSize = true;
            P2_M2_Top3.Location = new Point(64, 56);
            P2_M2_Top3.Name = "P2_M2_Top3";
            P2_M2_Top3.Size = new Size(33, 13);
            P2_M2_Top3.TabIndex = 49;
            P2_M2_Top3.Text = "Text";
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Location = new Point(103, 56);
            label46.Name = "label46";
            label46.Size = new Size(45, 13);
            label46.TabIndex = 50;
            label46.Text = "1등 횟수";
            // 
            // P2_M2_wins
            // 
            P2_M2_wins.AutoSize = true;
            P2_M2_wins.Location = new Point(145, 56);
            P2_M2_wins.Name = "P2_M2_wins";
            P2_M2_wins.Size = new Size(33, 13);
            P2_M2_wins.TabIndex = 51;
            P2_M2_wins.Text = "Text";
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Location = new Point(98, 36);
            label50.Name = "label50";
            label50.Size = new Size(50, 13);
            label50.TabIndex = 52;
            label50.Text = "평균 등수";
            // 
            // P2_M2_AvgRank
            // 
            P2_M2_AvgRank.AutoSize = true;
            P2_M2_AvgRank.Location = new Point(145, 36);
            P2_M2_AvgRank.Name = "P2_M2_AvgRank";
            P2_M2_AvgRank.Size = new Size(33, 13);
            P2_M2_AvgRank.TabIndex = 53;
            P2_M2_AvgRank.Text = "Text";
            // 
            // label54
            // 
            label54.AutoSize = true;
            label54.Location = new Point(8, 77);
            label54.Name = "label54";
            label54.Size = new Size(48, 13);
            label54.TabIndex = 54;
            label54.Text = "Top3 %";
            // 
            // label58
            // 
            label58.AutoSize = true;
            label58.Location = new Point(117, 77);
            label58.Name = "label58";
            label58.Size = new Size(27, 13);
            label58.TabIndex = 56;
            label58.Text = "승률";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(label60);
            groupBox7.Controls.Add(P2_M1_CharacterCode);
            groupBox7.Controls.Add(label64);
            groupBox7.Controls.Add(P2_M1_totalGames);
            groupBox7.Controls.Add(label70);
            groupBox7.Controls.Add(P2_M1_maxKill);
            groupBox7.Controls.Add(label72);
            groupBox7.Controls.Add(P2_M1_Top3);
            groupBox7.Controls.Add(label74);
            groupBox7.Controls.Add(P2_M1_wins);
            groupBox7.Controls.Add(label76);
            groupBox7.Controls.Add(P2_M1_AvgRank);
            groupBox7.Controls.Add(label78);
            groupBox7.Controls.Add(P2_M1_Top3Rate);
            groupBox7.Controls.Add(label80);
            groupBox7.Controls.Add(P2_M1_WinRate);
            groupBox7.Location = new Point(5, 179);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(275, 100);
            groupBox7.TabIndex = 76;
            groupBox7.TabStop = false;
            // 
            // label60
            // 
            label60.AutoSize = true;
            label60.Font = new Font("Maplestory", 9.75F);
            label60.Location = new Point(12, 13);
            label60.Name = "label60";
            label60.Size = new Size(46, 14);
            label60.TabIndex = 22;
            label60.Text = "Most1";
            // 
            // P2_M1_CharacterCode
            // 
            P2_M1_CharacterCode.AutoSize = true;
            P2_M1_CharacterCode.Font = new Font("Maplestory", 9.75F);
            P2_M1_CharacterCode.Location = new Point(60, 13);
            P2_M1_CharacterCode.Name = "P2_M1_CharacterCode";
            P2_M1_CharacterCode.Size = new Size(37, 14);
            P2_M1_CharacterCode.TabIndex = 23;
            P2_M1_CharacterCode.Text = "Text";
            // 
            // label64
            // 
            label64.AutoSize = true;
            label64.Location = new Point(10, 37);
            label64.Name = "label64";
            label64.Size = new Size(54, 13);
            label64.TabIndex = 24;
            label64.Text = "총 게임 수";
            // 
            // P2_M1_totalGames
            // 
            P2_M1_totalGames.AutoSize = true;
            P2_M1_totalGames.Location = new Point(64, 37);
            P2_M1_totalGames.Name = "P2_M1_totalGames";
            P2_M1_totalGames.Size = new Size(33, 13);
            P2_M1_totalGames.TabIndex = 25;
            P2_M1_totalGames.Text = "Text";
            // 
            // label70
            // 
            label70.AutoSize = true;
            label70.Location = new Point(191, 37);
            label70.Name = "label70";
            label70.Size = new Size(42, 13);
            label70.TabIndex = 28;
            label70.Text = "최대 킬";
            // 
            // P2_M1_maxKill
            // 
            P2_M1_maxKill.AutoSize = true;
            P2_M1_maxKill.Location = new Point(235, 37);
            P2_M1_maxKill.Name = "P2_M1_maxKill";
            P2_M1_maxKill.Size = new Size(33, 13);
            P2_M1_maxKill.TabIndex = 29;
            P2_M1_maxKill.Text = "Text";
            // 
            // label72
            // 
            label72.AutoSize = true;
            label72.Location = new Point(9, 57);
            label72.Name = "label72";
            label72.Size = new Size(58, 13);
            label72.TabIndex = 30;
            label72.Text = "Top3 횟수";
            // 
            // P2_M1_Top3
            // 
            P2_M1_Top3.AutoSize = true;
            P2_M1_Top3.Location = new Point(65, 57);
            P2_M1_Top3.Name = "P2_M1_Top3";
            P2_M1_Top3.Size = new Size(33, 13);
            P2_M1_Top3.TabIndex = 31;
            P2_M1_Top3.Text = "Text";
            // 
            // label74
            // 
            label74.AutoSize = true;
            label74.Location = new Point(106, 57);
            label74.Name = "label74";
            label74.Size = new Size(45, 13);
            label74.TabIndex = 32;
            label74.Text = "1등 횟수";
            // 
            // P2_M1_wins
            // 
            P2_M1_wins.AutoSize = true;
            P2_M1_wins.Location = new Point(148, 57);
            P2_M1_wins.Name = "P2_M1_wins";
            P2_M1_wins.Size = new Size(33, 13);
            P2_M1_wins.TabIndex = 33;
            P2_M1_wins.Text = "Text";
            // 
            // label76
            // 
            label76.AutoSize = true;
            label76.Location = new Point(103, 37);
            label76.Name = "label76";
            label76.Size = new Size(50, 13);
            label76.TabIndex = 34;
            label76.Text = "평균 등수";
            // 
            // P2_M1_AvgRank
            // 
            P2_M1_AvgRank.AutoSize = true;
            P2_M1_AvgRank.Location = new Point(150, 37);
            P2_M1_AvgRank.Name = "P2_M1_AvgRank";
            P2_M1_AvgRank.Size = new Size(33, 13);
            P2_M1_AvgRank.TabIndex = 35;
            P2_M1_AvgRank.Text = "Text";
            // 
            // label78
            // 
            label78.AutoSize = true;
            label78.Location = new Point(9, 78);
            label78.Name = "label78";
            label78.Size = new Size(48, 13);
            label78.TabIndex = 36;
            label78.Text = "Top3 %";
            // 
            // P2_M1_Top3Rate
            // 
            P2_M1_Top3Rate.AutoSize = true;
            P2_M1_Top3Rate.Location = new Point(65, 78);
            P2_M1_Top3Rate.Name = "P2_M1_Top3Rate";
            P2_M1_Top3Rate.Size = new Size(33, 13);
            P2_M1_Top3Rate.TabIndex = 37;
            P2_M1_Top3Rate.Text = "Text";
            // 
            // label80
            // 
            label80.AutoSize = true;
            label80.Location = new Point(120, 78);
            label80.Name = "label80";
            label80.Size = new Size(27, 13);
            label80.TabIndex = 38;
            label80.Text = "승률";
            // 
            // P2_M1_WinRate
            // 
            P2_M1_WinRate.AutoSize = true;
            P2_M1_WinRate.Location = new Point(148, 78);
            P2_M1_WinRate.Name = "P2_M1_WinRate";
            P2_M1_WinRate.Size = new Size(33, 13);
            P2_M1_WinRate.TabIndex = 39;
            P2_M1_WinRate.Text = "Text";
            // 
            // P2_Avg_Assist_Text
            // 
            P2_Avg_Assist_Text.AutoSize = true;
            P2_Avg_Assist_Text.Font = new Font("Maplestory", 8.999999F);
            P2_Avg_Assist_Text.Location = new Point(206, 161);
            P2_Avg_Assist_Text.Name = "P2_Avg_Assist_Text";
            P2_Avg_Assist_Text.Size = new Size(33, 13);
            P2_Avg_Assist_Text.TabIndex = 18;
            P2_Avg_Assist_Text.Text = "Text";
            P2_Avg_Assist_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P2_Avg_TK_Text
            // 
            P2_Avg_TK_Text.AutoSize = true;
            P2_Avg_TK_Text.Font = new Font("Maplestory", 8.999999F);
            P2_Avg_TK_Text.Location = new Point(206, 82);
            P2_Avg_TK_Text.Name = "P2_Avg_TK_Text";
            P2_Avg_TK_Text.Size = new Size(33, 13);
            P2_Avg_TK_Text.TabIndex = 17;
            P2_Avg_TK_Text.Text = "Text";
            P2_Avg_TK_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P2_Avg_Kill_Text
            // 
            P2_Avg_Kill_Text.AutoSize = true;
            P2_Avg_Kill_Text.Font = new Font("Maplestory", 8.999999F);
            P2_Avg_Kill_Text.Location = new Point(206, 121);
            P2_Avg_Kill_Text.Name = "P2_Avg_Kill_Text";
            P2_Avg_Kill_Text.Size = new Size(33, 13);
            P2_Avg_Kill_Text.TabIndex = 17;
            P2_Avg_Kill_Text.Text = "Text";
            P2_Avg_Kill_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label85
            // 
            label85.AutoSize = true;
            label85.Font = new Font("Maplestory", 8.999999F);
            label85.Location = new Point(206, 144);
            label85.Name = "label85";
            label85.Size = new Size(53, 13);
            label85.TabIndex = 9;
            label85.Text = "평균 어시";
            // 
            // label86
            // 
            label86.AutoSize = true;
            label86.Font = new Font("Maplestory", 8.999999F);
            label86.Location = new Point(206, 104);
            label86.Name = "label86";
            label86.Size = new Size(41, 13);
            label86.TabIndex = 8;
            label86.Text = "평균 킬";
            // 
            // label87
            // 
            label87.AutoSize = true;
            label87.Font = new Font("Maplestory", 8.999999F);
            label87.Location = new Point(206, 65);
            label87.Name = "label87";
            label87.Size = new Size(46, 13);
            label87.TabIndex = 7;
            label87.Text = "평균 TK";
            // 
            // P2_RP_Calc
            // 
            P2_RP_Calc.AutoSize = true;
            P2_RP_Calc.Font = new Font("Maplestory", 8.999999F);
            P2_RP_Calc.Location = new Point(116, 41);
            P2_RP_Calc.Name = "P2_RP_Calc";
            P2_RP_Calc.Size = new Size(33, 13);
            P2_RP_Calc.TabIndex = 21;
            P2_RP_Calc.Text = "Text";
            // 
            // Player2_Text
            // 
            Player2_Text.AutoSize = true;
            Player2_Text.Font = new Font("Maplestory", 9.75F);
            Player2_Text.Location = new Point(85, 19);
            Player2_Text.Name = "Player2_Text";
            Player2_Text.Size = new Size(57, 14);
            Player2_Text.TabIndex = 20;
            Player2_Text.Text = "Player2";
            // 
            // label90
            // 
            label90.AutoSize = true;
            label90.Font = new Font("Maplestory", 9.75F);
            label90.Location = new Point(18, 19);
            label90.Name = "label90";
            label90.Size = new Size(75, 14);
            label90.TabIndex = 19;
            label90.Text = "NickName :";
            // 
            // P2_Avg_Rank_Text
            // 
            P2_Avg_Rank_Text.AutoSize = true;
            P2_Avg_Rank_Text.Font = new Font("Maplestory", 8.999999F);
            P2_Avg_Rank_Text.Location = new Point(105, 161);
            P2_Avg_Rank_Text.Name = "P2_Avg_Rank_Text";
            P2_Avg_Rank_Text.Size = new Size(33, 13);
            P2_Avg_Rank_Text.TabIndex = 16;
            P2_Avg_Rank_Text.Text = "Text";
            P2_Avg_Rank_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P2_Avg_Dmg_Text
            // 
            P2_Avg_Dmg_Text.AutoSize = true;
            P2_Avg_Dmg_Text.Font = new Font("Maplestory", 8.999999F);
            P2_Avg_Dmg_Text.Location = new Point(105, 121);
            P2_Avg_Dmg_Text.Name = "P2_Avg_Dmg_Text";
            P2_Avg_Dmg_Text.Size = new Size(33, 13);
            P2_Avg_Dmg_Text.TabIndex = 15;
            P2_Avg_Dmg_Text.Text = "Text";
            P2_Avg_Dmg_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P2_totalGame_Text
            // 
            P2_totalGame_Text.AutoSize = true;
            P2_totalGame_Text.Font = new Font("Maplestory", 8.999999F);
            P2_totalGame_Text.Location = new Point(105, 82);
            P2_totalGame_Text.Name = "P2_totalGame_Text";
            P2_totalGame_Text.Size = new Size(33, 13);
            P2_totalGame_Text.TabIndex = 14;
            P2_totalGame_Text.Text = "Text";
            P2_totalGame_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P2_Top3_Text
            // 
            P2_Top3_Text.AutoSize = true;
            P2_Top3_Text.Font = new Font("Maplestory", 8.999999F);
            P2_Top3_Text.Location = new Point(17, 161);
            P2_Top3_Text.Name = "P2_Top3_Text";
            P2_Top3_Text.Size = new Size(33, 13);
            P2_Top3_Text.TabIndex = 13;
            P2_Top3_Text.Text = "Text";
            P2_Top3_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P2_Top2_Text
            // 
            P2_Top2_Text.AutoSize = true;
            P2_Top2_Text.Font = new Font("Maplestory", 8.999999F);
            P2_Top2_Text.Location = new Point(17, 121);
            P2_Top2_Text.Name = "P2_Top2_Text";
            P2_Top2_Text.Size = new Size(33, 13);
            P2_Top2_Text.TabIndex = 12;
            P2_Top2_Text.Text = "Text";
            P2_Top2_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P2_WinRate_Text
            // 
            P2_WinRate_Text.AutoSize = true;
            P2_WinRate_Text.Font = new Font("Maplestory", 8.999999F);
            P2_WinRate_Text.Location = new Point(17, 82);
            P2_WinRate_Text.Name = "P2_WinRate_Text";
            P2_WinRate_Text.Size = new Size(33, 13);
            P2_WinRate_Text.TabIndex = 11;
            P2_WinRate_Text.Text = "Text";
            P2_WinRate_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P2_RP_Text
            // 
            P2_RP_Text.AutoSize = true;
            P2_RP_Text.Font = new Font("Maplestory", 8.999999F);
            P2_RP_Text.Location = new Point(68, 41);
            P2_RP_Text.Name = "P2_RP_Text";
            P2_RP_Text.Size = new Size(33, 13);
            P2_RP_Text.TabIndex = 10;
            P2_RP_Text.Text = "Text";
            // 
            // label98
            // 
            label98.AutoSize = true;
            label98.Font = new Font("Maplestory", 8.999999F);
            label98.Location = new Point(105, 144);
            label98.Name = "label98";
            label98.Size = new Size(52, 13);
            label98.TabIndex = 6;
            label98.Text = "평균 순위";
            // 
            // label99
            // 
            label99.AutoSize = true;
            label99.Font = new Font("Maplestory", 8.999999F);
            label99.Location = new Point(105, 104);
            label99.Name = "label99";
            label99.Size = new Size(53, 13);
            label99.TabIndex = 5;
            label99.Text = "평균 딜량";
            // 
            // label100
            // 
            label100.AutoSize = true;
            label100.Font = new Font("Maplestory", 8.999999F);
            label100.Location = new Point(105, 65);
            label100.Name = "label100";
            label100.Size = new Size(41, 13);
            label100.TabIndex = 4;
            label100.Text = "게임 수";
            // 
            // label101
            // 
            label101.AutoSize = true;
            label101.Font = new Font("Maplestory", 8.999999F);
            label101.Location = new Point(17, 144);
            label101.Name = "label101";
            label101.Size = new Size(38, 13);
            label101.TabIndex = 3;
            label101.Text = "Top 3";
            // 
            // label102
            // 
            label102.AutoSize = true;
            label102.Font = new Font("Maplestory", 8.999999F);
            label102.Location = new Point(17, 104);
            label102.Name = "label102";
            label102.Size = new Size(38, 13);
            label102.TabIndex = 2;
            label102.Text = "Top 2";
            // 
            // label103
            // 
            label103.AutoSize = true;
            label103.Font = new Font("Maplestory", 8.999999F);
            label103.Location = new Point(17, 65);
            label103.Name = "label103";
            label103.Size = new Size(27, 13);
            label103.TabIndex = 1;
            label103.Text = "승률";
            // 
            // label104
            // 
            label104.AutoSize = true;
            label104.Font = new Font("Maplestory", 8.999999F);
            label104.Location = new Point(43, 41);
            label104.Name = "label104";
            label104.Size = new Size(29, 13);
            label104.TabIndex = 0;
            label104.Text = "RP :";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(groupBox9);
            groupBox8.Controls.Add(groupBox10);
            groupBox8.Controls.Add(groupBox11);
            groupBox8.Controls.Add(P3_Avg_Assist_Text);
            groupBox8.Controls.Add(P3_Avg_TK_Text);
            groupBox8.Controls.Add(P3_Avg_Kill_Text);
            groupBox8.Controls.Add(label162);
            groupBox8.Controls.Add(label163);
            groupBox8.Controls.Add(label164);
            groupBox8.Controls.Add(P3_RP_Calc);
            groupBox8.Controls.Add(Player3_Text);
            groupBox8.Controls.Add(label167);
            groupBox8.Controls.Add(P3_Avg_Rank_Text);
            groupBox8.Controls.Add(P3_Avg_Dmg_Text);
            groupBox8.Controls.Add(P3_totalGame_Text);
            groupBox8.Controls.Add(P3_Top3_Text);
            groupBox8.Controls.Add(P3_Top2_Text);
            groupBox8.Controls.Add(P3_WinRate_Text);
            groupBox8.Controls.Add(P3_RP_Text);
            groupBox8.Controls.Add(label175);
            groupBox8.Controls.Add(label176);
            groupBox8.Controls.Add(label177);
            groupBox8.Controls.Add(label178);
            groupBox8.Controls.Add(label179);
            groupBox8.Controls.Add(label180);
            groupBox8.Controls.Add(label181);
            groupBox8.Font = new Font("Maplestory", 8.999999F);
            groupBox8.Location = new Point(608, 30);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(286, 491);
            groupBox8.TabIndex = 78;
            groupBox8.TabStop = false;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(P3_M3_CharacterCode);
            groupBox9.Controls.Add(P3_M3_maxKill);
            groupBox9.Controls.Add(P3_M3_wins);
            groupBox9.Controls.Add(P3_M3_totalGames);
            groupBox9.Controls.Add(P3_M3_Top3);
            groupBox9.Controls.Add(label106);
            groupBox9.Controls.Add(P3_M3_WinRate);
            groupBox9.Controls.Add(label108);
            groupBox9.Controls.Add(label109);
            groupBox9.Controls.Add(P3_M3_Top3Rate);
            groupBox9.Controls.Add(label113);
            groupBox9.Controls.Add(P3_M3_AvgRank);
            groupBox9.Controls.Add(label116);
            groupBox9.Controls.Add(label117);
            groupBox9.Controls.Add(label120);
            groupBox9.Controls.Add(label121);
            groupBox9.Location = new Point(6, 382);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(275, 100);
            groupBox9.TabIndex = 7;
            groupBox9.TabStop = false;
            // 
            // P3_M3_CharacterCode
            // 
            P3_M3_CharacterCode.AutoSize = true;
            P3_M3_CharacterCode.Font = new Font("Maplestory", 9.75F);
            P3_M3_CharacterCode.Location = new Point(64, 14);
            P3_M3_CharacterCode.Name = "P3_M3_CharacterCode";
            P3_M3_CharacterCode.Size = new Size(37, 14);
            P3_M3_CharacterCode.TabIndex = 82;
            P3_M3_CharacterCode.Text = "Text";
            // 
            // P3_M3_maxKill
            // 
            P3_M3_maxKill.AutoSize = true;
            P3_M3_maxKill.Location = new Point(234, 36);
            P3_M3_maxKill.Name = "P3_M3_maxKill";
            P3_M3_maxKill.Size = new Size(33, 13);
            P3_M3_maxKill.TabIndex = 85;
            P3_M3_maxKill.Text = "Text";
            // 
            // P3_M3_wins
            // 
            P3_M3_wins.AutoSize = true;
            P3_M3_wins.Location = new Point(145, 56);
            P3_M3_wins.Name = "P3_M3_wins";
            P3_M3_wins.Size = new Size(33, 13);
            P3_M3_wins.TabIndex = 84;
            P3_M3_wins.Text = "Text";
            // 
            // P3_M3_totalGames
            // 
            P3_M3_totalGames.AutoSize = true;
            P3_M3_totalGames.Location = new Point(66, 36);
            P3_M3_totalGames.Name = "P3_M3_totalGames";
            P3_M3_totalGames.Size = new Size(33, 13);
            P3_M3_totalGames.TabIndex = 82;
            P3_M3_totalGames.Text = "Text";
            // 
            // P3_M3_Top3
            // 
            P3_M3_Top3.AutoSize = true;
            P3_M3_Top3.Location = new Point(66, 56);
            P3_M3_Top3.Name = "P3_M3_Top3";
            P3_M3_Top3.Size = new Size(33, 13);
            P3_M3_Top3.TabIndex = 81;
            P3_M3_Top3.Text = "Text";
            // 
            // label106
            // 
            label106.AutoSize = true;
            label106.Font = new Font("Maplestory", 9.75F);
            label106.Location = new Point(15, 14);
            label106.Name = "label106";
            label106.Size = new Size(48, 14);
            label106.TabIndex = 58;
            label106.Text = "Most3";
            // 
            // P3_M3_WinRate
            // 
            P3_M3_WinRate.AutoSize = true;
            P3_M3_WinRate.Location = new Point(145, 77);
            P3_M3_WinRate.Name = "P3_M3_WinRate";
            P3_M3_WinRate.Size = new Size(33, 13);
            P3_M3_WinRate.TabIndex = 75;
            P3_M3_WinRate.Text = "Text";
            // 
            // label108
            // 
            label108.AutoSize = true;
            label108.Location = new Point(10, 36);
            label108.Name = "label108";
            label108.Size = new Size(54, 13);
            label108.TabIndex = 60;
            label108.Text = "총 게임 수";
            // 
            // label109
            // 
            label109.AutoSize = true;
            label109.Location = new Point(117, 77);
            label109.Name = "label109";
            label109.Size = new Size(27, 13);
            label109.TabIndex = 74;
            label109.Text = "승률";
            // 
            // P3_M3_Top3Rate
            // 
            P3_M3_Top3Rate.AutoSize = true;
            P3_M3_Top3Rate.Location = new Point(65, 77);
            P3_M3_Top3Rate.Name = "P3_M3_Top3Rate";
            P3_M3_Top3Rate.Size = new Size(33, 13);
            P3_M3_Top3Rate.TabIndex = 73;
            P3_M3_Top3Rate.Text = "Text";
            // 
            // label113
            // 
            label113.AutoSize = true;
            label113.Location = new Point(9, 77);
            label113.Name = "label113";
            label113.Size = new Size(48, 13);
            label113.TabIndex = 72;
            label113.Text = "Top3 %";
            // 
            // P3_M3_AvgRank
            // 
            P3_M3_AvgRank.AutoSize = true;
            P3_M3_AvgRank.Location = new Point(147, 36);
            P3_M3_AvgRank.Name = "P3_M3_AvgRank";
            P3_M3_AvgRank.Size = new Size(33, 13);
            P3_M3_AvgRank.TabIndex = 71;
            P3_M3_AvgRank.Text = "Text";
            // 
            // label116
            // 
            label116.AutoSize = true;
            label116.Location = new Point(190, 36);
            label116.Name = "label116";
            label116.Size = new Size(42, 13);
            label116.TabIndex = 64;
            label116.Text = "최대 킬";
            // 
            // label117
            // 
            label117.AutoSize = true;
            label117.Location = new Point(100, 36);
            label117.Name = "label117";
            label117.Size = new Size(50, 13);
            label117.TabIndex = 70;
            label117.Text = "평균 등수";
            // 
            // label120
            // 
            label120.AutoSize = true;
            label120.Location = new Point(9, 56);
            label120.Name = "label120";
            label120.Size = new Size(58, 13);
            label120.TabIndex = 66;
            label120.Text = "Top3 횟수";
            // 
            // label121
            // 
            label121.AutoSize = true;
            label121.Location = new Point(103, 56);
            label121.Name = "label121";
            label121.Size = new Size(45, 13);
            label121.TabIndex = 68;
            label121.Text = "1등 횟수";
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(P3_M2_WinRate);
            groupBox10.Controls.Add(label124);
            groupBox10.Controls.Add(P3_M2_CharacterCode);
            groupBox10.Controls.Add(label126);
            groupBox10.Controls.Add(P3_M2_totalGames);
            groupBox10.Controls.Add(label130);
            groupBox10.Controls.Add(P3_M2_maxKill);
            groupBox10.Controls.Add(label132);
            groupBox10.Controls.Add(P3_M2_Top3);
            groupBox10.Controls.Add(label134);
            groupBox10.Controls.Add(P3_M2_wins);
            groupBox10.Controls.Add(label136);
            groupBox10.Controls.Add(P3_M2_AvgRank);
            groupBox10.Controls.Add(label138);
            groupBox10.Controls.Add(P3_M2_Top3Rate);
            groupBox10.Controls.Add(label140);
            groupBox10.Location = new Point(6, 282);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(275, 100);
            groupBox10.TabIndex = 77;
            groupBox10.TabStop = false;
            // 
            // P3_M2_WinRate
            // 
            P3_M2_WinRate.AutoSize = true;
            P3_M2_WinRate.Location = new Point(146, 77);
            P3_M2_WinRate.Name = "P3_M2_WinRate";
            P3_M2_WinRate.Size = new Size(33, 13);
            P3_M2_WinRate.TabIndex = 59;
            P3_M2_WinRate.Text = "Text";
            // 
            // label124
            // 
            label124.AutoSize = true;
            label124.Font = new Font("Maplestory", 9.75F);
            label124.Location = new Point(14, 13);
            label124.Name = "label124";
            label124.Size = new Size(48, 14);
            label124.TabIndex = 40;
            label124.Text = "Most2";
            // 
            // P3_M2_CharacterCode
            // 
            P3_M2_CharacterCode.AutoSize = true;
            P3_M2_CharacterCode.Font = new Font("Maplestory", 9.75F);
            P3_M2_CharacterCode.Location = new Point(62, 13);
            P3_M2_CharacterCode.Name = "P3_M2_CharacterCode";
            P3_M2_CharacterCode.Size = new Size(37, 14);
            P3_M2_CharacterCode.TabIndex = 41;
            P3_M2_CharacterCode.Text = "Text";
            // 
            // label126
            // 
            label126.AutoSize = true;
            label126.Location = new Point(9, 36);
            label126.Name = "label126";
            label126.Size = new Size(54, 13);
            label126.TabIndex = 42;
            label126.Text = "총 게임 수";
            // 
            // P3_M2_totalGames
            // 
            P3_M2_totalGames.AutoSize = true;
            P3_M2_totalGames.Location = new Point(63, 36);
            P3_M2_totalGames.Name = "P3_M2_totalGames";
            P3_M2_totalGames.Size = new Size(33, 13);
            P3_M2_totalGames.TabIndex = 43;
            P3_M2_totalGames.Text = "Text";
            // 
            // label130
            // 
            label130.AutoSize = true;
            label130.Location = new Point(190, 36);
            label130.Name = "label130";
            label130.Size = new Size(42, 13);
            label130.TabIndex = 46;
            label130.Text = "최대 킬";
            // 
            // P3_M2_maxKill
            // 
            P3_M2_maxKill.AutoSize = true;
            P3_M2_maxKill.Location = new Point(234, 36);
            P3_M2_maxKill.Name = "P3_M2_maxKill";
            P3_M2_maxKill.Size = new Size(33, 13);
            P3_M2_maxKill.TabIndex = 47;
            P3_M2_maxKill.Text = "Text";
            // 
            // label132
            // 
            label132.AutoSize = true;
            label132.Location = new Point(8, 56);
            label132.Name = "label132";
            label132.Size = new Size(58, 13);
            label132.TabIndex = 48;
            label132.Text = "Top3 횟수";
            // 
            // P3_M2_Top3
            // 
            P3_M2_Top3.AutoSize = true;
            P3_M2_Top3.Location = new Point(64, 56);
            P3_M2_Top3.Name = "P3_M2_Top3";
            P3_M2_Top3.Size = new Size(33, 13);
            P3_M2_Top3.TabIndex = 49;
            P3_M2_Top3.Text = "Text";
            // 
            // label134
            // 
            label134.AutoSize = true;
            label134.Location = new Point(103, 56);
            label134.Name = "label134";
            label134.Size = new Size(45, 13);
            label134.TabIndex = 50;
            label134.Text = "1등 횟수";
            // 
            // P3_M2_wins
            // 
            P3_M2_wins.AutoSize = true;
            P3_M2_wins.Location = new Point(145, 56);
            P3_M2_wins.Name = "P3_M2_wins";
            P3_M2_wins.Size = new Size(33, 13);
            P3_M2_wins.TabIndex = 51;
            P3_M2_wins.Text = "Text";
            // 
            // label136
            // 
            label136.AutoSize = true;
            label136.Location = new Point(98, 36);
            label136.Name = "label136";
            label136.Size = new Size(50, 13);
            label136.TabIndex = 52;
            label136.Text = "평균 등수";
            // 
            // P3_M2_AvgRank
            // 
            P3_M2_AvgRank.AutoSize = true;
            P3_M2_AvgRank.Location = new Point(145, 36);
            P3_M2_AvgRank.Name = "P3_M2_AvgRank";
            P3_M2_AvgRank.Size = new Size(33, 13);
            P3_M2_AvgRank.TabIndex = 53;
            P3_M2_AvgRank.Text = "Text";
            // 
            // label138
            // 
            label138.AutoSize = true;
            label138.Location = new Point(8, 77);
            label138.Name = "label138";
            label138.Size = new Size(48, 13);
            label138.TabIndex = 54;
            label138.Text = "Top3 %";
            // 
            // P3_M2_Top3Rate
            // 
            P3_M2_Top3Rate.AutoSize = true;
            P3_M2_Top3Rate.Location = new Point(64, 77);
            P3_M2_Top3Rate.Name = "P3_M2_Top3Rate";
            P3_M2_Top3Rate.Size = new Size(33, 13);
            P3_M2_Top3Rate.TabIndex = 55;
            P3_M2_Top3Rate.Text = "Text";
            // 
            // label140
            // 
            label140.AutoSize = true;
            label140.Location = new Point(117, 77);
            label140.Name = "label140";
            label140.Size = new Size(27, 13);
            label140.TabIndex = 56;
            label140.Text = "승률";
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(label141);
            groupBox11.Controls.Add(P3_M1_CharacterCode);
            groupBox11.Controls.Add(label143);
            groupBox11.Controls.Add(P3_M1_totalGames);
            groupBox11.Controls.Add(label147);
            groupBox11.Controls.Add(P3_M1_maxKill);
            groupBox11.Controls.Add(label149);
            groupBox11.Controls.Add(P3_M1_Top3);
            groupBox11.Controls.Add(label151);
            groupBox11.Controls.Add(P3_M1_wins);
            groupBox11.Controls.Add(label153);
            groupBox11.Controls.Add(P3_M1_AvgRank);
            groupBox11.Controls.Add(label155);
            groupBox11.Controls.Add(P3_M1_Top3Rate);
            groupBox11.Controls.Add(label157);
            groupBox11.Controls.Add(P3_M1_WinRate);
            groupBox11.Location = new Point(5, 179);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new Size(275, 100);
            groupBox11.TabIndex = 76;
            groupBox11.TabStop = false;
            // 
            // label141
            // 
            label141.AutoSize = true;
            label141.Font = new Font("Maplestory", 9.75F);
            label141.Location = new Point(12, 13);
            label141.Name = "label141";
            label141.Size = new Size(46, 14);
            label141.TabIndex = 22;
            label141.Text = "Most1";
            // 
            // P3_M1_CharacterCode
            // 
            P3_M1_CharacterCode.AutoSize = true;
            P3_M1_CharacterCode.Font = new Font("Maplestory", 9.75F);
            P3_M1_CharacterCode.Location = new Point(60, 13);
            P3_M1_CharacterCode.Name = "P3_M1_CharacterCode";
            P3_M1_CharacterCode.Size = new Size(37, 14);
            P3_M1_CharacterCode.TabIndex = 23;
            P3_M1_CharacterCode.Text = "Text";
            // 
            // label143
            // 
            label143.AutoSize = true;
            label143.Location = new Point(10, 37);
            label143.Name = "label143";
            label143.Size = new Size(54, 13);
            label143.TabIndex = 24;
            label143.Text = "총 게임 수";
            // 
            // P3_M1_totalGames
            // 
            P3_M1_totalGames.AutoSize = true;
            P3_M1_totalGames.Location = new Point(64, 37);
            P3_M1_totalGames.Name = "P3_M1_totalGames";
            P3_M1_totalGames.Size = new Size(33, 13);
            P3_M1_totalGames.TabIndex = 25;
            P3_M1_totalGames.Text = "Text";
            // 
            // label147
            // 
            label147.AutoSize = true;
            label147.Location = new Point(191, 37);
            label147.Name = "label147";
            label147.Size = new Size(42, 13);
            label147.TabIndex = 28;
            label147.Text = "최대 킬";
            // 
            // P3_M1_maxKill
            // 
            P3_M1_maxKill.AutoSize = true;
            P3_M1_maxKill.Location = new Point(235, 37);
            P3_M1_maxKill.Name = "P3_M1_maxKill";
            P3_M1_maxKill.Size = new Size(33, 13);
            P3_M1_maxKill.TabIndex = 29;
            P3_M1_maxKill.Text = "Text";
            // 
            // label149
            // 
            label149.AutoSize = true;
            label149.Location = new Point(9, 57);
            label149.Name = "label149";
            label149.Size = new Size(58, 13);
            label149.TabIndex = 30;
            label149.Text = "Top3 횟수";
            // 
            // P3_M1_Top3
            // 
            P3_M1_Top3.AutoSize = true;
            P3_M1_Top3.Location = new Point(65, 57);
            P3_M1_Top3.Name = "P3_M1_Top3";
            P3_M1_Top3.Size = new Size(33, 13);
            P3_M1_Top3.TabIndex = 31;
            P3_M1_Top3.Text = "Text";
            // 
            // label151
            // 
            label151.AutoSize = true;
            label151.Location = new Point(106, 57);
            label151.Name = "label151";
            label151.Size = new Size(45, 13);
            label151.TabIndex = 32;
            label151.Text = "1등 횟수";
            // 
            // P3_M1_wins
            // 
            P3_M1_wins.AutoSize = true;
            P3_M1_wins.Location = new Point(148, 57);
            P3_M1_wins.Name = "P3_M1_wins";
            P3_M1_wins.Size = new Size(33, 13);
            P3_M1_wins.TabIndex = 33;
            P3_M1_wins.Text = "Text";
            // 
            // label153
            // 
            label153.AutoSize = true;
            label153.Location = new Point(102, 37);
            label153.Name = "label153";
            label153.Size = new Size(50, 13);
            label153.TabIndex = 34;
            label153.Text = "평균 등수";
            // 
            // P3_M1_AvgRank
            // 
            P3_M1_AvgRank.AutoSize = true;
            P3_M1_AvgRank.Location = new Point(149, 37);
            P3_M1_AvgRank.Name = "P3_M1_AvgRank";
            P3_M1_AvgRank.Size = new Size(33, 13);
            P3_M1_AvgRank.TabIndex = 35;
            P3_M1_AvgRank.Text = "Text";
            // 
            // label155
            // 
            label155.AutoSize = true;
            label155.Location = new Point(9, 78);
            label155.Name = "label155";
            label155.Size = new Size(48, 13);
            label155.TabIndex = 36;
            label155.Text = "Top3 %";
            // 
            // P3_M1_Top3Rate
            // 
            P3_M1_Top3Rate.AutoSize = true;
            P3_M1_Top3Rate.Location = new Point(65, 78);
            P3_M1_Top3Rate.Name = "P3_M1_Top3Rate";
            P3_M1_Top3Rate.Size = new Size(33, 13);
            P3_M1_Top3Rate.TabIndex = 37;
            P3_M1_Top3Rate.Text = "Text";
            // 
            // label157
            // 
            label157.AutoSize = true;
            label157.Location = new Point(120, 78);
            label157.Name = "label157";
            label157.Size = new Size(27, 13);
            label157.TabIndex = 38;
            label157.Text = "승률";
            // 
            // P3_M1_WinRate
            // 
            P3_M1_WinRate.AutoSize = true;
            P3_M1_WinRate.Location = new Point(148, 78);
            P3_M1_WinRate.Name = "P3_M1_WinRate";
            P3_M1_WinRate.Size = new Size(33, 13);
            P3_M1_WinRate.TabIndex = 39;
            P3_M1_WinRate.Text = "Text";
            // 
            // P3_Avg_Assist_Text
            // 
            P3_Avg_Assist_Text.AutoSize = true;
            P3_Avg_Assist_Text.Font = new Font("Maplestory", 8.999999F);
            P3_Avg_Assist_Text.Location = new Point(206, 161);
            P3_Avg_Assist_Text.Name = "P3_Avg_Assist_Text";
            P3_Avg_Assist_Text.Size = new Size(33, 13);
            P3_Avg_Assist_Text.TabIndex = 18;
            P3_Avg_Assist_Text.Text = "Text";
            P3_Avg_Assist_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P3_Avg_TK_Text
            // 
            P3_Avg_TK_Text.AutoSize = true;
            P3_Avg_TK_Text.Font = new Font("Maplestory", 8.999999F);
            P3_Avg_TK_Text.Location = new Point(206, 82);
            P3_Avg_TK_Text.Name = "P3_Avg_TK_Text";
            P3_Avg_TK_Text.Size = new Size(33, 13);
            P3_Avg_TK_Text.TabIndex = 17;
            P3_Avg_TK_Text.Text = "Text";
            P3_Avg_TK_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P3_Avg_Kill_Text
            // 
            P3_Avg_Kill_Text.AutoSize = true;
            P3_Avg_Kill_Text.Font = new Font("Maplestory", 8.999999F);
            P3_Avg_Kill_Text.Location = new Point(206, 121);
            P3_Avg_Kill_Text.Name = "P3_Avg_Kill_Text";
            P3_Avg_Kill_Text.Size = new Size(33, 13);
            P3_Avg_Kill_Text.TabIndex = 17;
            P3_Avg_Kill_Text.Text = "Text";
            P3_Avg_Kill_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label162
            // 
            label162.AutoSize = true;
            label162.Font = new Font("Maplestory", 8.999999F);
            label162.Location = new Point(206, 144);
            label162.Name = "label162";
            label162.Size = new Size(53, 13);
            label162.TabIndex = 9;
            label162.Text = "평균 어시";
            // 
            // label163
            // 
            label163.AutoSize = true;
            label163.Font = new Font("Maplestory", 8.999999F);
            label163.Location = new Point(206, 104);
            label163.Name = "label163";
            label163.Size = new Size(41, 13);
            label163.TabIndex = 8;
            label163.Text = "평균 킬";
            // 
            // label164
            // 
            label164.AutoSize = true;
            label164.Font = new Font("Maplestory", 8.999999F);
            label164.Location = new Point(206, 65);
            label164.Name = "label164";
            label164.Size = new Size(46, 13);
            label164.TabIndex = 7;
            label164.Text = "평균 TK";
            // 
            // P3_RP_Calc
            // 
            P3_RP_Calc.AutoSize = true;
            P3_RP_Calc.Font = new Font("Maplestory", 8.999999F);
            P3_RP_Calc.Location = new Point(116, 41);
            P3_RP_Calc.Name = "P3_RP_Calc";
            P3_RP_Calc.Size = new Size(33, 13);
            P3_RP_Calc.TabIndex = 21;
            P3_RP_Calc.Text = "Text";
            // 
            // Player3_Text
            // 
            Player3_Text.AutoSize = true;
            Player3_Text.Font = new Font("Maplestory", 9.75F);
            Player3_Text.Location = new Point(85, 19);
            Player3_Text.Name = "Player3_Text";
            Player3_Text.Size = new Size(57, 14);
            Player3_Text.TabIndex = 20;
            Player3_Text.Text = "Player3";
            // 
            // label167
            // 
            label167.AutoSize = true;
            label167.Font = new Font("Maplestory", 9.75F);
            label167.Location = new Point(18, 19);
            label167.Name = "label167";
            label167.Size = new Size(75, 14);
            label167.TabIndex = 19;
            label167.Text = "NickName :";
            // 
            // P3_Avg_Rank_Text
            // 
            P3_Avg_Rank_Text.AutoSize = true;
            P3_Avg_Rank_Text.Font = new Font("Maplestory", 8.999999F);
            P3_Avg_Rank_Text.Location = new Point(105, 161);
            P3_Avg_Rank_Text.Name = "P3_Avg_Rank_Text";
            P3_Avg_Rank_Text.Size = new Size(33, 13);
            P3_Avg_Rank_Text.TabIndex = 16;
            P3_Avg_Rank_Text.Text = "Text";
            P3_Avg_Rank_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P3_Avg_Dmg_Text
            // 
            P3_Avg_Dmg_Text.AutoSize = true;
            P3_Avg_Dmg_Text.Font = new Font("Maplestory", 8.999999F);
            P3_Avg_Dmg_Text.Location = new Point(105, 121);
            P3_Avg_Dmg_Text.Name = "P3_Avg_Dmg_Text";
            P3_Avg_Dmg_Text.Size = new Size(33, 13);
            P3_Avg_Dmg_Text.TabIndex = 15;
            P3_Avg_Dmg_Text.Text = "Text";
            P3_Avg_Dmg_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P3_totalGame_Text
            // 
            P3_totalGame_Text.AutoSize = true;
            P3_totalGame_Text.Font = new Font("Maplestory", 8.999999F);
            P3_totalGame_Text.Location = new Point(105, 82);
            P3_totalGame_Text.Name = "P3_totalGame_Text";
            P3_totalGame_Text.Size = new Size(33, 13);
            P3_totalGame_Text.TabIndex = 14;
            P3_totalGame_Text.Text = "Text";
            P3_totalGame_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P3_Top3_Text
            // 
            P3_Top3_Text.AutoSize = true;
            P3_Top3_Text.Font = new Font("Maplestory", 8.999999F);
            P3_Top3_Text.Location = new Point(17, 161);
            P3_Top3_Text.Name = "P3_Top3_Text";
            P3_Top3_Text.Size = new Size(33, 13);
            P3_Top3_Text.TabIndex = 13;
            P3_Top3_Text.Text = "Text";
            P3_Top3_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P3_Top2_Text
            // 
            P3_Top2_Text.AutoSize = true;
            P3_Top2_Text.Font = new Font("Maplestory", 8.999999F);
            P3_Top2_Text.Location = new Point(17, 121);
            P3_Top2_Text.Name = "P3_Top2_Text";
            P3_Top2_Text.Size = new Size(33, 13);
            P3_Top2_Text.TabIndex = 12;
            P3_Top2_Text.Text = "Text";
            P3_Top2_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P3_WinRate_Text
            // 
            P3_WinRate_Text.AutoSize = true;
            P3_WinRate_Text.Font = new Font("Maplestory", 8.999999F);
            P3_WinRate_Text.Location = new Point(17, 82);
            P3_WinRate_Text.Name = "P3_WinRate_Text";
            P3_WinRate_Text.Size = new Size(33, 13);
            P3_WinRate_Text.TabIndex = 11;
            P3_WinRate_Text.Text = "Text";
            P3_WinRate_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P3_RP_Text
            // 
            P3_RP_Text.AutoSize = true;
            P3_RP_Text.Font = new Font("Maplestory", 8.999999F);
            P3_RP_Text.Location = new Point(68, 41);
            P3_RP_Text.Name = "P3_RP_Text";
            P3_RP_Text.Size = new Size(33, 13);
            P3_RP_Text.TabIndex = 10;
            P3_RP_Text.Text = "Text";
            // 
            // label175
            // 
            label175.AutoSize = true;
            label175.Font = new Font("Maplestory", 8.999999F);
            label175.Location = new Point(105, 144);
            label175.Name = "label175";
            label175.Size = new Size(52, 13);
            label175.TabIndex = 6;
            label175.Text = "평균 순위";
            // 
            // label176
            // 
            label176.AutoSize = true;
            label176.Font = new Font("Maplestory", 8.999999F);
            label176.Location = new Point(105, 104);
            label176.Name = "label176";
            label176.Size = new Size(53, 13);
            label176.TabIndex = 5;
            label176.Text = "평균 딜량";
            // 
            // label177
            // 
            label177.AutoSize = true;
            label177.Font = new Font("Maplestory", 8.999999F);
            label177.Location = new Point(105, 65);
            label177.Name = "label177";
            label177.Size = new Size(41, 13);
            label177.TabIndex = 4;
            label177.Text = "게임 수";
            // 
            // label178
            // 
            label178.AutoSize = true;
            label178.Font = new Font("Maplestory", 8.999999F);
            label178.Location = new Point(17, 144);
            label178.Name = "label178";
            label178.Size = new Size(38, 13);
            label178.TabIndex = 3;
            label178.Text = "Top 3";
            // 
            // label179
            // 
            label179.AutoSize = true;
            label179.Font = new Font("Maplestory", 8.999999F);
            label179.Location = new Point(17, 104);
            label179.Name = "label179";
            label179.Size = new Size(38, 13);
            label179.TabIndex = 2;
            label179.Text = "Top 2";
            // 
            // label180
            // 
            label180.AutoSize = true;
            label180.Font = new Font("Maplestory", 8.999999F);
            label180.Location = new Point(17, 65);
            label180.Name = "label180";
            label180.Size = new Size(27, 13);
            label180.TabIndex = 1;
            label180.Text = "승률";
            // 
            // label181
            // 
            label181.AutoSize = true;
            label181.Font = new Font("Maplestory", 8.999999F);
            label181.Location = new Point(43, 41);
            label181.Name = "label181";
            label181.Size = new Size(29, 13);
            label181.TabIndex = 0;
            label181.Text = "RP :";
            // 
            // Process_Text
            // 
            Process_Text.AutoSize = true;
            Process_Text.Font = new Font("Maplestory", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Process_Text.Location = new Point(112, 13);
            Process_Text.Name = "Process_Text";
            Process_Text.Size = new Size(208, 13);
            Process_Text.TabIndex = 79;
            Process_Text.Text = "Ethernal_Return_Match_Searcher";
            Process_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(864, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 80;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 524);
            Controls.Add(pictureBox1);
            Controls.Add(Process_Text);
            Controls.Add(groupBox8);
            Controls.Add(groupBox4);
            Controls.Add(button1);
            Controls.Add(Player1_GroupBox);
            Controls.Add(Btn_Search);
            Controls.Add(Input_nick);
            Controls.Add(TextLabel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "Ethernal Return: Match Searcher";
            Player1_GroupBox.ResumeLayout(false);
            Player1_GroupBox.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TextLabel1;
        private TextBox Input_nick;
        private Button Btn_Search;
        private GroupBox groupBox3;
        private Label P1_RP;
        public GroupBox Player1_GroupBox;
        private Label P1_Avg_Assist;
        private Label P1_Avg_Kill;
        private Label P1_Avg_TK;
        private Label P1_Avg_Rank;
        private Label P1_Avg_Dmg;
        private Label P1_totalGame;
        private Label P1_Top3;
        private Label P1_Top2;
        private Label P1_WinRate;
        public Label P1_Avg_Assist_Text;
        public Label P1_Avg_TK_Text;
        public Label P1_Avg_Kill_Text;
        public Label P1_Avg_Rank_Text;
        public Label P1_Avg_Dmg_Text;
        public Label P1_totalGame_Text;
        public Label P1_Top3_Text;
        public Label P1_Top2_Text;
        public Label P1_WinRate_Text;
        public Label P1_RP_Text;
        private Label Player1;
        public Label Player1_Text;
        private Button button1;
        public Label P1_RP_Calc;
        private Label label2;
        public Label P1_M1_CharacterCode;
        private Label label1;
        public Label P1_M1_totalGames;
        public Label P1_M1_maxKill;
        private Label label7;
        private Label label10;
        public Label P1_M1_Top3;
        private Label label8;
        public Label P1_M1_WinRate;
        private Label label15;
        public Label P1_M1_Top3Rate;
        private Label label24;
        private Label label11;
        public Label P1_M1_wins;
        public Label P1_M3_WinRate;
        private Label label51;
        public Label P1_M3_Top3Rate;
        private Label label53;
        private Label label55;
        public Label P1_M3_wins;
        private Label label57;
        public Label P1_M3_Top3;
        private Label label59;
        public Label P1_M3_maxKill;
        private Label label61;
        public Label P1_M3_totalGames;
        private Label label65;
        public Label P1_M3_CharacterCode;
        private Label label67;
        public Label P1_M2_WinRate;
        private Label label13;
        public Label P1_M2_Top3Rate;
        private Label label16;
        private Label label26;
        public Label P1_M2_wins;
        private Label label31;
        public Label P1_M2_Top3;
        private Label label34;
        public Label P1_M2_maxKill;
        private Label label36;
        public Label P1_M2_totalGames;
        private Label label47;
        public Label P1_M2_CharacterCode;
        private Label label49;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        public GroupBox groupBox4;
        private GroupBox groupBox5;
        public Label P2_M3_totalGames;
        private Label label5;
        public Label P2_M3_WinRate;
        private Label label9;
        private Label label12;
        public Label P2_M3_Top3Rate;
        private Label label19;
        public Label P2_M3_maxKill;
        private Label label22;
        private Label label23;
        public Label P3_M3_totalGames;
        private Label label28;
        private Label label29;
        public Label P3_M3_wins;
        private GroupBox groupBox6;
        public Label P3_M3_maxKill;
        private Label label33;
        public Label P2_M2_CharacterCode;
        private Label label37;
        public Label P2_M2_totalGames;
        private Label label42;
        public Label P2_M2_maxKill;
        private Label label44;
        public Label P2_M2_Top3;
        private Label label46;
        public Label P2_M2_wins;
        private Label label50;
        private Label label54;
        public Label label56;
        private Label label58;
        private GroupBox groupBox7;
        private Label label60;
        public Label P2_M1_CharacterCode;
        private Label label64;
        public Label P2_M1_totalGames;
        private Label label70;
        public Label P2_M1_maxKill;
        private Label label72;
        public Label P2_M1_Top3;
        private Label label74;
        public Label P2_M1_wins;
        private Label label76;
        private Label label78;
        public Label P2_M1_Top3Rate;
        private Label label80;
        public Label P2_M1_WinRate;
        public Label P2_Avg_Assist_Text;
        public Label P2_Avg_TK_Text;
        public Label P2_Avg_Kill_Text;
        private Label label85;
        private Label label86;
        private Label label87;
        public Label P2_RP_Calc;
        public Label Player2_Text;
        private Label label90;
        public Label P2_Avg_Rank_Text;
        public Label P2_Avg_Dmg_Text;
        public Label P2_totalGame_Text;
        public Label P2_Top3_Text;
        public Label P2_Top2_Text;
        public Label P2_WinRate_Text;
        public Label P2_RP_Text;
        private Label label98;
        private Label label99;
        private Label label100;
        private Label label101;
        private Label label102;
        private Label label103;
        private Label label104;
        public GroupBox groupBox8;
        private GroupBox groupBox9;
        public Label label105;
        private Label label106;
        public Label P3_M3_WinRate;
        private Label label108;
        private Label label109;
        public Label label110;
        public Label P3_M3_Top3Rate;
        private Label label113;
        public Label label114;
        private Label label116;
        private Label label117;
        public Label label118;
        public Label label119;
        private Label label120;
        private Label label121;
        public Label label122;
        private GroupBox groupBox10;
        public Label label123;
        private Label label124;
        public Label P3_M2_CharacterCode;
        private Label label126;
        public Label P3_M2_totalGames;
        private Label label130;
        public Label P3_M2_maxKill;
        private Label label132;
        public Label P3_M2_Top3;
        private Label label134;
        public Label P3_M2_wins;
        private Label label136;
        private Label label138;
        public Label P3_M2_Top3Rate;
        private Label label140;
        private GroupBox groupBox11;
        private Label label141;
        public Label P3_M1_CharacterCode;
        private Label label143;
        public Label P3_M1_totalGames;
        private Label label147;
        public Label P3_M1_maxKill;
        private Label label149;
        public Label P3_M1_Top3;
        private Label label151;
        public Label P3_M1_wins;
        private Label label153;
        private Label label155;
        public Label P3_M1_Top3Rate;
        private Label label157;
        public Label P3_M1_WinRate;
        public Label P3_Avg_Assist_Text;
        public Label P3_Avg_TK_Text;
        public Label P3_Avg_Kill_Text;
        private Label label162;
        private Label label163;
        private Label label164;
        public Label P3_RP_Calc;
        public Label Player3_Text;
        private Label label167;
        public Label P3_Avg_Rank_Text;
        public Label P3_Avg_Dmg_Text;
        public Label P3_totalGame_Text;
        public Label P3_Top3_Text;
        public Label P3_Top2_Text;
        public Label P3_WinRate_Text;
        public Label P3_RP_Text;
        private Label label175;
        private Label label176;
        private Label label177;
        private Label label178;
        private Label label179;
        private Label label180;
        private Label label181;
        public Label P1_M1_AvgRank;
        public Label P1_M3_AvgRank;
        public Label P1_M2_AvgRank;
        public Label P2_M3_AvgRank;
        public Label P2_M2_AvgRank;
        public Label P2_M1_AvgRank;
        public Label P3_M3_AvgRank;
        public Label P3_M2_AvgRank;
        public Label P3_M1_AvgRank;
        public Label P2_M2_Top3Rate;
        public Label P2_M2_WinRate;
        public Label P3_M2_WinRate;
        public Label P2_M3_wins;
        public Label P2_M3_Top3;
        public Label P3_M3_Top3;
        public Label P2_M3_CharacterCode;
        public Label P3_M3_CharacterCode;
        private PictureBox pictureBox1;
        public Label Process_Text;
    }
}
