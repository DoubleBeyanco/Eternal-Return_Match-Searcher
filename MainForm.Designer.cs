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
            Player1 = new GroupBox();
            P1_Avg_Assist_Text = new Label();
            P1_Avg_TK_Text = new Label();
            P1_Avg_Kill_Text = new Label();
            P1_Avg_Rank_Text = new Label();
            P1_Avg_Dmg_Text = new Label();
            P1_totalGame_Text = new Label();
            P1_Top3_Text = new Label();
            P1_Top2_Text = new Label();
            P1_WinRate_Text = new Label();
            P1_RP_Text = new Label();
            P1_Avg_Assist = new Label();
            P1_Avg_Kill = new Label();
            P1_Avg_TK = new Label();
            P1_Avg_Rank = new Label();
            P1_Avg_Dmg = new Label();
            P1_totalGame = new Label();
            P1_Top3 = new Label();
            P1_Top2 = new Label();
            P1_WinRate = new Label();
            P1_RP = new Label();
            Player2 = new GroupBox();
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
            Player3 = new GroupBox();
            Player1.SuspendLayout();
            Player2.SuspendLayout();
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
            // Player1
            // 
            Player1.Controls.Add(P1_Avg_Assist_Text);
            Player1.Controls.Add(P1_Avg_TK_Text);
            Player1.Controls.Add(P1_Avg_Kill_Text);
            Player1.Controls.Add(P1_Avg_Rank_Text);
            Player1.Controls.Add(P1_Avg_Dmg_Text);
            Player1.Controls.Add(P1_totalGame_Text);
            Player1.Controls.Add(P1_Top3_Text);
            Player1.Controls.Add(P1_Top2_Text);
            Player1.Controls.Add(P1_WinRate_Text);
            Player1.Controls.Add(P1_RP_Text);
            Player1.Controls.Add(P1_Avg_Assist);
            Player1.Controls.Add(P1_Avg_Kill);
            Player1.Controls.Add(P1_Avg_TK);
            Player1.Controls.Add(P1_Avg_Rank);
            Player1.Controls.Add(P1_Avg_Dmg);
            Player1.Controls.Add(P1_totalGame);
            Player1.Controls.Add(P1_Top3);
            Player1.Controls.Add(P1_Top2);
            Player1.Controls.Add(P1_WinRate);
            Player1.Controls.Add(P1_RP);
            Player1.Location = new Point(10, 46);
            Player1.Name = "Player1";
            Player1.Size = new Size(258, 392);
            Player1.TabIndex = 3;
            Player1.TabStop = false;
            Player1.Text = "                          Player                             ";
            // 
            // P1_Avg_Assist_Text
            // 
            P1_Avg_Assist_Text.AutoSize = true;
            P1_Avg_Assist_Text.Location = new Point(117, 332);
            P1_Avg_Assist_Text.Name = "P1_Avg_Assist_Text";
            P1_Avg_Assist_Text.Size = new Size(109, 15);
            P1_Avg_Assist_Text.TabIndex = 18;
            P1_Avg_Assist_Text.Text = "P1_Avg_Assist_Text";
            // 
            // P1_Avg_TK_Text
            // 
            P1_Avg_TK_Text.AutoSize = true;
            P1_Avg_TK_Text.Location = new Point(117, 262);
            P1_Avg_TK_Text.Name = "P1_Avg_TK_Text";
            P1_Avg_TK_Text.Size = new Size(92, 15);
            P1_Avg_TK_Text.TabIndex = 17;
            P1_Avg_TK_Text.Text = "P1_Avg_TK_Text";
            // 
            // P1_Avg_Kill_Text
            // 
            P1_Avg_Kill_Text.AutoSize = true;
            P1_Avg_Kill_Text.Location = new Point(117, 296);
            P1_Avg_Kill_Text.Name = "P1_Avg_Kill_Text";
            P1_Avg_Kill_Text.Size = new Size(95, 15);
            P1_Avg_Kill_Text.TabIndex = 17;
            P1_Avg_Kill_Text.Text = "P1_Avg_Kill_Text";
            // 
            // P1_Avg_Rank_Text
            // 
            P1_Avg_Rank_Text.AutoSize = true;
            P1_Avg_Rank_Text.Location = new Point(117, 231);
            P1_Avg_Rank_Text.Name = "P1_Avg_Rank_Text";
            P1_Avg_Rank_Text.Size = new Size(105, 15);
            P1_Avg_Rank_Text.TabIndex = 16;
            P1_Avg_Rank_Text.Text = "P1_Avg_Rank_Text";
            // 
            // P1_Avg_Dmg_Text
            // 
            P1_Avg_Dmg_Text.AutoSize = true;
            P1_Avg_Dmg_Text.Location = new Point(117, 199);
            P1_Avg_Dmg_Text.Name = "P1_Avg_Dmg_Text";
            P1_Avg_Dmg_Text.Size = new Size(106, 15);
            P1_Avg_Dmg_Text.TabIndex = 15;
            P1_Avg_Dmg_Text.Text = "P1_Avg_Dmg_Text";
            // 
            // P1_totalGame_Text
            // 
            P1_totalGame_Text.AutoSize = true;
            P1_totalGame_Text.Location = new Point(117, 167);
            P1_totalGame_Text.Name = "P1_totalGame_Text";
            P1_totalGame_Text.Size = new Size(108, 15);
            P1_totalGame_Text.TabIndex = 14;
            P1_totalGame_Text.Text = "P1_totalGame_Text";
            // 
            // P1_Top3_Text
            // 
            P1_Top3_Text.AutoSize = true;
            P1_Top3_Text.Location = new Point(117, 135);
            P1_Top3_Text.Name = "P1_Top3_Text";
            P1_Top3_Text.Size = new Size(80, 15);
            P1_Top3_Text.TabIndex = 13;
            P1_Top3_Text.Text = "P1_Top3_Text";
            // 
            // P1_Top2_Text
            // 
            P1_Top2_Text.AutoSize = true;
            P1_Top2_Text.Location = new Point(117, 99);
            P1_Top2_Text.Name = "P1_Top2_Text";
            P1_Top2_Text.Size = new Size(80, 15);
            P1_Top2_Text.TabIndex = 12;
            P1_Top2_Text.Text = "P1_Top2_Text";
            // 
            // P1_WinRate_Text
            // 
            P1_WinRate_Text.AutoSize = true;
            P1_WinRate_Text.Location = new Point(117, 65);
            P1_WinRate_Text.Name = "P1_WinRate_Text";
            P1_WinRate_Text.Size = new Size(97, 15);
            P1_WinRate_Text.TabIndex = 11;
            P1_WinRate_Text.Text = "P1_WinRate_Text";
            // 
            // P1_RP_Text
            // 
            P1_RP_Text.AutoSize = true;
            P1_RP_Text.Location = new Point(117, 35);
            P1_RP_Text.Name = "P1_RP_Text";
            P1_RP_Text.Size = new Size(67, 15);
            P1_RP_Text.TabIndex = 10;
            P1_RP_Text.Text = "P1_RP_Text";
            // 
            // P1_Avg_Assist
            // 
            P1_Avg_Assist.AutoSize = true;
            P1_Avg_Assist.Location = new Point(36, 332);
            P1_Avg_Assist.Name = "P1_Avg_Assist";
            P1_Avg_Assist.Size = new Size(70, 15);
            P1_Avg_Assist.TabIndex = 9;
            P1_Avg_Assist.Text = "평균 어시 : ";
            // 
            // P1_Avg_Kill
            // 
            P1_Avg_Kill.AutoSize = true;
            P1_Avg_Kill.Location = new Point(48, 296);
            P1_Avg_Kill.Name = "P1_Avg_Kill";
            P1_Avg_Kill.Size = new Size(54, 15);
            P1_Avg_Kill.TabIndex = 8;
            P1_Avg_Kill.Text = "평균 킬 :";
            // 
            // P1_Avg_TK
            // 
            P1_Avg_TK.AutoSize = true;
            P1_Avg_TK.Location = new Point(47, 262);
            P1_Avg_TK.Name = "P1_Avg_TK";
            P1_Avg_TK.Size = new Size(55, 15);
            P1_Avg_TK.TabIndex = 7;
            P1_Avg_TK.Text = "평균 TK :";
            // 
            // P1_Avg_Rank
            // 
            P1_Avg_Rank.AutoSize = true;
            P1_Avg_Rank.Location = new Point(36, 231);
            P1_Avg_Rank.Name = "P1_Avg_Rank";
            P1_Avg_Rank.Size = new Size(66, 15);
            P1_Avg_Rank.TabIndex = 6;
            P1_Avg_Rank.Text = "평균 순위 :";
            // 
            // P1_Avg_Dmg
            // 
            P1_Avg_Dmg.AutoSize = true;
            P1_Avg_Dmg.Location = new Point(36, 199);
            P1_Avg_Dmg.Name = "P1_Avg_Dmg";
            P1_Avg_Dmg.Size = new Size(66, 15);
            P1_Avg_Dmg.TabIndex = 5;
            P1_Avg_Dmg.Text = "평균 딜량 :";
            // 
            // P1_totalGame
            // 
            P1_totalGame.AutoSize = true;
            P1_totalGame.Location = new Point(48, 167);
            P1_totalGame.Name = "P1_totalGame";
            P1_totalGame.Size = new Size(58, 15);
            P1_totalGame.TabIndex = 4;
            P1_totalGame.Text = "게임 수 : ";
            // 
            // P1_Top3
            // 
            P1_Top3.AutoSize = true;
            P1_Top3.Location = new Point(61, 135);
            P1_Top3.Name = "P1_Top3";
            P1_Top3.Size = new Size(45, 15);
            P1_Top3.TabIndex = 3;
            P1_Top3.Text = "Top3 : ";
            // 
            // P1_Top2
            // 
            P1_Top2.AutoSize = true;
            P1_Top2.Location = new Point(57, 99);
            P1_Top2.Name = "P1_Top2";
            P1_Top2.Size = new Size(49, 15);
            P1_Top2.TabIndex = 2;
            P1_Top2.Text = "Top 2 : ";
            // 
            // P1_WinRate
            // 
            P1_WinRate.AutoSize = true;
            P1_WinRate.Location = new Point(64, 65);
            P1_WinRate.Name = "P1_WinRate";
            P1_WinRate.Size = new Size(38, 15);
            P1_WinRate.TabIndex = 1;
            P1_WinRate.Text = "승률 :";
            // 
            // P1_RP
            // 
            P1_RP.AutoSize = true;
            P1_RP.Location = new Point(74, 35);
            P1_RP.Name = "P1_RP";
            P1_RP.Size = new Size(28, 15);
            P1_RP.TabIndex = 0;
            P1_RP.Text = "RP :";
            // 
            // Player2
            // 
            Player2.Controls.Add(P2_Avg_Assist_Text);
            Player2.Controls.Add(P2_Avg_TK_Text);
            Player2.Controls.Add(P2_Avg_Kill_Text);
            Player2.Controls.Add(P2_Avg_Rank_Text);
            Player2.Controls.Add(P2_Avg_Dmg_Text);
            Player2.Controls.Add(P2_totalGame_Text);
            Player2.Controls.Add(P2_Top3_Text);
            Player2.Controls.Add(P2_Top2_Text);
            Player2.Controls.Add(P2_WinRate_Text);
            Player2.Controls.Add(P2_RP_Text);
            Player2.Controls.Add(P2_Avg_Assist);
            Player2.Controls.Add(P2_Avg_Kill);
            Player2.Controls.Add(P2_Avg_TK);
            Player2.Controls.Add(P2_Avg_Rank);
            Player2.Controls.Add(P2_Avg_Dmg);
            Player2.Controls.Add(P2_totalGame);
            Player2.Controls.Add(P2_Top3);
            Player2.Controls.Add(P2_Top2);
            Player2.Controls.Add(P2_WinRate);
            Player2.Controls.Add(P2_RP);
            Player2.Location = new Point(270, 46);
            Player2.Name = "Player2";
            Player2.Size = new Size(258, 392);
            Player2.TabIndex = 4;
            Player2.TabStop = false;
            Player2.Text = "                          Player                             ";
            // 
            // P2_Avg_Assist_Text
            // 
            P2_Avg_Assist_Text.AutoSize = true;
            P2_Avg_Assist_Text.Location = new Point(124, 332);
            P2_Avg_Assist_Text.Name = "P2_Avg_Assist_Text";
            P2_Avg_Assist_Text.Size = new Size(109, 15);
            P2_Avg_Assist_Text.TabIndex = 38;
            P2_Avg_Assist_Text.Text = "P2_Avg_Assist_Text";
            // 
            // P2_Avg_TK_Text
            // 
            P2_Avg_TK_Text.AutoSize = true;
            P2_Avg_TK_Text.Location = new Point(124, 262);
            P2_Avg_TK_Text.Name = "P2_Avg_TK_Text";
            P2_Avg_TK_Text.Size = new Size(92, 15);
            P2_Avg_TK_Text.TabIndex = 37;
            P2_Avg_TK_Text.Text = "P2_Avg_TK_Text";
            // 
            // P2_Avg_Kill_Text
            // 
            P2_Avg_Kill_Text.AutoSize = true;
            P2_Avg_Kill_Text.Location = new Point(124, 296);
            P2_Avg_Kill_Text.Name = "P2_Avg_Kill_Text";
            P2_Avg_Kill_Text.Size = new Size(95, 15);
            P2_Avg_Kill_Text.TabIndex = 36;
            P2_Avg_Kill_Text.Text = "P2_Avg_Kill_Text";
            // 
            // P2_Avg_Rank_Text
            // 
            P2_Avg_Rank_Text.AutoSize = true;
            P2_Avg_Rank_Text.Location = new Point(124, 231);
            P2_Avg_Rank_Text.Name = "P2_Avg_Rank_Text";
            P2_Avg_Rank_Text.Size = new Size(105, 15);
            P2_Avg_Rank_Text.TabIndex = 35;
            P2_Avg_Rank_Text.Text = "P2_Avg_Rank_Text";
            // 
            // P2_Avg_Dmg_Text
            // 
            P2_Avg_Dmg_Text.AutoSize = true;
            P2_Avg_Dmg_Text.Location = new Point(124, 199);
            P2_Avg_Dmg_Text.Name = "P2_Avg_Dmg_Text";
            P2_Avg_Dmg_Text.Size = new Size(106, 15);
            P2_Avg_Dmg_Text.TabIndex = 34;
            P2_Avg_Dmg_Text.Text = "P2_Avg_Dmg_Text";
            // 
            // P2_totalGame_Text
            // 
            P2_totalGame_Text.AutoSize = true;
            P2_totalGame_Text.Location = new Point(124, 167);
            P2_totalGame_Text.Name = "P2_totalGame_Text";
            P2_totalGame_Text.Size = new Size(108, 15);
            P2_totalGame_Text.TabIndex = 33;
            P2_totalGame_Text.Text = "P2_totalGame_Text";
            // 
            // P2_Top3_Text
            // 
            P2_Top3_Text.AutoSize = true;
            P2_Top3_Text.Location = new Point(124, 135);
            P2_Top3_Text.Name = "P2_Top3_Text";
            P2_Top3_Text.Size = new Size(80, 15);
            P2_Top3_Text.TabIndex = 32;
            P2_Top3_Text.Text = "P2_Top3_Text";
            // 
            // P2_Top2_Text
            // 
            P2_Top2_Text.AutoSize = true;
            P2_Top2_Text.Location = new Point(124, 99);
            P2_Top2_Text.Name = "P2_Top2_Text";
            P2_Top2_Text.Size = new Size(80, 15);
            P2_Top2_Text.TabIndex = 31;
            P2_Top2_Text.Text = "P2_Top2_Text";
            // 
            // P2_WinRate_Text
            // 
            P2_WinRate_Text.AutoSize = true;
            P2_WinRate_Text.Location = new Point(124, 65);
            P2_WinRate_Text.Name = "P2_WinRate_Text";
            P2_WinRate_Text.Size = new Size(97, 15);
            P2_WinRate_Text.TabIndex = 30;
            P2_WinRate_Text.Text = "P2_WinRate_Text";
            // 
            // P2_RP_Text
            // 
            P2_RP_Text.AutoSize = true;
            P2_RP_Text.Location = new Point(124, 35);
            P2_RP_Text.Name = "P2_RP_Text";
            P2_RP_Text.Size = new Size(67, 15);
            P2_RP_Text.TabIndex = 29;
            P2_RP_Text.Text = "P1_RP_Text";
            // 
            // P2_Avg_Assist
            // 
            P2_Avg_Assist.AutoSize = true;
            P2_Avg_Assist.Location = new Point(43, 332);
            P2_Avg_Assist.Name = "P2_Avg_Assist";
            P2_Avg_Assist.Size = new Size(70, 15);
            P2_Avg_Assist.TabIndex = 28;
            P2_Avg_Assist.Text = "평균 어시 : ";
            // 
            // P2_Avg_Kill
            // 
            P2_Avg_Kill.AutoSize = true;
            P2_Avg_Kill.Location = new Point(54, 296);
            P2_Avg_Kill.Name = "P2_Avg_Kill";
            P2_Avg_Kill.Size = new Size(54, 15);
            P2_Avg_Kill.TabIndex = 27;
            P2_Avg_Kill.Text = "평균 킬 :";
            // 
            // P2_Avg_TK
            // 
            P2_Avg_TK.AutoSize = true;
            P2_Avg_TK.Location = new Point(54, 262);
            P2_Avg_TK.Name = "P2_Avg_TK";
            P2_Avg_TK.Size = new Size(55, 15);
            P2_Avg_TK.TabIndex = 26;
            P2_Avg_TK.Text = "평균 TK :";
            // 
            // P2_Avg_Rank
            // 
            P2_Avg_Rank.AutoSize = true;
            P2_Avg_Rank.Location = new Point(43, 231);
            P2_Avg_Rank.Name = "P2_Avg_Rank";
            P2_Avg_Rank.Size = new Size(66, 15);
            P2_Avg_Rank.TabIndex = 25;
            P2_Avg_Rank.Text = "평균 순위 :";
            // 
            // P2_Avg_Dmg
            // 
            P2_Avg_Dmg.AutoSize = true;
            P2_Avg_Dmg.Location = new Point(43, 199);
            P2_Avg_Dmg.Name = "P2_Avg_Dmg";
            P2_Avg_Dmg.Size = new Size(66, 15);
            P2_Avg_Dmg.TabIndex = 24;
            P2_Avg_Dmg.Text = "평균 딜량 :";
            // 
            // P2_totalGame
            // 
            P2_totalGame.AutoSize = true;
            P2_totalGame.Location = new Point(55, 167);
            P2_totalGame.Name = "P2_totalGame";
            P2_totalGame.Size = new Size(58, 15);
            P2_totalGame.TabIndex = 23;
            P2_totalGame.Text = "게임 수 : ";
            // 
            // P2_Top3
            // 
            P2_Top3.AutoSize = true;
            P2_Top3.Location = new Point(68, 135);
            P2_Top3.Name = "P2_Top3";
            P2_Top3.Size = new Size(45, 15);
            P2_Top3.TabIndex = 22;
            P2_Top3.Text = "Top3 : ";
            // 
            // P2_Top2
            // 
            P2_Top2.AutoSize = true;
            P2_Top2.Location = new Point(64, 99);
            P2_Top2.Name = "P2_Top2";
            P2_Top2.Size = new Size(49, 15);
            P2_Top2.TabIndex = 21;
            P2_Top2.Text = "Top 2 : ";
            // 
            // P2_WinRate
            // 
            P2_WinRate.AutoSize = true;
            P2_WinRate.Location = new Point(71, 65);
            P2_WinRate.Name = "P2_WinRate";
            P2_WinRate.Size = new Size(38, 15);
            P2_WinRate.TabIndex = 20;
            P2_WinRate.Text = "승률 :";
            // 
            // P2_RP
            // 
            P2_RP.AutoSize = true;
            P2_RP.Location = new Point(81, 35);
            P2_RP.Name = "P2_RP";
            P2_RP.Size = new Size(28, 15);
            P2_RP.TabIndex = 19;
            P2_RP.Text = "RP :";
            // 
            // Player3
            // 
            Player3.Location = new Point(530, 46);
            Player3.Name = "Player3";
            Player3.Size = new Size(258, 392);
            Player3.TabIndex = 5;
            Player3.TabStop = false;
            Player3.Text = "                          Player                             ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Player3);
            Controls.Add(Player2);
            Controls.Add(Player1);
            Controls.Add(Btn_Search);
            Controls.Add(Input_nick);
            Controls.Add(TextLabel1);
            Name = "MainForm";
            Text = "Ethernal Return: Match Seacher";
            Load += Form1_Load;
            Player1.ResumeLayout(false);
            Player1.PerformLayout();
            Player2.ResumeLayout(false);
            Player2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TextLabel1;
        private TextBox Input_nick;
        private Button Btn_Search;
        private GroupBox groupBox3;
        private Label P1_RP;
        public GroupBox Player1;
        public GroupBox Player2;
        public GroupBox Player3;
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
    }
}
