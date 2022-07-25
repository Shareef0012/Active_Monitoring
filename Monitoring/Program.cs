// See https://aka.ms/new-console-template for more information
using Monitoring;
using static Monitoring.Win32;



callBack myCallBack = new callBack(Win32.PrintHandle);
EnumWindows(myCallBack, 1);

foreach (int hWnd in Win32.hWnds)
{
    if (IsWindowVisible(hWnd))
    {
        int tmp = 0;
        //Console.WriteLine(GetTitle(hWnd));
    }

}

int hWnd2 = GetForegroundWindow();
Console.WriteLine(GetTitle(hWnd2));

