/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20_12_09 {
    class LinqArray {
        public static void Main() {
            int[] ar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> Query = from n in ar where (n % 3 == 0) select n;
            foreach(var k in Query) {
                Console.WriteLine(k);
            }
        }
    }
}
*/