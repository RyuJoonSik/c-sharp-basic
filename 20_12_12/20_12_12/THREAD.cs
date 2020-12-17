using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _20_12_12 {
    class THREAD {
        // 작업 스레드
        public static void ThreadProc(object count) {
            for(int i = 0; i < (int)count; i++) {
                Console.Write(i + ",");
                Thread.Sleep(500);
            }
            Console.WriteLine("작업 스레드 종료");
        }

        public static void Main() {
            Thread T = new Thread(new ParameterizedThreadStart(ThreadProc));
            T.IsBackground = true;
            T.Start(5);
            for(; ; ) {
                ConsoleKeyInfo cki;
                cki = Console.ReadKey();
                if(cki.Key == ConsoleKey.A) {
                    Console.Beep();
                }
                if(cki.Key == ConsoleKey.B) {
                    break;
                }
            }
            Console.WriteLine("주 스레드 종료");
        }
    }
}
