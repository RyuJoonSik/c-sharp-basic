/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_08 {
    class Archive {
        public static void Compress(int nFile)
        {
            for(int i = 0; i < nFile; i++)
            {
                Console.WriteLine($"{i + 1}번째 파일을 압축하는 중이다...");
                System.Threading.Thread.Sleep(500);
            }
        }
    }
    class CallBack {
        public static void Main()
        {
            Archive.Compress(10);
            Console.WriteLine("모든 파일을 압축했습니다.");
        }
    }
}*/