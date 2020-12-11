/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_08 {
    delegate int Dele(int a, int b);

    class Capture {
        public static void SetDelegate(out Dele d) {
            int k = 5;
            d = delegate (int a, int b) { return a + b + k; };
        }

        public static void Main() {
            Dele d;
            SetDelegate(out d);
            int z = d(2, 3);
            int c = d(4, 3);
            Console.WriteLine(z);
            Console.WriteLine(c);
        }
    }
}
*/