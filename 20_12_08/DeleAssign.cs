/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_08 {
    delegate int Dele(int a, string b);
    delegate void Deleout(int a, out int b);

    class DeleAssign {
        public static void Main() {
            Dele d1 = delegate (int a, string b) { return 0; };
            Dele d4 = delegate { return 0; };
            int k = d4(1, "abcd");

            Deleout d5 = delegate (int a, out int b) { b = 0; };
        }
    }
}
*/