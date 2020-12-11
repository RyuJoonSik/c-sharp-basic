/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_09 {
    class STACKALLOC {
        public static void Main() {
            unsafe {
                int* pi = stackalloc int[5];
                for (int i = 0; i < 5; i++) {
                    pi[i] = i * 2;
                    Console.Write(pi[i] + " ");
                }
                int* pi2 = stackalloc int[5] { 0, 2, 4, 6, 8 };
            }

        }
    }
}
*/