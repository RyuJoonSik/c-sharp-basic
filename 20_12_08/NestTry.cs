/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_08 {
    class NestTry {
        public static void Main() {
            int Price, Num, Total = 0;
            try {
                Console.WriteLine("단가를 입력하시오 : ");
                Price = Convert.ToInt32(Console.ReadLine());
                Console.Write("개수를 입력하시오 :");
                try {
                    Num = Convert.ToInt32(Console.ReadLine());
                    checked { Total = (short)(Price * Num); }
                }
                catch(OverflowException e) {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("총 가격은 {0}입니다.", Total);
            }
            catch(FormatException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
*/