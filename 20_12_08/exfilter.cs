using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_08 {
    class exfilter {
        public static void Main() {
            int[] ar = { 1, 2, 3, 4, 5 };
            int idx = -10;

            try {
                Console.WriteLine(ar[idx]);
            }
            catch(IndexOutOfRangeException e) when (idx < 0) {
                Console.WriteLine("음수 첨자는 쓸 수 없음.");
            }
            catch(IndexOutOfRangeException e) {
                Console.WriteLine("첨자가 너무 큼");
            }
        }
    }
}
