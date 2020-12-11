/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_03 {
    class overoption {
        public static int CalcSum(int from, int to)
        {
            return CalcSum(from, to, 1);
        }
        public static int CalcSum(int from, int to, int step)
        {
            int sum = 0;
            for(int i = from; i <= to; i += step)
            {
                sum += i;
            }
            return sum;
        }
        public static void Main()
        {
            Console.WriteLine("1 ~ 10 = " + CalcSum(1, 10));
            Console.WriteLine("1 ~ 10 홀수 = " + CalcSum(1, 10, 2));
        }
    }
}
*/