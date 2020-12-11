/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_09 {
    public class Integer {
        public int a;
        public Integer(int aa) { a = aa; }
        public int Add(int b) { return a + b; }
        public int Mul(int b) { return a * b; }
    }
    public static class IntegaerExt {
        public static int Sub(this Integer I, int b) {
            return I.a - b;
        }

    }
    class CSTest {
        public static void Main() {
            Integer num = new Integer(3);
            Console.WriteLine("덧셈 : " + num.Add(2));
            Console.WriteLine("곱셈 : " + num.Mul(2));
            Console.WriteLine("뺄셈 : " + num.Sub(2));
            Console.WriteLine("뺄셈 : " + IntegaerExt.Sub(num, 2));
        }
    }
}
*/