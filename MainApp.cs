using Ethernal_Return_Match_Seacher;

public class MainApp
{
    BSAPI api = new BSAPI();
    private static void Main(string[] args)
    {

        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}