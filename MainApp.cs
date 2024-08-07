using Ethernal_Return_Match_Seacher;


public class MainApp
{
    static MainForm main = new MainForm();
    private static void Main(string[] args)
    {
        BSAPI.InputCharactorKorString();

        ApplicationConfiguration.Initialize();
        main.OnClickCallback = CheckUserStat;
        Application.Run(main);



    }

    private static void CheckUserStat(string _nickname)
    {
        int usernum = BSAPI.GetUserNum(_nickname);

        if ( usernum != -1)
        {
            BSAPI.UserStat stat = BSAPI.GetUserStat(BSAPI.GetCurSeasonNum(), usernum);
            InputUserInfo(stat);
        }
        else
        {
            MessageBox.Show("닉네임을 확인해주세요");
        }
        
        
        
    }

    private static void InputUserInfo(BSAPI.UserStat userstat)
    {
        main.Player1_Text.Text = userstat.nickname.ToString();
        main.P1_RP_Text.Text = userstat.mmr.ToString();
        main.P1_WinRate_Text.Text = (Math.Round(userstat.top1,3)).ToString() + "%";
        main.P1_Top2_Text.Text = (Math.Round(userstat.top2,3)).ToString() + "%";
        main.P1_Top3_Text.Text = (Math.Round(userstat.top3,3)).ToString() + "%";
        main.P1_totalGame_Text.Text = userstat.totalGames.ToString();
        main.P1_Avg_Dmg_Text.Text = "지원예정...";
        main.P1_Avg_Rank_Text.Text = userstat.averageRank.ToString();
        main.P1_Avg_TK_Text.Text = "지원예정...";
        main.P1_Avg_Kill_Text.Text = userstat.averageKills.ToString();
        main.P1_Avg_Assist_Text.Text = userstat.averageAssistants.ToString();

    }
}