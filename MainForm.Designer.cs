namespace Ethernal_Return_Match_Seacher
{
    partial class MainForm
    {
        public delegate void OnClickDelegate(string _name);
        private OnClickDelegate onClickCallback;
        public OnClickDelegate OnClickCallback { set { onClickCallback = value; } }

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
            RP_Calc = new Label();
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
            Player2_Text = new Label();
            Player2 = new Label();
            P2_Avg_Assist_Text = new Label();
            P2_Avg_TK_Text = new Label();
            P2_Avg_Kill_Text = new Label();
            P2_Avg_Rank_Text = new Label();
            P2_Avg_Dmg_Text = new Label();
            P2_totalGame_Text = new Label();
            P2_Top3_Text = new Label();
            P2_Top2_Text = new Label();
            P2_WinRate_Text = new Label();
            P2_RP_Text = new Label();
            P2_Avg_Assist = new Label();
            P2_Avg_Kill = new Label();
            P2_Avg_TK = new Label();
            P2_Avg_Rank = new Label();
            P2_Avg_Dmg = new Label();
            P2_totalGame = new Label();
            P2_Top3 = new Label();
            P2_Top2 = new Label();
            P2_WinRate = new Label();
            P2_RP = new Label();
            Player3_GroupBox = new GroupBox();
            Player3_Text = new Label();
            Player3 = new Label();
            P3_Avg_Assist_Text = new Label();
            P3_Avg_TK_Text = new Label();
            P3_Avg_Kill_Text = new Label();
            P3_Avg_Rank_Text = new Label();
            P3_Avg_Dmg_Text = new Label();
            P3_totalGame_Text = new Label();
            P3_Top3_Text = new Label();
            P3_Top2_Text = new Label();
            P3_WinRate_Text = new Label();
            P3_RP_Text = new Label();
            P3_Avg_Assist = new Label();
            P3_Avg_Kill = new Label();
            P3_Avg_TK = new Label();
            P3_Avg_Rank = new Label();
            P3_Avg_Dmg = new Label();
            P3_totalGame = new Label();
            P3_Top3 = new Label();
            P3_Top2 = new Label();
            P3_WinRate = new Label();
            P3_RP = new Label();
            Player1_GroupBox.SuspendLayout();
            Player2_GroupBox.SuspendLayout();
            Player3_GroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // TextLabel1
            // 
            TextLabel1.AutoSize = true;
            TextLabel1.Font = new Font("Maplestory", 9F, FontStyle.Bold);
            TextLabel1.Location = new Point(41, 16);
            TextLabel1.Name = "TextLabel1";
            TextLabel1.Size = new Size(101, 13);
            TextLabel1.TabIndex = 0;
            TextLabel1.Text = "Input NickName";
            // 
            // Input_nick
            // 
            Input_nick.Font = new Font("Maplestory", 9F);
            Input_nick.Location = new Point(148, 11);
            Input_nick.Name = "Input_nick";
            Input_nick.Size = new Size(100, 21);
            Input_nick.TabIndex = 1;
            Input_nick.TextChanged += txtbox_TextChanged;
            // 
            // Btn_Search
            // 
            Btn_Search.Font = new Font("Maplestory", 9F);
            Btn_Search.Location = new Point(254, 11);
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
            Player1_GroupBox.Controls.Add(RP_Calc);
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
            Player1_GroupBox.Location = new Point(8, 46);
            Player1_GroupBox.Name = "Player1_GroupBox";
            Player1_GroupBox.Size = new Size(256, 392);
            Player1_GroupBox.TabIndex = 3;
            Player1_GroupBox.TabStop = false;
            // 
            // P1_Avg_Assist_Text
            // 
            P1_Avg_Assist_Text.AutoSize = true;
            P1_Avg_Assist_Text.Location = new Point(181, 150);
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
            P1_Avg_Kill_Text.Location = new Point(181, 116);
            P1_Avg_Kill_Text.Name = "P1_Avg_Kill_Text";
            P1_Avg_Kill_Text.Size = new Size(29, 15);
            P1_Avg_Kill_Text.TabIndex = 17;
            P1_Avg_Kill_Text.Text = "Text";
            P1_Avg_Kill_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P1_Avg_Assist
            // 
            P1_Avg_Assist.AutoSize = true;
            P1_Avg_Assist.Location = new Point(181, 133);
            P1_Avg_Assist.Name = "P1_Avg_Assist";
            P1_Avg_Assist.Size = new Size(59, 15);
            P1_Avg_Assist.TabIndex = 9;
            P1_Avg_Assist.Text = "평균 어시";
            // 
            // P1_Avg_Kill
            // 
            P1_Avg_Kill.AutoSize = true;
            P1_Avg_Kill.Location = new Point(181, 99);
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
            // RP_Calc
            // 
            RP_Calc.AutoSize = true;
            RP_Calc.Location = new Point(116, 38);
            RP_Calc.Name = "RP_Calc";
            RP_Calc.Size = new Size(76, 15);
            RP_Calc.TabIndex = 21;
            RP_Calc.Text = "RP_Calc_Text";
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
            P1_Avg_Rank_Text.Location = new Point(87, 150);
            P1_Avg_Rank_Text.Name = "P1_Avg_Rank_Text";
            P1_Avg_Rank_Text.Size = new Size(29, 15);
            P1_Avg_Rank_Text.TabIndex = 16;
            P1_Avg_Rank_Text.Text = "Text";
            P1_Avg_Rank_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P1_Avg_Dmg_Text
            // 
            P1_Avg_Dmg_Text.AutoSize = true;
            P1_Avg_Dmg_Text.Location = new Point(87, 116);
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
            P1_Top3_Text.Location = new Point(17, 150);
            P1_Top3_Text.Name = "P1_Top3_Text";
            P1_Top3_Text.Size = new Size(29, 15);
            P1_Top3_Text.TabIndex = 13;
            P1_Top3_Text.Text = "Text";
            P1_Top3_Text.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // P1_Top2_Text
            // 
            P1_Top2_Text.AutoSize = true;
            P1_Top2_Text.Location = new Point(17, 116);
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
            P1_RP_Text.Location = new Point(68, 38);
            P1_RP_Text.Name = "P1_RP_Text";
            P1_RP_Text.Size = new Size(29, 15);
            P1_RP_Text.TabIndex = 10;
            P1_RP_Text.Text = "Text";
            // 
            // P1_Avg_Rank
            // 
            P1_Avg_Rank.AutoSize = true;
            P1_Avg_Rank.Location = new Point(87, 133);
            P1_Avg_Rank.Name = "P1_Avg_Rank";
            P1_Avg_Rank.Size = new Size(59, 15);
            P1_Avg_Rank.TabIndex = 6;
            P1_Avg_Rank.Text = "평균 순위";
            // 
            // P1_Avg_Dmg
            // 
            P1_Avg_Dmg.AutoSize = true;
            P1_Avg_Dmg.Location = new Point(87, 99);
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
            P1_Top3.Location = new Point(17, 133);
            P1_Top3.Name = "P1_Top3";
            P1_Top3.Size = new Size(38, 15);
            P1_Top3.TabIndex = 3;
            P1_Top3.Text = "Top 3";
            // 
            // P1_Top2
            // 
            P1_Top2.AutoSize = true;
            P1_Top2.Location = new Point(17, 99);
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
            P1_RP.Location = new Point(43, 38);
            P1_RP.Name = "P1_RP";
            P1_RP.Size = new Size(28, 15);
            P1_RP.TabIndex = 0;
            P1_RP.Text = "RP :";
            // 
            // Player2_GroupBox
            // 
            Player2_GroupBox.Controls.Add(Player2_Text);
            Player2_GroupBox.Controls.Add(Player2);
            Player2_GroupBox.Controls.Add(P2_Avg_Assist_Text);
            Player2_GroupBox.Controls.Add(P2_Avg_TK_Text);
            Player2_GroupBox.Controls.Add(P2_Avg_Kill_Text);
            Player2_GroupBox.Controls.Add(P2_Avg_Rank_Text);
            Player2_GroupBox.Controls.Add(P2_Avg_Dmg_Text);
            Player2_GroupBox.Controls.Add(P2_totalGame_Text);
            Player2_GroupBox.Controls.Add(P2_Top3_Text);
            Player2_GroupBox.Controls.Add(P2_Top2_Text);
            Player2_GroupBox.Controls.Add(P2_WinRate_Text);
            Player2_GroupBox.Controls.Add(P2_RP_Text);
            Player2_GroupBox.Controls.Add(P2_Avg_Assist);
            Player2_GroupBox.Controls.Add(P2_Avg_Kill);
            Player2_GroupBox.Controls.Add(P2_Avg_TK);
            Player2_GroupBox.Controls.Add(P2_Avg_Rank);
            Player2_GroupBox.Controls.Add(P2_Avg_Dmg);
            Player2_GroupBox.Controls.Add(P2_totalGame);
            Player2_GroupBox.Controls.Add(P2_Top3);
            Player2_GroupBox.Controls.Add(P2_Top2);
            Player2_GroupBox.Controls.Add(P2_WinRate);
            Player2_GroupBox.Controls.Add(P2_RP);
            Player2_GroupBox.Location = new Point(270, 46);
            Player2_GroupBox.Name = "Player2_GroupBox";
            Player2_GroupBox.Size = new Size(258, 392);
            Player2_GroupBox.TabIndex = 4;
            Player2_GroupBox.TabStop = false;
            // 
            // Player2_Text
            // 
            Player2_Text.AutoSize = true;
            Player2_Text.Location = new Point(125, 25);
            Player2_Text.Name = "Player2_Text";
            Player2_Text.Size = new Size(46, 15);
            Player2_Text.TabIndex = 40;
            Player2_Text.Text = "Player2";
            // 
            // Player2
            // 
            Player2.AutoSize = true;
            Player2.Location = new Point(40, 25);
            Player2.Name = "Player2";
            Player2.Size = new Size(70, 15);
            Player2.TabIndex = 39;
            Player2.Text = "NickName :";
            // 
            // P2_Avg_Assist_Text
            // 
            P2_Avg_Assist_Text.AutoSize = true;
            P2_Avg_Assist_Text.Location = new Point(125, 348);
            P2_Avg_Assist_Text.Name = "P2_Avg_Assist_Text";
            P2_Avg_Assist_Text.Size = new Size(109, 15);
            P2_Avg_Assist_Text.TabIndex = 38;
            P2_Avg_Assist_Text.Text = "P2_Avg_Assist_Text";
            // 
            // P2_Avg_TK_Text
            // 
            P2_Avg_TK_Text.AutoSize = true;
            P2_Avg_TK_Text.Location = new Point(125, 278);
            P2_Avg_TK_Text.Name = "P2_Avg_TK_Text";
            P2_Avg_TK_Text.Size = new Size(92, 15);
            P2_Avg_TK_Text.TabIndex = 37;
            P2_Avg_TK_Text.Text = "P2_Avg_TK_Text";
            // 
            // P2_Avg_Kill_Text
            // 
            P2_Avg_Kill_Text.AutoSize = true;
            P2_Avg_Kill_Text.Location = new Point(125, 312);
            P2_Avg_Kill_Text.Name = "P2_Avg_Kill_Text";
            P2_Avg_Kill_Text.Size = new Size(95, 15);
            P2_Avg_Kill_Text.TabIndex = 36;
            P2_Avg_Kill_Text.Text = "P2_Avg_Kill_Text";
            // 
            // P2_Avg_Rank_Text
            // 
            P2_Avg_Rank_Text.AutoSize = true;
            P2_Avg_Rank_Text.Location = new Point(125, 247);
            P2_Avg_Rank_Text.Name = "P2_Avg_Rank_Text";
            P2_Avg_Rank_Text.Size = new Size(105, 15);
            P2_Avg_Rank_Text.TabIndex = 35;
            P2_Avg_Rank_Text.Text = "P2_Avg_Rank_Text";
            // 
            // P2_Avg_Dmg_Text
            // 
            P2_Avg_Dmg_Text.AutoSize = true;
            P2_Avg_Dmg_Text.Location = new Point(125, 215);
            P2_Avg_Dmg_Text.Name = "P2_Avg_Dmg_Text";
            P2_Avg_Dmg_Text.Size = new Size(106, 15);
            P2_Avg_Dmg_Text.TabIndex = 34;
            P2_Avg_Dmg_Text.Text = "P2_Avg_Dmg_Text";
            // 
            // P2_totalGame_Text
            // 
            P2_totalGame_Text.AutoSize = true;
            P2_totalGame_Text.Location = new Point(125, 183);
            P2_totalGame_Text.Name = "P2_totalGame_Text";
            P2_totalGame_Text.Size = new Size(108, 15);
            P2_totalGame_Text.TabIndex = 33;
            P2_totalGame_Text.Text = "P2_totalGame_Text";
            // 
            // P2_Top3_Text
            // 
            P2_Top3_Text.AutoSize = true;
            P2_Top3_Text.Location = new Point(125, 151);
            P2_Top3_Text.Name = "P2_Top3_Text";
            P2_Top3_Text.Size = new Size(80, 15);
            P2_Top3_Text.TabIndex = 32;
            P2_Top3_Text.Text = "P2_Top3_Text";
            // 
            // P2_Top2_Text
            // 
            P2_Top2_Text.AutoSize = true;
            P2_Top2_Text.Location = new Point(125, 115);
            P2_Top2_Text.Name = "P2_Top2_Text";
            P2_Top2_Text.Size = new Size(80, 15);
            P2_Top2_Text.TabIndex = 31;
            P2_Top2_Text.Text = "P2_Top2_Text";
            // 
            // P2_WinRate_Text
            // 
            P2_WinRate_Text.AutoSize = true;
            P2_WinRate_Text.Location = new Point(125, 81);
            P2_WinRate_Text.Name = "P2_WinRate_Text";
            P2_WinRate_Text.Size = new Size(97, 15);
            P2_WinRate_Text.TabIndex = 30;
            P2_WinRate_Text.Text = "P2_WinRate_Text";
            // 
            // P2_RP_Text
            // 
            P2_RP_Text.AutoSize = true;
            P2_RP_Text.Location = new Point(125, 51);
            P2_RP_Text.Name = "P2_RP_Text";
            P2_RP_Text.Size = new Size(67, 15);
            P2_RP_Text.TabIndex = 29;
            P2_RP_Text.Text = "P2_RP_Text";
            // 
            // P2_Avg_Assist
            // 
            P2_Avg_Assist.AutoSize = true;
            P2_Avg_Assist.Location = new Point(44, 348);
            P2_Avg_Assist.Name = "P2_Avg_Assist";
            P2_Avg_Assist.Size = new Size(70, 15);
            P2_Avg_Assist.TabIndex = 28;
            P2_Avg_Assist.Text = "평균 어시 : ";
            // 
            // P2_Avg_Kill
            // 
            P2_Avg_Kill.AutoSize = true;
            P2_Avg_Kill.Location = new Point(55, 312);
            P2_Avg_Kill.Name = "P2_Avg_Kill";
            P2_Avg_Kill.Size = new Size(54, 15);
            P2_Avg_Kill.TabIndex = 27;
            P2_Avg_Kill.Text = "평균 킬 :";
            // 
            // P2_Avg_TK
            // 
            P2_Avg_TK.AutoSize = true;
            P2_Avg_TK.Location = new Point(55, 278);
            P2_Avg_TK.Name = "P2_Avg_TK";
            P2_Avg_TK.Size = new Size(55, 15);
            P2_Avg_TK.TabIndex = 26;
            P2_Avg_TK.Text = "평균 TK :";
            // 
            // P2_Avg_Rank
            // 
            P2_Avg_Rank.AutoSize = true;
            P2_Avg_Rank.Location = new Point(44, 247);
            P2_Avg_Rank.Name = "P2_Avg_Rank";
            P2_Avg_Rank.Size = new Size(66, 15);
            P2_Avg_Rank.TabIndex = 25;
            P2_Avg_Rank.Text = "평균 순위 :";
            // 
            // P2_Avg_Dmg
            // 
            P2_Avg_Dmg.AutoSize = true;
            P2_Avg_Dmg.Location = new Point(44, 215);
            P2_Avg_Dmg.Name = "P2_Avg_Dmg";
            P2_Avg_Dmg.Size = new Size(66, 15);
            P2_Avg_Dmg.TabIndex = 24;
            P2_Avg_Dmg.Text = "평균 딜량 :";
            // 
            // P2_totalGame
            // 
            P2_totalGame.AutoSize = true;
            P2_totalGame.Location = new Point(56, 183);
            P2_totalGame.Name = "P2_totalGame";
            P2_totalGame.Size = new Size(58, 15);
            P2_totalGame.TabIndex = 23;
            P2_totalGame.Text = "게임 수 : ";
            // 
            // P2_Top3
            // 
            P2_Top3.AutoSize = true;
            P2_Top3.Location = new Point(65, 151);
            P2_Top3.Name = "P2_Top3";
            P2_Top3.Size = new Size(49, 15);
            P2_Top3.TabIndex = 22;
            P2_Top3.Text = "Top 3 : ";
            // 
            // P2_Top2
            // 
            P2_Top2.AutoSize = true;
            P2_Top2.Location = new Point(65, 115);
            P2_Top2.Name = "P2_Top2";
            P2_Top2.Size = new Size(49, 15);
            P2_Top2.TabIndex = 21;
            P2_Top2.Text = "Top 2 : ";
            // 
            // P2_WinRate
            // 
            P2_WinRate.AutoSize = true;
            P2_WinRate.Location = new Point(72, 81);
            P2_WinRate.Name = "P2_WinRate";
            P2_WinRate.Size = new Size(38, 15);
            P2_WinRate.TabIndex = 20;
            P2_WinRate.Text = "승률 :";
            // 
            // P2_RP
            // 
            P2_RP.AutoSize = true;
            P2_RP.Location = new Point(82, 51);
            P2_RP.Name = "P2_RP";
            P2_RP.Size = new Size(28, 15);
            P2_RP.TabIndex = 19;
            P2_RP.Text = "RP :";
            // 
            // Player3_GroupBox
            // 
            Player3_GroupBox.Controls.Add(Player3_Text);
            Player3_GroupBox.Controls.Add(Player3);
            Player3_GroupBox.Controls.Add(P3_Avg_Assist_Text);
            Player3_GroupBox.Controls.Add(P3_Avg_TK_Text);
            Player3_GroupBox.Controls.Add(P3_Avg_Kill_Text);
            Player3_GroupBox.Controls.Add(P3_Avg_Rank_Text);
            Player3_GroupBox.Controls.Add(P3_Avg_Dmg_Text);
            Player3_GroupBox.Controls.Add(P3_totalGame_Text);
            Player3_GroupBox.Controls.Add(P3_Top3_Text);
            Player3_GroupBox.Controls.Add(P3_Top2_Text);
            Player3_GroupBox.Controls.Add(P3_WinRate_Text);
            Player3_GroupBox.Controls.Add(P3_RP_Text);
            Player3_GroupBox.Controls.Add(P3_Avg_Assist);
            Player3_GroupBox.Controls.Add(P3_Avg_Kill);
            Player3_GroupBox.Controls.Add(P3_Avg_TK);
            Player3_GroupBox.Controls.Add(P3_Avg_Rank);
            Player3_GroupBox.Controls.Add(P3_Avg_Dmg);
            Player3_GroupBox.Controls.Add(P3_totalGame);
            Player3_GroupBox.Controls.Add(P3_Top3);
            Player3_GroupBox.Controls.Add(P3_Top2);
            Player3_GroupBox.Controls.Add(P3_WinRate);
            Player3_GroupBox.Controls.Add(P3_RP);
            Player3_GroupBox.Location = new Point(530, 46);
            Player3_GroupBox.Name = "Player3_GroupBox";
            Player3_GroupBox.Size = new Size(258, 392);
            Player3_GroupBox.TabIndex = 5;
            Player3_GroupBox.TabStop = false;
            // 
            // Player3_Text
            // 
            Player3_Text.AutoSize = true;
            Player3_Text.Location = new Point(124, 25);
            Player3_Text.Name = "Player3_Text";
            Player3_Text.Size = new Size(46, 15);
            Player3_Text.TabIndex = 42;
            Player3_Text.Text = "Player3";
            // 
            // Player3
            // 
            Player3.AutoSize = true;
            Player3.Location = new Point(39, 25);
            Player3.Name = "Player3";
            Player3.Size = new Size(70, 15);
            Player3.TabIndex = 41;
            Player3.Text = "NickName :";
            // 
            // P3_Avg_Assist_Text
            // 
            P3_Avg_Assist_Text.AutoSize = true;
            P3_Avg_Assist_Text.Location = new Point(124, 348);
            P3_Avg_Assist_Text.Name = "P3_Avg_Assist_Text";
            P3_Avg_Assist_Text.Size = new Size(109, 15);
            P3_Avg_Assist_Text.TabIndex = 58;
            P3_Avg_Assist_Text.Text = "P3_Avg_Assist_Text";
            // 
            // P3_Avg_TK_Text
            // 
            P3_Avg_TK_Text.AutoSize = true;
            P3_Avg_TK_Text.Location = new Point(124, 278);
            P3_Avg_TK_Text.Name = "P3_Avg_TK_Text";
            P3_Avg_TK_Text.Size = new Size(92, 15);
            P3_Avg_TK_Text.TabIndex = 57;
            P3_Avg_TK_Text.Text = "P3_Avg_TK_Text";
            // 
            // P3_Avg_Kill_Text
            // 
            P3_Avg_Kill_Text.AutoSize = true;
            P3_Avg_Kill_Text.Location = new Point(124, 312);
            P3_Avg_Kill_Text.Name = "P3_Avg_Kill_Text";
            P3_Avg_Kill_Text.Size = new Size(95, 15);
            P3_Avg_Kill_Text.TabIndex = 56;
            P3_Avg_Kill_Text.Text = "P3_Avg_Kill_Text";
            // 
            // P3_Avg_Rank_Text
            // 
            P3_Avg_Rank_Text.AutoSize = true;
            P3_Avg_Rank_Text.Location = new Point(124, 247);
            P3_Avg_Rank_Text.Name = "P3_Avg_Rank_Text";
            P3_Avg_Rank_Text.Size = new Size(105, 15);
            P3_Avg_Rank_Text.TabIndex = 55;
            P3_Avg_Rank_Text.Text = "P3_Avg_Rank_Text";
            // 
            // P3_Avg_Dmg_Text
            // 
            P3_Avg_Dmg_Text.AutoSize = true;
            P3_Avg_Dmg_Text.Location = new Point(124, 215);
            P3_Avg_Dmg_Text.Name = "P3_Avg_Dmg_Text";
            P3_Avg_Dmg_Text.Size = new Size(106, 15);
            P3_Avg_Dmg_Text.TabIndex = 54;
            P3_Avg_Dmg_Text.Text = "P3_Avg_Dmg_Text";
            // 
            // P3_totalGame_Text
            // 
            P3_totalGame_Text.AutoSize = true;
            P3_totalGame_Text.Location = new Point(124, 183);
            P3_totalGame_Text.Name = "P3_totalGame_Text";
            P3_totalGame_Text.Size = new Size(108, 15);
            P3_totalGame_Text.TabIndex = 53;
            P3_totalGame_Text.Text = "P3_totalGame_Text";
            // 
            // P3_Top3_Text
            // 
            P3_Top3_Text.AutoSize = true;
            P3_Top3_Text.Location = new Point(124, 151);
            P3_Top3_Text.Name = "P3_Top3_Text";
            P3_Top3_Text.Size = new Size(80, 15);
            P3_Top3_Text.TabIndex = 52;
            P3_Top3_Text.Text = "P3_Top3_Text";
            // 
            // P3_Top2_Text
            // 
            P3_Top2_Text.AutoSize = true;
            P3_Top2_Text.Location = new Point(124, 115);
            P3_Top2_Text.Name = "P3_Top2_Text";
            P3_Top2_Text.Size = new Size(80, 15);
            P3_Top2_Text.TabIndex = 51;
            P3_Top2_Text.Text = "P3_Top2_Text";
            // 
            // P3_WinRate_Text
            // 
            P3_WinRate_Text.AutoSize = true;
            P3_WinRate_Text.Location = new Point(124, 81);
            P3_WinRate_Text.Name = "P3_WinRate_Text";
            P3_WinRate_Text.Size = new Size(97, 15);
            P3_WinRate_Text.TabIndex = 50;
            P3_WinRate_Text.Text = "P3_WinRate_Text";
            // 
            // P3_RP_Text
            // 
            P3_RP_Text.AutoSize = true;
            P3_RP_Text.Location = new Point(124, 51);
            P3_RP_Text.Name = "P3_RP_Text";
            P3_RP_Text.Size = new Size(67, 15);
            P3_RP_Text.TabIndex = 49;
            P3_RP_Text.Text = "P3_RP_Text";
            // 
            // P3_Avg_Assist
            // 
            P3_Avg_Assist.AutoSize = true;
            P3_Avg_Assist.Location = new Point(43, 348);
            P3_Avg_Assist.Name = "P3_Avg_Assist";
            P3_Avg_Assist.Size = new Size(70, 15);
            P3_Avg_Assist.TabIndex = 48;
            P3_Avg_Assist.Text = "평균 어시 : ";
            // 
            // P3_Avg_Kill
            // 
            P3_Avg_Kill.AutoSize = true;
            P3_Avg_Kill.Location = new Point(54, 312);
            P3_Avg_Kill.Name = "P3_Avg_Kill";
            P3_Avg_Kill.Size = new Size(54, 15);
            P3_Avg_Kill.TabIndex = 47;
            P3_Avg_Kill.Text = "평균 킬 :";
            // 
            // P3_Avg_TK
            // 
            P3_Avg_TK.AutoSize = true;
            P3_Avg_TK.Location = new Point(54, 278);
            P3_Avg_TK.Name = "P3_Avg_TK";
            P3_Avg_TK.Size = new Size(55, 15);
            P3_Avg_TK.TabIndex = 46;
            P3_Avg_TK.Text = "평균 TK :";
            // 
            // P3_Avg_Rank
            // 
            P3_Avg_Rank.AutoSize = true;
            P3_Avg_Rank.Location = new Point(43, 247);
            P3_Avg_Rank.Name = "P3_Avg_Rank";
            P3_Avg_Rank.Size = new Size(66, 15);
            P3_Avg_Rank.TabIndex = 45;
            P3_Avg_Rank.Text = "평균 순위 :";
            // 
            // P3_Avg_Dmg
            // 
            P3_Avg_Dmg.AutoSize = true;
            P3_Avg_Dmg.Location = new Point(43, 215);
            P3_Avg_Dmg.Name = "P3_Avg_Dmg";
            P3_Avg_Dmg.Size = new Size(66, 15);
            P3_Avg_Dmg.TabIndex = 44;
            P3_Avg_Dmg.Text = "평균 딜량 :";
            // 
            // P3_totalGame
            // 
            P3_totalGame.AutoSize = true;
            P3_totalGame.Location = new Point(55, 183);
            P3_totalGame.Name = "P3_totalGame";
            P3_totalGame.Size = new Size(58, 15);
            P3_totalGame.TabIndex = 43;
            P3_totalGame.Text = "게임 수 : ";
            // 
            // P3_Top3
            // 
            P3_Top3.AutoSize = true;
            P3_Top3.Location = new Point(64, 151);
            P3_Top3.Name = "P3_Top3";
            P3_Top3.Size = new Size(49, 15);
            P3_Top3.TabIndex = 42;
            P3_Top3.Text = "Top 3 : ";
            // 
            // P3_Top2
            // 
            P3_Top2.AutoSize = true;
            P3_Top2.Location = new Point(64, 115);
            P3_Top2.Name = "P3_Top2";
            P3_Top2.Size = new Size(49, 15);
            P3_Top2.TabIndex = 41;
            P3_Top2.Text = "Top 2 : ";
            // 
            // P3_WinRate
            // 
            P3_WinRate.AutoSize = true;
            P3_WinRate.Location = new Point(71, 81);
            P3_WinRate.Name = "P3_WinRate";
            P3_WinRate.Size = new Size(38, 15);
            P3_WinRate.TabIndex = 40;
            P3_WinRate.Text = "승률 :";
            // 
            // P3_RP
            // 
            P3_RP.AutoSize = true;
            P3_RP.Location = new Point(81, 51);
            P3_RP.Name = "P3_RP";
            P3_RP.Size = new Size(28, 15);
            P3_RP.TabIndex = 39;
            P3_RP.Text = "RP :";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        private Label P2_Avg_Assist;
        private Label P2_Avg_Kill;
        private Label P2_Avg_TK;
        private Label P2_Avg_Rank;
        private Label P2_Avg_Dmg;
        private Label P2_totalGame;
        private Label P2_Top3;
        private Label P2_Top2;
        private Label P2_WinRate;
        private Label P2_RP;
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
        public Label P2_Avg_Assist_Text;
        public Label P2_Avg_TK_Text;
        public Label P2_Avg_Kill_Text;
        public Label P2_Avg_Rank_Text;
        public Label P2_Avg_Dmg_Text;
        public Label P2_totalGame_Text;
        public Label P2_Top3_Text;
        public Label P2_Top2_Text;
        public Label P2_WinRate_Text;
        public Label P2_RP_Text;
        public Label P3_Avg_Assist_Text;
        public Label P3_Avg_TK_Text;
        public Label P3_Avg_Kill_Text;
        public Label P3_Avg_Rank_Text;
        public Label P3_Avg_Dmg_Text;
        public Label P3_totalGame_Text;
        public Label P3_Top3_Text;
        public Label P3_Top2_Text;
        public Label P3_WinRate_Text;
        public Label P3_RP_Text;
        private Label P3_Avg_Assist;
        private Label P3_Avg_Kill;
        private Label P3_Avg_TK;
        private Label P3_Avg_Rank;
        private Label P3_Avg_Dmg;
        private Label P3_totalGame;
        private Label P3_Top3;
        private Label P3_Top2;
        private Label P3_WinRate;
        private Label P3_RP;
        private Label Player1;
        public Label Player1_Text;
        public Label Player2;
        private Label Player2_Text;
        private GroupBox Player2_GroupBox;
        private GroupBox Player3_GroupBox;
        public Label Player3_Text;
        private Label Player3;
        private Label RP_Calc;
    }
}
