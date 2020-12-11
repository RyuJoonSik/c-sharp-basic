/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_08 {
    delegate bool ComProg(int nFile);

    class Archive {
        public static bool Compress(int nFile, ComProg Prog) {
            for (int i = 0; i < nFile; i++) {
                if (Prog(i) == false) {
                    return false;
                }
                System.Threading.Thread.Sleep(500);
            }
            return true;
        }
    }
    class CallBack3 {
        public static bool Progress(int nFile) {
            Console.WriteLine($"{nFile + 1}번째 파일을 압축하는 중입니다(취소시 Esc).");
            if (Console.KeyAvailable) {
                ConsoleKeyInfo cki;
                cki = Console.ReadKey(true);
                if(cki.Key == ConsoleKey.Escape) {
                    return false;
                }
            }
            return true;
        }
        public static void Main() {
            if(Archive.Compress(10, Progress) == true) {
                Console.WriteLine("모든 파일을 압축했습니다.");
            } else {
                Console.WriteLine("취소되었습니다.");
            }
        }
    }
}
*/