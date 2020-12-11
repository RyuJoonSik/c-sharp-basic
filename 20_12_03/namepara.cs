using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_03 {
    class namepara {
        public static int CalcSum(int from, int to, int step)
        {
            int sum = 0;
            for (int i = from; i <= to; i += step)
            {
                sum += i;
            }
            return sum;
        }
        public static void Main()
        {
            Console.WriteLine("5 ~ 10 = " + CalcSum(5, 10, 1));
            Console.WriteLine("5 ~ 10 = " + CalcSum(from: 5, to: 10, step: 1));
            Console.WriteLine("5 ~ 10 = " + CalcSum(step: 1, from: 5, to: 10));
        }
    }
}
