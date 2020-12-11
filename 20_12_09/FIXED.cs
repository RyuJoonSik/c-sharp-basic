/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_09 {
    class FIXED {
        public static void Main() {
            int[] ar = { 1, 2, 3, 4, 5 };
            unsafe {
                fixed(int *pi = &ar[0]) {
                    for(int i = 0; i < 5; i++) {
                        Console.Write(pi[i] + " ");
                    }
                }
            }
        }
    }
}
*/