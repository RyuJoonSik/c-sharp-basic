/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_08 {
    delegate int Dele(int a, int b);

    class AnonPara {
        public static int Calc(Dele d) {
            return d(3, 4);
        }

        public static void Main() {
            int k;
            k = Calc(delegate (int a, int b) { return a + b; });
            Console.WriteLine(k);
            k = Calc(delegate (int a, int b) { return a * b; });
            Console.WriteLine(k);
        }
    }
}
*/