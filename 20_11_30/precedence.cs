/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_11_30 {
    class precedence {
        public static void Main()
        {
            int a, b = 100000, c = 100000, d = 1000;
            a = b * c / d;
            *//* 백억은 32비트의 범위를 넘어 오버플로우가 발생하며 값의 일부를 잃어 버린다.
             먼저 나눈 후 곱하면 오버플로우를 방지할 수 있다.*//*
            Console.WriteLine(a);
        }
    }
}
*/