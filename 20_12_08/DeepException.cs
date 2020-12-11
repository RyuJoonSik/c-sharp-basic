/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_08 {
    class DeepException {
        public static int[] ar = { 1, 2, 3, 4, 5 };
        public static int idx = 8;
        public static void Main() {
            try {
                Method1();
            }
            catch(IndexOutOfRangeException e) {
                Console.WriteLine(e.Message);
            }
        }
        public static void Method1() {
            Method2();
        }
        public static void Method2() {
            Console.WriteLine(ar[idx]);
        }
    }
}
*/