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
            TextLabel1 = new Label();
            Input_nick = new TextBox();
            Btn_Search = new Button();
            Player1_GroupBox = new GroupBox();
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
            Player2_GroupBox = new GroupBox();
            P2_Avg_Assist_Text = new Label();
            P2_RP_Calc = new Label();
            P2_Avg_TK_Text = new Label();
            label23 = new Label();
            P2_Avg_Kill_Text = new Label();
            label22 = new Label();
            label4 = new Label();
            label21 = new Label();
            label5 = new Label();
            label20 = new Label();
            label6 = new Label();
            label19 = new Label();
            label18 = new Label();
            Player2_Text = new Label();
            label17 = new Label();
            label9 = new Label();
            P2_RP_Text = new Label();
            P2_Avg_Rank_Text = new Label();
            P2_WinRate_Text = new Label();
            P2_Avg_Dmg_Text = new Label();
            P2_Top2_Text = new Label();
            P2_totalGame_Text = new Label();
            P2_Top3_Text = new Label();
            Player3_GroupBox = new GroupBox();
            P3_Avg_Assist_Text = new Label();
            Player3_Text = new Label();
            P3_Avg_TK_Text = new Label();
            label46 = new Label();
            P3_Avg_Kill_Text = new Label();
            label45 = new Label();
            label27 = new Label();
            label44 = new Label();
            label28 = new Label();
            label43 = new Label();
            label29 = new Label();
            label42 = new Label();
            P3_RP_Calc = new Label();
            label41 = new Label();
            label40 = new Label();
            label32 = new Label();
            P3_RP_Text = new Label();
            P3_Avg_Rank_Text = new Label();
            P3_WinRate_Text = new Label();
            P3_Avg_Dmg_Text = new Label();
            P3_Top2_Text = new Label();
            P3_totalGame_Text = new Label();
            P3_Top3_Text = new Label();
            button1 = new Button();
            Player1_GroupBox.SuspendLayout();
            Player2_GroupBox.SuspendLayout();
            Player3_GroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // TextLabel1
            // 
            TextLabel1.AutoSize = true;
            TextLabel1.Font = new Font("Maplestory", 9F, FontStyle.Bold);
            TextLabel1.Location = new Point(66, 13);
            TextLabel1.Name = "TextLabel1";
            TextLabel1.Size = new Size(76, 13);
            TextLabel1.TabIndex = 0;
            TextLabel1.Text = "개인 유저 검색";
            // 
            // Input_nick
            // 
            Input_nick.Font = new Font("Maplestory", 9F);
            Input_nick.Location = new Point(148, 9);
            Input_nick.Name = "Input_nick";
            Input_nick.Size = new Size(100, 21);
            Input_nick.TabIndex = 1;
            Input_nick.TextChanged += txtbox_TextChanged;
            // 
            // Btn_Search
            // 
            Btn_Search.Font = new Font("Maplestory", 9F);
            Btn_Search.Location = new Point(254, 8);
            Btn_Search.Name = "Btn_Search";
            Btn_Search.Size = new Size(75, 23);
            Btn_Search.TabIndex = 2;
            Btn_Search.Text = "Search";
            Btn_Search.UseVisualStyleBackColor = true;
            Btn_Search.Click += SearchBtn_Click;
            // 
            // Player1_GroupBox
            // 
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
            Player1_GroupBox.Location = new Point(8, 37);
            Player1_GroupBox.Name = "Player1_GroupBox";
            Player1_GroupBox.Size = new Size(256, 401);
            Player1_GroupBox.TabIndex = 3;
            Player1_GroupBox.TabStop = false;
            // 
            // P1_Avg_Assist_Text
            // 
            P1_Avg_Assist_Text.AutoSize = true;
            P1_Avg_Assist_Text.Location = new Point(181, 160);
            P1_Avg_Assist_Text.Name = "P1_Avg_Assist_Text";
            P1_Avg_Assist_Text.Size = new Size(29, 15);
            P1_Avg_Assist_Text.TabIndex = 18;
            P1_Avg_Assist_Text.Text = "Text";
            P1_Avg_Assist_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P1_Avg_TK_Text
            // 
            P1_Avg_TK_Text.AutoSize = true;
            P1_Avg_TK_Text.Location = new Point(181, 82);
            P1_Avg_TK_Text.Name = "P1_Avg_TK_Text";
            P1_Avg_TK_Text.Size = new Size(29, 15);
            P1_Avg_TK_Text.TabIndex = 17;
            P1_Avg_TK_Text.Text = "Text";
            P1_Avg_TK_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P1_Avg_Kill_Text
            // 
            P1_Avg_Kill_Text.AutoSize = true;
            P1_Avg_Kill_Text.Location = new Point(181, 121);
            P1_Avg_Kill_Text.Name = "P1_Avg_Kill_Text";
            P1_Avg_Kill_Text.Size = new Size(29, 15);
            P1_Avg_Kill_Text.TabIndex = 17;
            P1_Avg_Kill_Text.Text = "Text";
            P1_Avg_Kill_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P1_Avg_Assist
            // 
            P1_Avg_Assist.AutoSize = true;
            P1_Avg_Assist.Location = new Point(181, 143);
            P1_Avg_Assist.Name = "P1_Avg_Assist";
            P1_Avg_Assist.Size = new Size(59, 15);
            P1_Avg_Assist.TabIndex = 9;
            P1_Avg_Assist.Text = "평균 어시";
            // 
            // P1_Avg_Kill
            // 
            P1_Avg_Kill.AutoSize = true;
            P1_Avg_Kill.Location = new Point(181, 104);
            P1_Avg_Kill.Name = "P1_Avg_Kill";
            P1_Avg_Kill.Size = new Size(47, 15);
            P1_Avg_Kill.TabIndex = 8;
            P1_Avg_Kill.Text = "평균 킬";
            // 
            // P1_Avg_TK
            // 
            P1_Avg_TK.AutoSize = true;
            P1_Avg_TK.Location = new Point(181, 65);
            P1_Avg_TK.Name = "P1_Avg_TK";
            P1_Avg_TK.Size = new Size(48, 15);
            P1_Avg_TK.TabIndex = 7;
            P1_Avg_TK.Text = "평균 TK";
            // 
            // P1_RP_Calc
            // 
            P1_RP_Calc.AutoSize = true;
            P1_RP_Calc.Location = new Point(116, 41);
            P1_RP_Calc.Name = "P1_RP_Calc";
            P1_RP_Calc.Size = new Size(76, 15);
            P1_RP_Calc.TabIndex = 21;
            P1_RP_Calc.Text = "RP_Calc_Text";
            // 
            // Player1_Text
            // 
            Player1_Text.AutoSize = true;
            Player1_Text.Location = new Point(68, 19);
            Player1_Text.Name = "Player1_Text";
            Player1_Text.Size = new Size(46, 15);
            Player1_Text.TabIndex = 20;
            Player1_Text.Text = "Player1";
            // 
            // Player1
            // 
            Player1.AutoSize = true;
            Player1.Location = new Point(1, 19);
            Player1.Name = "Player1";
            Player1.Size = new Size(70, 15);
            Player1.TabIndex = 19;
            Player1.Text = "NickName :";
            // 
            // P1_Avg_Rank_Text
            // 
            P1_Avg_Rank_Text.AutoSize = true;
            P1_Avg_Rank_Text.Location = new Point(87, 160);
            P1_Avg_Rank_Text.Name = "P1_Avg_Rank_Text";
            P1_Avg_Rank_Text.Size = new Size(29, 15);
            P1_Avg_Rank_Text.TabIndex = 16;
            P1_Avg_Rank_Text.Text = "Text";
            P1_Avg_Rank_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P1_Avg_Dmg_Text
            // 
            P1_Avg_Dmg_Text.AutoSize = true;
            P1_Avg_Dmg_Text.Location = new Point(87, 121);
            P1_Avg_Dmg_Text.Name = "P1_Avg_Dmg_Text";
            P1_Avg_Dmg_Text.Size = new Size(29, 15);
            P1_Avg_Dmg_Text.TabIndex = 15;
            P1_Avg_Dmg_Text.Text = "Text";
            P1_Avg_Dmg_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P1_totalGame_Text
            // 
            P1_totalGame_Text.AutoSize = true;
            P1_totalGame_Text.Location = new Point(87, 82);
            P1_totalGame_Text.Name = "P1_totalGame_Text";
            P1_totalGame_Text.Size = new Size(29, 15);
            P1_totalGame_Text.TabIndex = 14;
            P1_totalGame_Text.Text = "Text";
            P1_totalGame_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P1_Top3_Text
            // 
            P1_Top3_Text.AutoSize = true;
            P1_Top3_Text.Location = new Point(17, 160);
            P1_Top3_Text.Name = "P1_Top3_Text";
            P1_Top3_Text.Size = new Size(29, 15);
            P1_Top3_Text.TabIndex = 13;
            P1_Top3_Text.Text = "Text";
            P1_Top3_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P1_Top2_Text
            // 
            P1_Top2_Text.AutoSize = true;
            P1_Top2_Text.Location = new Point(17, 121);
            P1_Top2_Text.Name = "P1_Top2_Text";
            P1_Top2_Text.Size = new Size(29, 15);
            P1_Top2_Text.TabIndex = 12;
            P1_Top2_Text.Text = "Text";
            P1_Top2_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P1_WinRate_Text
            // 
            P1_WinRate_Text.AutoSize = true;
            P1_WinRate_Text.Location = new Point(17, 82);
            P1_WinRate_Text.Name = "P1_WinRate_Text";
            P1_WinRate_Text.Size = new Size(29, 15);
            P1_WinRate_Text.TabIndex = 11;
            P1_WinRate_Text.Text = "Text";
            P1_WinRate_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P1_RP_Text
            // 
            P1_RP_Text.AutoSize = true;
            P1_RP_Text.Location = new Point(68, 41);
            P1_RP_Text.Name = "P1_RP_Text";
            P1_RP_Text.Size = new Size(29, 15);
            P1_RP_Text.TabIndex = 10;
            P1_RP_Text.Text = "Text";
            // 
            // P1_Avg_Rank
            // 
            P1_Avg_Rank.AutoSize = true;
            P1_Avg_Rank.Location = new Point(87, 143);
            P1_Avg_Rank.Name = "P1_Avg_Rank";
            P1_Avg_Rank.Size = new Size(59, 15);
            P1_Avg_Rank.TabIndex = 6;
            P1_Avg_Rank.Text = "평균 순위";
            // 
            // P1_Avg_Dmg
            // 
            P1_Avg_Dmg.AutoSize = true;
            P1_Avg_Dmg.Location = new Point(87, 104);
            P1_Avg_Dmg.Name = "P1_Avg_Dmg";
            P1_Avg_Dmg.Size = new Size(59, 15);
            P1_Avg_Dmg.TabIndex = 5;
            P1_Avg_Dmg.Text = "평균 딜량";
            // 
            // P1_totalGame
            // 
            P1_totalGame.AutoSize = true;
            P1_totalGame.Location = new Point(87, 65);
            P1_totalGame.Name = "P1_totalGame";
            P1_totalGame.Size = new Size(47, 15);
            P1_totalGame.TabIndex = 4;
            P1_totalGame.Text = "게임 수";
            // 
            // P1_Top3
            // 
            P1_Top3.AutoSize = true;
            P1_Top3.Location = new Point(17, 143);
            P1_Top3.Name = "P1_Top3";
            P1_Top3.Size = new Size(38, 15);
            P1_Top3.TabIndex = 3;
            P1_Top3.Text = "Top 3";
            // 
            // P1_Top2
            // 
            P1_Top2.AutoSize = true;
            P1_Top2.Location = new Point(17, 104);
            P1_Top2.Name = "P1_Top2";
            P1_Top2.Size = new Size(38, 15);
            P1_Top2.TabIndex = 2;
            P1_Top2.Text = "Top 2";
            // 
            // P1_WinRate
            // 
            P1_WinRate.AutoSize = true;
            P1_WinRate.Location = new Point(17, 65);
            P1_WinRate.Name = "P1_WinRate";
            P1_WinRate.Size = new Size(31, 15);
            P1_WinRate.TabIndex = 1;
            P1_WinRate.Text = "승률";
            // 
            // P1_RP
            // 
            P1_RP.AutoSize = true;
            P1_RP.Location = new Point(43, 41);
            P1_RP.Name = "P1_RP";
            P1_RP.Size = new Size(28, 15);
            P1_RP.TabIndex = 0;
            P1_RP.Text = "RP :";
            // 
            // Player2_GroupBox
            // 
            Player2_GroupBox.Controls.Add(P2_Avg_Assist_Text);
            Player2_GroupBox.Controls.Add(P2_RP_Calc);
            Player2_GroupBox.Controls.Add(P2_Avg_TK_Text);
            Player2_GroupBox.Controls.Add(label23);
            Player2_GroupBox.Controls.Add(P2_Avg_Kill_Text);
            Player2_GroupBox.Controls.Add(label22);
            Player2_GroupBox.Controls.Add(label4);
            Player2_GroupBox.Controls.Add(label21);
            Player2_GroupBox.Controls.Add(label5);
            Player2_GroupBox.Controls.Add(label20);
            Player2_GroupBox.Controls.Add(label6);
            Player2_GroupBox.Controls.Add(label19);
            Player2_GroupBox.Controls.Add(label18);
            Player2_GroupBox.Controls.Add(Player2_Text);
            Player2_GroupBox.Controls.Add(label17);
            Player2_GroupBox.Controls.Add(label9);
            Player2_GroupBox.Controls.Add(P2_RP_Text);
            Player2_GroupBox.Controls.Add(P2_Avg_Rank_Text);
            Player2_GroupBox.Controls.Add(P2_WinRate_Text);
            Player2_GroupBox.Controls.Add(P2_Avg_Dmg_Text);
            Player2_GroupBox.Controls.Add(P2_Top2_Text);
            Player2_GroupBox.Controls.Add(P2_totalGame_Text);
            Player2_GroupBox.Controls.Add(P2_Top3_Text);
            Player2_GroupBox.Location = new Point(270, 37);
            Player2_GroupBox.Name = "Player2_GroupBox";
            Player2_GroupBox.Size = new Size(258, 401);
            Player2_GroupBox.TabIndex = 4;
            Player2_GroupBox.TabStop = false;
            // 
            // P2_Avg_Assist_Text
            // 
            P2_Avg_Assist_Text.AutoSize = true;
            P2_Avg_Assist_Text.Location = new Point(190, 160);
            P2_Avg_Assist_Text.Name = "P2_Avg_Assist_Text";
            P2_Avg_Assist_Text.Size = new Size(29, 15);
            P2_Avg_Assist_Text.TabIndex = 41;
            P2_Avg_Assist_Text.Text = "Text";
            P2_Avg_Assist_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P2_RP_Calc
            // 
            P2_RP_Calc.AutoSize = true;
            P2_RP_Calc.Location = new Point(125, 41);
            P2_RP_Calc.Name = "P2_RP_Calc";
            P2_RP_Calc.Size = new Size(76, 15);
            P2_RP_Calc.TabIndex = 44;
            P2_RP_Calc.Text = "RP_Calc_Text";
            // 
            // P2_Avg_TK_Text
            // 
            P2_Avg_TK_Text.AutoSize = true;
            P2_Avg_TK_Text.Location = new Point(190, 82);
            P2_Avg_TK_Text.Name = "P2_Avg_TK_Text";
            P2_Avg_TK_Text.Size = new Size(29, 15);
            P2_Avg_TK_Text.TabIndex = 40;
            P2_Avg_TK_Text.Text = "Text";
            P2_Avg_TK_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(52, 41);
            label23.Name = "label23";
            label23.Size = new Size(28, 15);
            label23.TabIndex = 22;
            label23.Text = "RP :";
            // 
            // P2_Avg_Kill_Text
            // 
            P2_Avg_Kill_Text.AutoSize = true;
            P2_Avg_Kill_Text.Location = new Point(190, 121);
            P2_Avg_Kill_Text.Name = "P2_Avg_Kill_Text";
            P2_Avg_Kill_Text.Size = new Size(29, 15);
            P2_Avg_Kill_Text.TabIndex = 39;
            P2_Avg_Kill_Text.Text = "Text";
            P2_Avg_Kill_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(26, 65);
            label22.Name = "label22";
            label22.Size = new Size(31, 15);
            label22.TabIndex = 23;
            label22.Text = "승률";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(190, 143);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 31;
            label4.Text = "평균 어시";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(26, 104);
            label21.Name = "label21";
            label21.Size = new Size(38, 15);
            label21.TabIndex = 24;
            label21.Text = "Top 2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(190, 104);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 30;
            label5.Text = "평균 킬";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(26, 143);
            label20.Name = "label20";
            label20.Size = new Size(38, 15);
            label20.TabIndex = 25;
            label20.Text = "Top 3";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(190, 65);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 29;
            label6.Text = "평균 TK";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(96, 65);
            label19.Name = "label19";
            label19.Size = new Size(47, 15);
            label19.TabIndex = 26;
            label19.Text = "게임 수";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(96, 104);
            label18.Name = "label18";
            label18.Size = new Size(59, 15);
            label18.TabIndex = 27;
            label18.Text = "평균 딜량";
            // 
            // Player2_Text
            // 
            Player2_Text.AutoSize = true;
            Player2_Text.Location = new Point(77, 19);
            Player2_Text.Name = "Player2_Text";
            Player2_Text.Size = new Size(46, 15);
            Player2_Text.TabIndex = 43;
            Player2_Text.Text = "Player2";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(96, 143);
            label17.Name = "label17";
            label17.Size = new Size(59, 15);
            label17.TabIndex = 28;
            label17.Text = "평균 순위";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 19);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 42;
            label9.Text = "NickName :";
            // 
            // P2_RP_Text
            // 
            P2_RP_Text.AutoSize = true;
            P2_RP_Text.Location = new Point(77, 41);
            P2_RP_Text.Name = "P2_RP_Text";
            P2_RP_Text.Size = new Size(29, 15);
            P2_RP_Text.TabIndex = 32;
            P2_RP_Text.Text = "Text";
            // 
            // P2_Avg_Rank_Text
            // 
            P2_Avg_Rank_Text.AutoSize = true;
            P2_Avg_Rank_Text.Location = new Point(96, 160);
            P2_Avg_Rank_Text.Name = "P2_Avg_Rank_Text";
            P2_Avg_Rank_Text.Size = new Size(29, 15);
            P2_Avg_Rank_Text.TabIndex = 38;
            P2_Avg_Rank_Text.Text = "Text";
            P2_Avg_Rank_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P2_WinRate_Text
            // 
            P2_WinRate_Text.AutoSize = true;
            P2_WinRate_Text.Location = new Point(26, 82);
            P2_WinRate_Text.Name = "P2_WinRate_Text";
            P2_WinRate_Text.Size = new Size(29, 15);
            P2_WinRate_Text.TabIndex = 33;
            P2_WinRate_Text.Text = "Text";
            P2_WinRate_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P2_Avg_Dmg_Text
            // 
            P2_Avg_Dmg_Text.AutoSize = true;
            P2_Avg_Dmg_Text.Location = new Point(96, 121);
            P2_Avg_Dmg_Text.Name = "P2_Avg_Dmg_Text";
            P2_Avg_Dmg_Text.Size = new Size(29, 15);
            P2_Avg_Dmg_Text.TabIndex = 37;
            P2_Avg_Dmg_Text.Text = "Text";
            P2_Avg_Dmg_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P2_Top2_Text
            // 
            P2_Top2_Text.AutoSize = true;
            P2_Top2_Text.Location = new Point(26, 121);
            P2_Top2_Text.Name = "P2_Top2_Text";
            P2_Top2_Text.Size = new Size(29, 15);
            P2_Top2_Text.TabIndex = 34;
            P2_Top2_Text.Text = "Text";
            P2_Top2_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P2_totalGame_Text
            // 
            P2_totalGame_Text.AutoSize = true;
            P2_totalGame_Text.Location = new Point(96, 82);
            P2_totalGame_Text.Name = "P2_totalGame_Text";
            P2_totalGame_Text.Size = new Size(29, 15);
            P2_totalGame_Text.TabIndex = 36;
            P2_totalGame_Text.Text = "Text";
            P2_totalGame_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P2_Top3_Text
            // 
            P2_Top3_Text.AutoSize = true;
            P2_Top3_Text.Location = new Point(26, 160);
            P2_Top3_Text.Name = "P2_Top3_Text";
            P2_Top3_Text.Size = new Size(29, 15);
            P2_Top3_Text.TabIndex = 35;
            P2_Top3_Text.Text = "Text";
            P2_Top3_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Player3_GroupBox
            // 
            Player3_GroupBox.Controls.Add(P3_Avg_Assist_Text);
            Player3_GroupBox.Controls.Add(Player3_Text);
            Player3_GroupBox.Controls.Add(P3_Avg_TK_Text);
            Player3_GroupBox.Controls.Add(label46);
            Player3_GroupBox.Controls.Add(P3_Avg_Kill_Text);
            Player3_GroupBox.Controls.Add(label45);
            Player3_GroupBox.Controls.Add(label27);
            Player3_GroupBox.Controls.Add(label44);
            Player3_GroupBox.Controls.Add(label28);
            Player3_GroupBox.Controls.Add(label43);
            Player3_GroupBox.Controls.Add(label29);
            Player3_GroupBox.Controls.Add(label42);
            Player3_GroupBox.Controls.Add(P3_RP_Calc);
            Player3_GroupBox.Controls.Add(label41);
            Player3_GroupBox.Controls.Add(label40);
            Player3_GroupBox.Controls.Add(label32);
            Player3_GroupBox.Controls.Add(P3_RP_Text);
            Player3_GroupBox.Controls.Add(P3_Avg_Rank_Text);
            Player3_GroupBox.Controls.Add(P3_WinRate_Text);
            Player3_GroupBox.Controls.Add(P3_Avg_Dmg_Text);
            Player3_GroupBox.Controls.Add(P3_Top2_Text);
            Player3_GroupBox.Controls.Add(P3_totalGame_Text);
            Player3_GroupBox.Controls.Add(P3_Top3_Text);
            Player3_GroupBox.Location = new Point(530, 37);
            Player3_GroupBox.Name = "Player3_GroupBox";
            Player3_GroupBox.Size = new Size(258, 401);
            Player3_GroupBox.TabIndex = 5;
            Player3_GroupBox.TabStop = false;
            // 
            // P3_Avg_Assist_Text
            // 
            P3_Avg_Assist_Text.AutoSize = true;
            P3_Avg_Assist_Text.Location = new Point(187, 160);
            P3_Avg_Assist_Text.Name = "P3_Avg_Assist_Text";
            P3_Avg_Assist_Text.Size = new Size(29, 15);
            P3_Avg_Assist_Text.TabIndex = 64;
            P3_Avg_Assist_Text.Text = "Text";
            P3_Avg_Assist_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Player3_Text
            // 
            Player3_Text.AutoSize = true;
            Player3_Text.Location = new Point(74, 19);
            Player3_Text.Name = "Player3_Text";
            Player3_Text.Size = new Size(46, 15);
            Player3_Text.TabIndex = 66;
            Player3_Text.Text = "Player1";
            // 
            // P3_Avg_TK_Text
            // 
            P3_Avg_TK_Text.AutoSize = true;
            P3_Avg_TK_Text.Location = new Point(187, 82);
            P3_Avg_TK_Text.Name = "P3_Avg_TK_Text";
            P3_Avg_TK_Text.Size = new Size(29, 15);
            P3_Avg_TK_Text.TabIndex = 63;
            P3_Avg_TK_Text.Text = "Text";
            P3_Avg_TK_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Location = new Point(49, 41);
            label46.Name = "label46";
            label46.Size = new Size(28, 15);
            label46.TabIndex = 45;
            label46.Text = "RP :";
            // 
            // P3_Avg_Kill_Text
            // 
            P3_Avg_Kill_Text.AutoSize = true;
            P3_Avg_Kill_Text.Location = new Point(187, 121);
            P3_Avg_Kill_Text.Name = "P3_Avg_Kill_Text";
            P3_Avg_Kill_Text.Size = new Size(29, 15);
            P3_Avg_Kill_Text.TabIndex = 62;
            P3_Avg_Kill_Text.Text = "Text";
            P3_Avg_Kill_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Location = new Point(23, 65);
            label45.Name = "label45";
            label45.Size = new Size(31, 15);
            label45.TabIndex = 46;
            label45.Text = "승률";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(187, 143);
            label27.Name = "label27";
            label27.Size = new Size(59, 15);
            label27.TabIndex = 54;
            label27.Text = "평균 어시";
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Location = new Point(23, 104);
            label44.Name = "label44";
            label44.Size = new Size(38, 15);
            label44.TabIndex = 47;
            label44.Text = "Top 2";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(187, 104);
            label28.Name = "label28";
            label28.Size = new Size(47, 15);
            label28.TabIndex = 53;
            label28.Text = "평균 킬";
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Location = new Point(23, 143);
            label43.Name = "label43";
            label43.Size = new Size(38, 15);
            label43.TabIndex = 48;
            label43.Text = "Top 3";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(187, 65);
            label29.Name = "label29";
            label29.Size = new Size(48, 15);
            label29.TabIndex = 52;
            label29.Text = "평균 TK";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Location = new Point(93, 65);
            label42.Name = "label42";
            label42.Size = new Size(47, 15);
            label42.TabIndex = 49;
            label42.Text = "게임 수";
            // 
            // P3_RP_Calc
            // 
            P3_RP_Calc.AutoSize = true;
            P3_RP_Calc.Location = new Point(122, 41);
            P3_RP_Calc.Name = "P3_RP_Calc";
            P3_RP_Calc.Size = new Size(76, 15);
            P3_RP_Calc.TabIndex = 67;
            P3_RP_Calc.Text = "RP_Calc_Text";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new Point(93, 104);
            label41.Name = "label41";
            label41.Size = new Size(59, 15);
            label41.TabIndex = 50;
            label41.Text = "평균 딜량";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(93, 143);
            label40.Name = "label40";
            label40.Size = new Size(59, 15);
            label40.TabIndex = 51;
            label40.Text = "평균 순위";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(7, 19);
            label32.Name = "label32";
            label32.Size = new Size(70, 15);
            label32.TabIndex = 65;
            label32.Text = "NickName :";
            // 
            // P3_RP_Text
            // 
            P3_RP_Text.AutoSize = true;
            P3_RP_Text.Location = new Point(74, 41);
            P3_RP_Text.Name = "P3_RP_Text";
            P3_RP_Text.Size = new Size(29, 15);
            P3_RP_Text.TabIndex = 55;
            P3_RP_Text.Text = "Text";
            // 
            // P3_Avg_Rank_Text
            // 
            P3_Avg_Rank_Text.AutoSize = true;
            P3_Avg_Rank_Text.Location = new Point(93, 160);
            P3_Avg_Rank_Text.Name = "P3_Avg_Rank_Text";
            P3_Avg_Rank_Text.Size = new Size(29, 15);
            P3_Avg_Rank_Text.TabIndex = 61;
            P3_Avg_Rank_Text.Text = "Text";
            P3_Avg_Rank_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P3_WinRate_Text
            // 
            P3_WinRate_Text.AutoSize = true;
            P3_WinRate_Text.Location = new Point(23, 82);
            P3_WinRate_Text.Name = "P3_WinRate_Text";
            P3_WinRate_Text.Size = new Size(29, 15);
            P3_WinRate_Text.TabIndex = 56;
            P3_WinRate_Text.Text = "Text";
            P3_WinRate_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P3_Avg_Dmg_Text
            // 
            P3_Avg_Dmg_Text.AutoSize = true;
            P3_Avg_Dmg_Text.Location = new Point(93, 121);
            P3_Avg_Dmg_Text.Name = "P3_Avg_Dmg_Text";
            P3_Avg_Dmg_Text.Size = new Size(29, 15);
            P3_Avg_Dmg_Text.TabIndex = 60;
            P3_Avg_Dmg_Text.Text = "Text";
            P3_Avg_Dmg_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P3_Top2_Text
            // 
            P3_Top2_Text.AutoSize = true;
            P3_Top2_Text.Location = new Point(23, 121);
            P3_Top2_Text.Name = "P3_Top2_Text";
            P3_Top2_Text.Size = new Size(29, 15);
            P3_Top2_Text.TabIndex = 57;
            P3_Top2_Text.Text = "Text";
            P3_Top2_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P3_totalGame_Text
            // 
            P3_totalGame_Text.AutoSize = true;
            P3_totalGame_Text.Location = new Point(93, 82);
            P3_totalGame_Text.Name = "P3_totalGame_Text";
            P3_totalGame_Text.Size = new Size(29, 15);
            P3_totalGame_Text.TabIndex = 59;
            P3_totalGame_Text.Text = "Text";
            P3_totalGame_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P3_Top3_Text
            // 
            P3_Top3_Text.AutoSize = true;
            P3_Top3_Text.Location = new Point(23, 160);
            P3_Top3_Text.Name = "P3_Top3_Text";
            P3_Top3_Text.Size = new Size(29, 15);
            P3_Top3_Text.TabIndex = 58;
            P3_Top3_Text.Text = "Text";
            P3_Top3_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.Font = new Font("Maplestory", 9F);
            button1.Location = new Point(688, 8);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "매치 탐색";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Player3_GroupBox);
            Controls.Add(Player2_GroupBox);
            Controls.Add(Player1_GroupBox);
            Controls.Add(Btn_Search);
            Controls.Add(Input_nick);
            Controls.Add(TextLabel1);
            Name = "MainForm";
            Text = "Ethernal Return: Match Seacher";
            Load += Form1_Load;
            Player1_GroupBox.ResumeLayout(false);
            Player1_GroupBox.PerformLayout();
            Player2_GroupBox.ResumeLayout(false);
            Player2_GroupBox.PerformLayout();
            Player3_GroupBox.ResumeLayout(false);
            Player3_GroupBox.PerformLayout();
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
        private GroupBox Player2_GroupBox;
        private GroupBox Player3_GroupBox;
        private Button button1;
        public Label P1_RP_Calc;
        public Label P2_Avg_Assist_Text;
        public Label P2_RP_Calc;
        public Label P2_Avg_TK_Text;
        private Label label23;
        public Label P2_Avg_Kill_Text;
        private Label label22;
        private Label label4;
        private Label label21;
        private Label label5;
        private Label label20;
        private Label label6;
        private Label label19;
        private Label label18;
        public Label Player2_Text;
        private Label label17;
        private Label label9;
        public Label P2_RP_Text;
        public Label P2_Avg_Rank_Text;
        public Label P2_WinRate_Text;
        public Label P2_Avg_Dmg_Text;
        public Label P2_Top2_Text;
        public Label P2_totalGame_Text;
        public Label P2_Top3_Text;
        public Label P3_Avg_Assist_Text;
        public Label Player3_Text;
        public Label P3_Avg_TK_Text;
        private Label label46;
        public Label P3_Avg_Kill_Text;
        private Label label45;
        private Label label27;
        private Label label44;
        private Label label28;
        private Label label43;
        private Label label29;
        private Label label42;
        public Label P3_RP_Calc;
        private Label label41;
        private Label label40;
        private Label label32;
        public Label P3_RP_Text;
        public Label P3_Avg_Rank_Text;
        public Label P3_WinRate_Text;
        public Label P3_Avg_Dmg_Text;
        public Label P3_Top2_Text;
        public Label P3_totalGame_Text;
        public Label P3_Top3_Text;
    }
}
