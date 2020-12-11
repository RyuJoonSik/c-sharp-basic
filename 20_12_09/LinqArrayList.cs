/*using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Linq;

namespace _20_12_09 {
    class LinqArrayList {
        public static void Main() {
            ArrayList ar = new ArrayList { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> Query = from int n in ar where (n % 3 == 0) select n*2;
            foreach(int k in Query) {
                Console.WriteLine(k);
            }
        }
    }
}
*/