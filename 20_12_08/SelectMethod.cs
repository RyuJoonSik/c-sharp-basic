/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_08 {
    delegate int IntOp(int a, int b);

    class SelectMethod {
        public static int Add(int a, int b) { return a + b; }
        public static int Mul(int a, int b) { return a * b; }
        public static int Sub(int a, int b) { return a - b; }
        public static void Main()
        {
            IntOp[] arOp = { null, Add, Mul, Sub };
            int a = 3, b = 5;
            int o;
            Console.Write("어떤 연산을 하고 싶습니까? (1:덧셈, 2:곱셈, 3:뺄셈)");
            o = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"결과는 {arOp[o](a, b)} 입니다.");
        }
    }
}
*/