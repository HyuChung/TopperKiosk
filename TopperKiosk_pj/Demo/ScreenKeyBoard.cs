using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;

class clsVirtualKB
{
    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern bool Wow64DisableWow64FsRedirection(ref IntPtr ptr);

    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern bool Wow64RevertWow64FsRedirection(IntPtr ptr);

    private const UInt32 WM_SYSCOMMAND = 0x112;
    private const UInt32 SC_RESTORE = 0xf120;
    [DllImport("user32.dll", CharSet = CharSet.Auto)]


    static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

    private const string OnScreenKeyboadApplication = "osk.exe";

    static public void Open()
    {
        // Get the name of the On screen keyboard
        string processName = System.IO.Path.GetFileNameWithoutExtension(OnScreenKeyboadApplication);

        // Check whether the application is not running 
        var query = from process in Process.GetProcesses()
                    where process.ProcessName == processName
                    select process;

        var keyboardProcess = query.FirstOrDefault();

        // launch it if it doesn't exist
        if (keyboardProcess == null)
        {
            IntPtr ptr = new IntPtr(); ;
            bool sucessfullyDisabledWow64Redirect = false;

            // Disable x64 directory virtualization if we're on x64,
            // otherwise keyboard launch will fail.
            if (System.Environment.Is64BitOperatingSystem)
            {
                sucessfullyDisabledWow64Redirect = Wow64DisableWow64FsRedirection(ref ptr);
            }

            // osk.exe is in windows/system folder. So we can directky call it without path
            using (Process osk = new Process())
            {
                osk.StartInfo.FileName = OnScreenKeyboadApplication;
                osk.Start();
            }

            // Re-enable directory virtualisation if it was disabled.
            if (System.Environment.Is64BitOperatingSystem)
                if (sucessfullyDisabledWow64Redirect)
                    Wow64RevertWow64FsRedirection(ptr);
        }
        else
        {
            // Bring keyboard to the front if it's already running
            var windowHandle = keyboardProcess.MainWindowHandle;
            SendMessage(windowHandle, WM_SYSCOMMAND, new IntPtr(SC_RESTORE), new IntPtr(0));
        }
    }
}
