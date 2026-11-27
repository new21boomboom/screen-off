using System;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Threading;

[assembly: AssemblyTitle("一键息屏")]
[assembly: AssemblyDescription("一键关闭显示器")]
[assembly: AssemblyProduct("一键息屏")]
[assembly: AssemblyCompany("Local")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

public static class Program
{
    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    private static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

    public static void Main()
    {
        Thread.Sleep(700);
        SendMessage(new IntPtr(0xFFFF), 0x0112, new IntPtr(0xF170), new IntPtr(2));
    }
}
