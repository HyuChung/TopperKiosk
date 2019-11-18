using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;


namespace Demo
{
    class Macro
    {
        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo); //마우스 이벤트

        [DllImport("user32.dll")]
        public static extern int SetCursorPos(int x, int y); // 마우스 좌표 설정

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd); // 프로그램 활성화

        [DllImport("User32", EntryPoint = "FindWindow")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName); // 프로그램 찾는 함수

        //[DllImport("user32.dll")]
        //static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo); // SendKeys.send() 로 대체


        private const int MOUSEMOVE = 0x0001; // 마우스 이동
        private const int LBUTTONDOWN = 0x0002; // 왼쪽 마우스 버튼 눌림
        private const int LBUTTONUP = 0x0004; // 왼쪽 마우스 버튼 떼어짐
        private const int RBUTTONDOWN = 0x0008; // 오른쪽 마우스 버튼 눌림
        private const int RBUTTONUP = 0x00010; // 오른쪽 마우스 버튼 떼어짐
        private const int ABSOLUTEMOVE = 0x8000; // 전역 위치   


        //상수값
        public const int WM_LBUTTONDOWN = 0x0202;
        public const int WM_LBUTTONUP = 0x0201;

        string savedimagename;
        String AppName = "CorelDRAW 12 - [그래픽1]";
        String AppName2 = "Demo";

        public Macro() // 프린트가 끝났을때
        {
            Thread t1 = new Thread(new ThreadStart(macro_end));
            t1.Start();
        }

        public Macro(string savedimagename) // 프린트 시작
        {
            this.savedimagename = savedimagename;
            macro_start();
        }

        public static void SetFocus(IntPtr handle)
        {
            SetForegroundWindow(handle);
        }

        public void macro_start() // 메크로 시작 ( 디자인 만들기 시작 ) ==>  관리자 권환 실행 필요
        {
            IntPtr findwindow = FindWindow(null, AppName);
            if (findwindow != IntPtr.Zero)
            {
                // 찾았을 경우
                Debug.WriteLine("Start macro.");

                SetCursorPos(970, 490); // 팝업창 위치
                mouse_event(LBUTTONDOWN, 0, 0, 0, 0);
                mouse_event(LBUTTONUP, 0, 0, 0, 0);  
                SendKeys.SendWait("{RIGHT}");
                SendKeys.SendWait("{ENTER}");
                Thread.Sleep(200);

                SetFocus(findwindow); // 코렐 드로우 창 활성화
                
                // 이미지 세팅
                SendKeys.SendWait("^i"); // 다른 형식 불러오기
                Thread.Sleep(100);
                SetCursorPos(970, 320); // 팝업창 위치
                mouse_event(LBUTTONDOWN, 0, 0, 0, 0);
                mouse_event(LBUTTONUP, 0, 0, 0, 0);
                SendKeys.SendWait("n"); // 이름 입력
                Thread.Sleep(100);
                SendKeys.SendWait(savedimagename); // 디자인 이름 입력
                Thread.Sleep(100);
                SetCursorPos(970, 320); // 팝업창 위치
                mouse_event(LBUTTONDOWN, 0, 0, 0, 0);
                mouse_event(LBUTTONUP, 0, 0, 0, 0);
                SendKeys.SendWait("{ENTER}"); // 디자인 불러오기
                Thread.Sleep(300);
                SendKeys.SendWait("{ENTER}"); // 디자인 화면에 불러오기
                Thread.Sleep(1000);

                // 너비 설정
                SetCursorPos(33, 104);// y 위치
                mouse_event(LBUTTONDOWN, 0, 0, 0, 0);
                mouse_event(LBUTTONUP, 0, 0, 0, 0);
                Thread.Sleep(100);
                SetFocus(findwindow);
                SendKeys.SendWait("{TAB}");
                Thread.Sleep(100);
                SetFocus(findwindow);
                SendKeys.SendWait("190");
                Thread.Sleep(100);
                SetFocus(findwindow);
                SendKeys.SendWait("{ENTER}"); // 너비 설정 
                Thread.Sleep(300);

                // 폭 설정
                SetCursorPos(33, 104); // y 위치 
                mouse_event(LBUTTONDOWN, 0, 0, 0, 0);
                mouse_event(LBUTTONUP, 0, 0, 0, 0);
                Thread.Sleep(100);
                SetFocus(findwindow);
                SendKeys.SendWait("{TAB}");
                Thread.Sleep(100);
                SetFocus(findwindow);
                SendKeys.SendWait("{TAB}");
                Thread.Sleep(100);
                SetFocus(findwindow);
                SendKeys.SendWait("190");
                SendKeys.SendWait("{ENTER}"); // 폭 설정
                Thread.Sleep(100);

                // 레이저 커팅 실행
                SetCursorPos(1722, 34); // y 위치 
                mouse_event(LBUTTONDOWN, 0, 0, 0, 0); 
                mouse_event(LBUTTONUP, 0, 0, 0, 0); // 커팅 클릭 
                Thread.Sleep(2000);

                SetCursorPos(955, 270); // y 위치 
                mouse_event(LBUTTONDOWN, 0, 0, 0, 0);
                mouse_event(LBUTTONUP, 0, 0, 0, 0); // 커팅 클릭 
                SendKeys.SendWait("s"); // 프린트 시작

                Process p = Process.GetProcessesByName(AppName2).FirstOrDefault();
                SetFocus(p.MainWindowHandle); // 다시 키오스크 앱 원상 복귀
            }
            else
            {
                // 못찾을경우
                Debug.WriteLine("Coreldraw is not working");
            }
        }


        public void macro_end()
        {
            IntPtr findwindow = FindWindow(null, AppName);
            if (findwindow != IntPtr.Zero)
            {
                // 찾았을 경우
                Debug.WriteLine("Start macro.");

                // 끝나는 창 제거
                SetCursorPos(970, 490); // 팝업창 위치
                mouse_event(LBUTTONDOWN, 0, 0, 0, 0);
                mouse_event(LBUTTONUP, 0, 0, 0, 0); 
                SendKeys.SendWait("{RIGHT}");
                SendKeys.SendWait("{ENTER}");
                Thread.Sleep(200);

                SetFocus(findwindow);
                // 이미지 제거
                SendKeys.SendWait("{DEL}");

            }
            else
            {
                // 못찾을경우
                Debug.WriteLine("Coreldraw is not working");
            }
        }
    }
}


