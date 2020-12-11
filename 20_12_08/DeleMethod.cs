/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_08 {
    delegate int IntOp(int a, int b);
    class DeleMethod {
        public static int Add(int a, int b) { return a + b; }
        public static int Mul(int a, int b) { return a * b; }
        public static void Main()
        {
            int a = 3, b = 5;
            int o;
            Console.WriteLine("어떤 연산을 하고 싶습니까? (1:덧셈, 2:곱셈)");
            o = Convert.ToInt32(Console.ReadLine());
            IntOp op;
            if (o == 1) op = Add; else op = Mul;
            Console.WriteLine($"결과는 {op(a, b)} 입니다.");
        }
    }
}
*/