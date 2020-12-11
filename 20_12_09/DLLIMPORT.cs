/*using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace _20_12_09 {
    class DLLIMPORT {
        [DllImport("User32.dll")]
        public static extern int MessageBox(int hParent, string Message, string Caption, int Type);

        [DllImport("Kernel32.dll")]
        public static extern uint WinExec(string Path, uint nCmdShow);

        public static void Main() {
            MessageBox(0, "메모장을 실행합니다.", "알림", 0);
            WinExec("notepad.exe", 1);
        }
    }
}
*/