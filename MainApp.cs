using Ethernal_Return_Match_Seacher;
using System.Runtime.CompilerServices;

public class MainApp
{
    static MainForm main = new MainForm();
    private static void Main(string[] args)
    {
        
        ApplicationConfiguration.Initialize();
        main.OnClickCallback = CheckUserStat;
        Application.Run(main);

        
        
    }

    private static void CheckUserStat(string _nickname)
    {
        BSAPI.UserStat stat = BSAPI.GetUserStat(BSAPI.GetCurSeasonNum(), BSAPI.GetUserNum(_nickname));
        main.Player1.Text = stat.nickname.ToString();
    }
}