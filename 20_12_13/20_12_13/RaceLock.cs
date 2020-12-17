/*using System;
using System.Threading;

namespace _20_12_13 {
    class Site {
        public string name;
        public Site(string aName) { name = aName; }
    }

    class RaceLock {
        private static Site site = new Site("www.soen.kr");
        public static void ThreadProc() {
            for (int i = 0; i <= 1000; i += 10) {
                lock (site) {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("{0}에서 {1}% 다운로드 중", site.name);
                }
                Thread.Sleep(1000);
            }
        }
        public static void DoSomething() {
            string old = site.name;
            site.name = "www.kupang.kr";
            for (int i = 0; i <= 100; i += 10) {
                Console.SetCursorPosition(0, 1);
                Console.WriteLine("{0}에서 {1}% 다운로드 중", site.name, i);
                Thread.Sleep(500);
            }
            site.name = old;
        }
        static void Main(string[] args) {
            Thread T = new Thread(new ThreadStart(ThreadProc));
            T.Start();
            Thread.Sleep(2000);
            lock (site) {
                DoSomething();
            }
        }
    }
}
*/