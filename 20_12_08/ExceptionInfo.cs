/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_08 {
    class ExceptionInfo {
        public static int[] ar = { 1, 2, 3, 4, 5 };
        public static int idx = 8;
        public static void Method1() {
            Console.WriteLine(ar[idx]);
        }
        public static void Main() {
            try {
                Method1();
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);
                Console.WriteLine(e.TargetSite);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
*/