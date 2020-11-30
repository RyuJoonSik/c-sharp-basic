/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_11_30 {
    class infiniteloop {
        public static void Main()
        {
            for(; ; )
            {
                Console.WriteLine("앗싸. 게임 한 판 하고");
                Console.Write("또 할래?(Y/N)");
                ConsoleKeyInfo cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.N) break;
                Console.WriteLine();
            }
        }
    }
}
*/