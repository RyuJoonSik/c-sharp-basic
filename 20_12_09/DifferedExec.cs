/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20_12_09 {
    class DifferedExec {
        public static void Main() {
            int[] ar = { 1, 2, 3, 4, 5 };
            var Query = (from n in ar select n).ToList();
            foreach(int k in Query) {
                Console.Write(k + ",");
            }
            Console.WriteLine();

            ar[2] = 9999;
            foreach(int k in Query) {
                Console.Write(k + ",");
            }
            Console.WriteLine();
        }
    }
}
*/