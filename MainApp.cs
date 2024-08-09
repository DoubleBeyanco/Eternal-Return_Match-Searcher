using Ethernal_Return_Match_Seacher;
using System.Reflection;



public class MainApp
{
    public static MainForm main = new MainForm();
    public static UserSearchResult searchResult = new UserSearchResult();
    public static string path = string.Empty;
    //public static string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    private static void Main(string[] args)
    {
        ApplicationConfiguration.Initialize();
        path = Path.GetTempPath();

        FieldInfo[] fields = typeof(MainForm).GetFields(BindingFlags.Public | BindingFlags.Instance);

        var labelFields = new List<Label>();

        foreach (var field in fields)
        {
            if (field.FieldType == typeof(Label))
            {
                labelFields.Add((Label)field.GetValue(main));
            }
        }

        foreach (var label in labelFields)
        {
            if (label != null)
            {
                label.Text = String.Empty;
            }
        }

        DirectoryInfo di = new DirectoryInfo(path + @"\images");

        if (di.Exists == false)
        {
            di.Create();
        }
        BSAPI.InputCharactorKorString();
        BSAPI.RunRankRate();

        main.OnClickCallback = CheckUserStat;
        main.OnSerarchCallback = CheckTeamUserStat;
        Application.Run(main);

        di.Delete(true);
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

            stat = BSAPI.GetUserStat(BSAPI.GetCurSeasonNum(), usernum);

            main.Process_Text.Text = $"{i + 1}번째 유저 검색중...";
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

        main.Process_Text.Text = "검색 완료!";
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
        main.P1_M1_CharacterCode.Text = BSAPI.CharacterStringTable[userstat.Most1.characterCode];
        main.P1_M1_totalGames.Text = userstat.Most1.totalGames.ToString();
        main.P1_M1_maxKill.Text = userstat.Most1.maxKillings.ToString();
        main.P1_M1_Top3.Text = userstat.Most1.top3.ToString();
        main.P1_M1_Top3Rate.Text = CalculateWinRate(userstat.Most1.top3, userstat.Most1.totalGames).ToString() + "%";
        main.P1_M1_wins.Text = userstat.Most1.wins.ToString();
        main.P1_M1_WinRate.Text = CalculateWinRate(userstat.Most1.wins, userstat.Most1.totalGames).ToString() + "%";
        main.P1_M1_AvgRank.Text = userstat.Most1.averageRank.ToString();
        main.P1_M2_CharacterCode.Text = BSAPI.CharacterStringTable[userstat.Most2.characterCode];
        main.P1_M2_totalGames.Text = userstat.Most2.totalGames.ToString();
        main.P1_M2_maxKill.Text = userstat.Most2.maxKillings.ToString();
        main.P1_M2_Top3.Text = userstat.Most2.top3.ToString();
        main.P1_M2_Top3Rate.Text = CalculateWinRate(userstat.Most2.top3, userstat.Most2.totalGames).ToString() + "%";
        main.P1_M2_wins.Text = userstat.Most2.wins.ToString();
        main.P1_M2_WinRate.Text = CalculateWinRate(userstat.Most2.wins, userstat.Most2.totalGames).ToString() + "%";
        main.P1_M2_AvgRank.Text = userstat.Most2.averageRank.ToString();
        main.P1_M3_CharacterCode.Text = BSAPI.CharacterStringTable[userstat.Most3.characterCode];
        main.P1_M3_totalGames.Text = userstat.Most3.totalGames.ToString();
        main.P1_M3_maxKill.Text = userstat.Most3.maxKillings.ToString();
        main.P1_M3_Top3.Text = userstat.Most3.top3.ToString();
        main.P1_M3_Top3Rate.Text = CalculateWinRate(userstat.Most3.top3, userstat.Most3.totalGames).ToString() + "%";
        main.P1_M3_wins.Text = userstat.Most3.wins.ToString();
        main.P1_M3_WinRate.Text = CalculateWinRate(userstat.Most3.wins, userstat.Most3.totalGames).ToString() + "%";
        main.P1_M3_AvgRank.Text = userstat.Most3.averageRank.ToString();
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
        main.P2_M1_CharacterCode.Text = BSAPI.CharacterStringTable[userstat.Most1.characterCode];
        main.P2_M1_totalGames.Text = userstat.Most1.totalGames.ToString();
        main.P2_M1_maxKill.Text = userstat.Most1.maxKillings.ToString();
        main.P2_M1_Top3.Text = userstat.Most1.top3.ToString();
        main.P2_M1_Top3Rate.Text = CalculateWinRate(userstat.Most1.top3, userstat.Most1.totalGames).ToString() + "%";
        main.P2_M1_wins.Text = userstat.Most1.wins.ToString();
        main.P2_M1_WinRate.Text = CalculateWinRate(userstat.Most1.wins, userstat.Most1.totalGames).ToString() + "%";
        main.P2_M1_AvgRank.Text = userstat.Most1.averageRank.ToString();
        main.P2_M2_CharacterCode.Text = BSAPI.CharacterStringTable[userstat.Most2.characterCode];
        main.P2_M2_totalGames.Text = userstat.Most2.totalGames.ToString();
        main.P2_M2_maxKill.Text = userstat.Most2.maxKillings.ToString();
        main.P2_M2_Top3.Text = userstat.Most2.top3.ToString();
        main.P2_M2_Top3Rate.Text = CalculateWinRate(userstat.Most2.top3, userstat.Most2.totalGames).ToString() + "%";
        main.P2_M2_wins.Text = userstat.Most2.wins.ToString();
        main.P2_M2_WinRate.Text = CalculateWinRate(userstat.Most2.wins, userstat.Most2.totalGames).ToString() + "%";
        main.P2_M2_AvgRank.Text = userstat.Most2.averageRank.ToString();
        main.P2_M3_CharacterCode.Text = BSAPI.CharacterStringTable[userstat.Most3.characterCode];
        main.P2_M3_totalGames.Text = userstat.Most3.totalGames.ToString();
        main.P2_M3_maxKill.Text = userstat.Most3.maxKillings.ToString();
        main.P2_M3_Top3.Text = userstat.Most3.top3.ToString();
        main.P2_M3_Top3Rate.Text = CalculateWinRate(userstat.Most3.top3, userstat.Most3.totalGames).ToString() + "%";
        main.P2_M3_wins.Text = userstat.Most3.wins.ToString();
        main.P2_M3_WinRate.Text = CalculateWinRate(userstat.Most3.wins, userstat.Most3.totalGames).ToString() + "%";
        main.P2_M3_AvgRank.Text = userstat.Most3.averageRank.ToString();
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
        main.P3_M1_CharacterCode.Text = BSAPI.CharacterStringTable[userstat.Most1.characterCode];
        main.P3_M1_totalGames.Text = userstat.Most1.totalGames.ToString();
        main.P3_M1_maxKill.Text = userstat.Most1.maxKillings.ToString();
        main.P3_M1_Top3.Text = userstat.Most1.top3.ToString();
        main.P3_M1_Top3Rate.Text = CalculateWinRate(userstat.Most1.top3, userstat.Most1.totalGames).ToString() + "%";
        main.P3_M1_wins.Text = userstat.Most1.wins.ToString();
        main.P3_M1_WinRate.Text = CalculateWinRate(userstat.Most1.wins, userstat.Most1.totalGames).ToString() + "%";
        main.P3_M1_AvgRank.Text = userstat.Most1.averageRank.ToString();
        main.P3_M2_CharacterCode.Text = BSAPI.CharacterStringTable[userstat.Most2.characterCode];
        main.P3_M2_totalGames.Text = userstat.Most2.totalGames.ToString();
        main.P3_M2_maxKill.Text = userstat.Most2.maxKillings.ToString();
        main.P3_M2_Top3.Text = userstat.Most2.top3.ToString();
        main.P3_M2_Top3Rate.Text = CalculateWinRate(userstat.Most2.top3, userstat.Most2.totalGames).ToString() + "%";
        main.P3_M2_wins.Text = userstat.Most2.wins.ToString();
        main.P3_M2_WinRate.Text = CalculateWinRate(userstat.Most2.wins, userstat.Most2.totalGames).ToString() + "%";
        main.P3_M2_AvgRank.Text = userstat.Most2.averageRank.ToString();
        main.P3_M3_CharacterCode.Text = BSAPI.CharacterStringTable[userstat.Most3.characterCode];
        main.P3_M3_totalGames.Text = userstat.Most3.totalGames.ToString();
        main.P3_M3_maxKill.Text = userstat.Most3.maxKillings.ToString();
        main.P3_M3_Top3.Text = userstat.Most3.top3.ToString();
        main.P3_M3_Top3Rate.Text = CalculateWinRate(userstat.Most3.top3, userstat.Most3.totalGames).ToString() + "%";
        main.P3_M3_wins.Text = userstat.Most3.wins.ToString();
        main.P3_M3_WinRate.Text = CalculateWinRate(userstat.Most3.wins, userstat.Most3.totalGames).ToString() + "%";
        main.P3_M3_AvgRank.Text = userstat.Most3.averageRank.ToString();
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
        searchResult.M1_CharacterCode.Text = BSAPI.CharacterStringTable[userstat.Most1.characterCode];
        searchResult.M1_totalGames.Text = userstat.Most1.totalGames.ToString();
        searchResult.M1_maxKill.Text = userstat.Most1.maxKillings.ToString();
        searchResult.M1_Top3.Text = userstat.Most1.top3.ToString();
        searchResult.M1_Top3Rate.Text = CalculateWinRate(userstat.Most1.top3, userstat.Most1.totalGames).ToString() + "%";
        searchResult.M1_wins.Text = userstat.Most1.wins.ToString();
        searchResult.M1_WinRate.Text = CalculateWinRate(userstat.Most1.wins, userstat.Most1.totalGames).ToString() + "%";
        searchResult.M1_AvgRank.Text = userstat.Most1.averageRank.ToString();
        searchResult.M2_CharacterCode.Text = BSAPI.CharacterStringTable[userstat.Most2.characterCode];
        searchResult.M2_totalGames.Text = userstat.Most2.totalGames.ToString();
        searchResult.M2_maxKill.Text = userstat.Most2.maxKillings.ToString();
        searchResult.M2_Top3.Text = userstat.Most2.top3.ToString();
        searchResult.M2_Top3Rate.Text = CalculateWinRate(userstat.Most2.top3, userstat.Most2.totalGames).ToString() + "%";
        searchResult.M2_wins.Text = userstat.Most2.wins.ToString();
        searchResult.M2_WinRate.Text = CalculateWinRate(userstat.Most2.wins, userstat.Most2.totalGames).ToString() + "%";
        searchResult.M2_AvgRank.Text = userstat.Most2.averageRank.ToString();
        searchResult.M3_CharacterCode.Text = BSAPI.CharacterStringTable[userstat.Most3.characterCode];
        searchResult.M3_totalGames.Text = userstat.Most3.totalGames.ToString();
        searchResult.M3_maxKill.Text = userstat.Most3.maxKillings.ToString();
        searchResult.M3_Top3.Text = userstat.Most3.top3.ToString();
        searchResult.M3_Top3Rate.Text = CalculateWinRate(userstat.Most3.top3, userstat.Most3.totalGames).ToString() + "%";
        searchResult.M3_wins.Text = userstat.Most3.wins.ToString();
        searchResult.M3_WinRate.Text = CalculateWinRate(userstat.Most3.wins, userstat.Most3.totalGames).ToString() + "%";
        searchResult.M3_AvgRank.Text = userstat.Most3.averageRank.ToString();
    }

    private static double CalculateWinRate(int wins, int totalGames)
    {
        if (totalGames == 0)
            return 0;
        double rate = ((double)wins / totalGames) * 100;
        return Math.Round(rate, 1);
    }
}