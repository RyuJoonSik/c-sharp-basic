/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_08 {
    delegate int Dele(int a, int b);

    class DeleCall {
        public static int Add(int a, int b) {
            return a + b;
        }
        public static void Main() {
            Dele d = Add;
            int k = d(2, 3);
            Console.WriteLine(k);
        }
    }
}
*/