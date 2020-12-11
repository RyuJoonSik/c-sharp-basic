/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_08 {
    delegate void ComProg(int nFile);

    class Archive {
        public static void Compress(int nFile, ComProg Prog)
        {
            for (int i = 0; i < nFile; i++)
            {
                Prog(i);
                System.Threading.Thread.Sleep(500);
            }
        }
    }

    class CallBack2 {
        public static void Progress(int nFile) {
            Console.WriteLine($"{nFile + 1}번째 파일을 압축하는 중입니다.");
        }
        public static void EngProgress(int nFile) {
            Console.WriteLine($"Now Compressing {nFile + 1}File.Wait please");
        }
        public static void Main() {
            Archive.Compress(10, Progress);
            Console.WriteLine("모든 파일을 압축했습니다.");
        }
    }
}*/