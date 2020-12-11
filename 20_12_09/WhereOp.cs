/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20_12_09 {
    class WhereOp {
        public static bool Is3Tims(int x) {
            return x % 3 == 0;
        }
        public static void Main() {
            int[] ar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var Query = ar.Where(Is3Tims);
            //var Query = ar.Where(delegate (int x) { return x % 3 == 0; });
            var Query = ar.Where(x => x % 3 == 0);
            foreach(var k in Query) {
                Console.WriteLine(k);
            }
        }
    }
}
*/