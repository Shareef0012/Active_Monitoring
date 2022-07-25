using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;



namespace Monitoring
{
    internal class Win32
    {

        public delegate bool callBack(int hWnd, int lParam);

        public static bool PrintHandle(int hWnd, int lParam)
        {
            //Console.WriteLine(hWnd);
            hWnds.Add(hWnd);
            return true;

        }
        [DllImport("user32")]
        public static extern int EnumWindows(callBack x, int y);
        public static List<int> hWnds = new List<int>();
        public static List<string> titles = new List<string>();

        [DllImport("user32")]
        public static extern int GetWindowText(int hWnd, StringBuilder tmp, int maxLength); //out string lpTitle
        [DllImport("user32")]
        public static extern int GetWindowTextLength(int hWnd);

        public static string GetTitle(int hWnd)
        {
            int length = GetWindowTextLength(hWnd);
            StringBuilder Title = new StringBuilder(length + 1);
            GetWindowText(hWnd, Title, Title.Capacity);
            return Title.ToString();
        }

        [DllImport("user32.dll")]
        public static extern bool IsWindowVisible(int hWnd);
        [DllImport("user32.dll")]
        public static extern int GetForegroundWindow();

    }
}
