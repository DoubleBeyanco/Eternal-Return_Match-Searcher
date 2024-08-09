using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Diagnostics;
using Ethernal_Return_Match_Seacher;


public class ScreenCapture
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Rect
    {
        public int left;
        public int top;
        public int right;
        public int bottom;
    }

    [DllImport("user32.dll")]
    private static extern int SetForegroundWindow(IntPtr hWnd);

    private const int SW_RESTORE = 9;

    [DllImport("user32.dll")]
    private static extern IntPtr ShowWindow(IntPtr hWnd, int nCmdShow);

    [DllImport("user32.dll")]
    private static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);

    private Bitmap CaptureApplication(string procName)
    {
        MainApp.main.Process_Text.Text = "스크린 샷 촬영 중...";
        Process proc;

        // Cater for cases when the process can`t be located
        try
        {
            proc = Process.GetProcessesByName(procName)[0];
        }
        catch (IndexOutOfRangeException e)
        {
            return null;
        }

        // You need to focus on the application
        SetForegroundWindow(proc.MainWindowHandle);
        ShowWindow(proc.MainWindowHandle, SW_RESTORE);

        // You need to some amount of delay, but 1 second may be overkill
        Thread.Sleep(1000);

        Rect rect = new Rect();
        IntPtr error = GetWindowRect(proc.MainWindowHandle, ref rect);

        // Sometimes it gives error.
        while (error == (IntPtr)0)
        {
            error = GetWindowRect(proc.MainWindowHandle, ref rect);
        }

        int width = rect.right - rect.left;
        int height = rect.bottom - rect.top;

        Bitmap bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);
        Graphics.FromImage(bmp).CopyFromScreen(rect.left, rect.top, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);

        return bmp;
    }

    public void ScreenShot()
    {

        Bitmap bmpTmp;

        bmpTmp = CaptureApplication("EternalReturn");
        if (bmpTmp != null)
        {
            bmpTmp.Save(MainApp.path + @"\images\" + "Detect" + @".png", ImageFormat.Png);
        }
        else
        {
            MessageBox.Show("이터널 리턴 게임을 실행해주세요.");
        }
    }
}
