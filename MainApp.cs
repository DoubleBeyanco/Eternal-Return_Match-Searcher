using Ethernal_Return_Match_Seacher;
using System.Diagnostics;
using System.Reflection;
using static System.Windows.Forms.AxHost;


public class MainApp
{
    static MainForm main = new MainForm();
    static UserSearchResult searchResult = new UserSearchResult();
    private static void Main(string[] args)
    {
        string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        DirectoryInfo di = new DirectoryInfo(path + @"\images");

        if (di.Exists == false)
        {
            di.Create();
        }
        OCR ocr = new OCR();
        

        /*test.PlayerResult();

        Console.WriteLine("PlayerA: " + test.PlayerA);
        Console.WriteLine("PlayerB: " + test.PlayerB);
        Console.WriteLine("PlayerC: " + test.PlayerC);*/

        BSAPI.InputCharactorKorString();

        ApplicationConfiguration.Initialize();
        main.OnClickCallback = CheckUserStat;
        main.OnSerarchCallback = CheckTeamUserStat;
        Application.Run(main);
    }


    private static void CheckUserStat(string _nickName)
    {
        int usernum = BSAPI.GetUserNum(_nickName);
        if (usernum != -1)
        {
            BSAPI.UserStat stat = BSAPI.GetUserStat(BSAPI.GetCurSeasonNum(), usernum);
            InputUserInfo(stat);
            searchResult.ShowDialog();
        }
        else
        {
            MessageBox.Show("닉네임을 체크해주세요!");
        }
    }
    private static void CheckTeamUserStat()
    {
        ScreenCapture capture = new ScreenCapture();
        capture.ScreenShot();
        OCR ocr = new OCR();
        ocr.PlayerResult();

        string[] nicknames = new string[3];

        nicknames[0] = ocr.PlayerA;
        nicknames[1] = ocr.PlayerB;
        nicknames[2] = ocr.PlayerC;


        for (int i = 0; i < nicknames.Length; ++i)
        {
            BSAPI.UserStat stat;
            int usernum = BSAPI.GetUserNum(nicknames[i]);

            if (usernum != -1)
            {
                stat = BSAPI.GetUserStat(BSAPI.GetCurSeasonNum(), usernum);
            }
            else
            {
                stat = BSAPI.GetUserStat(BSAPI.GetCurSeasonNum(), usernum);
            }

            switch (i)
            {
                case 0:
                    InputUserAInfo(stat);
                    break;
                case 1:
                    InputUserBInfo(stat);
                    break;
                case 2:
                    InputUserCInfo(stat);
                    break;
                default:
                    InputUserAInfo(stat);
                    break;
            }
        } 
    }

    private static void InputUserAInfo(BSAPI.UserStat userstat)
    {
        main.Player1_Text.Text = userstat.nickname.ToString();
        main.P1_RP_Text.Text = userstat.mmr.ToString();
        main.P1_RP_Calc.Text = userstat.rankTier;
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
    private static void InputUserBInfo(BSAPI.UserStat userstat)
    {
        main.Player2_Text.Text = userstat.nickname.ToString();
        main.P2_RP_Text.Text = userstat.mmr.ToString();
        main.P2_RP_Calc.Text = userstat.rankTier;
        main.P2_WinRate_Text.Text = (Math.Round(userstat.top1,3)).ToString() + "%";
        main.P2_Top2_Text.Text = (Math.Round(userstat.top2,3)).ToString() + "%";
        main.P2_Top3_Text.Text = (Math.Round(userstat.top3,3)).ToString() + "%";
        main.P2_totalGame_Text.Text = userstat.totalGames.ToString();
        main.P2_Avg_Dmg_Text.Text = "지원예정...";
        main.P2_Avg_Rank_Text.Text = userstat.averageRank.ToString();
        main.P2_Avg_TK_Text.Text = "지원예정...";
        main.P2_Avg_Kill_Text.Text = userstat.averageKills.ToString();
        main.P2_Avg_Assist_Text.Text = userstat.averageAssistants.ToString();
    }
    private static void InputUserCInfo(BSAPI.UserStat userstat)
    {
        main.Player3_Text.Text = userstat.nickname.ToString();
        main.P3_RP_Text.Text = userstat.mmr.ToString();
        main.P3_RP_Calc.Text = userstat.rankTier;
        main.P3_WinRate_Text.Text = (Math.Round(userstat.top1,3)).ToString() + "%";
        main.P3_Top2_Text.Text = (Math.Round(userstat.top2,3)).ToString() + "%";
        main.P3_Top3_Text.Text = (Math.Round(userstat.top3,3)).ToString() + "%";
        main.P3_totalGame_Text.Text = userstat.totalGames.ToString();
        main.P3_Avg_Dmg_Text.Text = "지원예정...";
        main.P3_Avg_Rank_Text.Text = userstat.averageRank.ToString();
        main.P3_Avg_TK_Text.Text = "지원예정...";
        main.P3_Avg_Kill_Text.Text = userstat.averageKills.ToString();
        main.P3_Avg_Assist_Text.Text = userstat.averageAssistants.ToString();
    }
    private static void InputUserInfo(BSAPI.UserStat userstat)
    {
        searchResult.NickName.Text = userstat.nickname.ToString();
        searchResult.RP_Text.Text = userstat.mmr.ToString();
        searchResult.RP_Calc.Text = userstat.rankTier;
        searchResult.WinRate_Text.Text = (Math.Round(userstat.top1,3)).ToString() + "%";
        searchResult.Top2_Text.Text = (Math.Round(userstat.top2,3)).ToString() + "%";
        searchResult.Top3_Text.Text = (Math.Round(userstat.top3,3)).ToString() + "%";
        searchResult.totalGame_Text.Text = userstat.totalGames.ToString();
        searchResult.Avg_Dmg_Text.Text = "지원예정...";
        searchResult.Avg_Rank_Text.Text = userstat.averageRank.ToString();
        searchResult.Avg_TK_Text.Text = "지원예정...";
        searchResult.Avg_Kill_Text.Text = userstat.averageKills.ToString();
        searchResult.Avg_Assist_Text.Text = userstat.averageAssistants.ToString();
    }
}