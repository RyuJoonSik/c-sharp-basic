/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_01 {
    class switchref {
        public static void Main()
        {
            int a = 1;
            int b = 2;

            Console.WriteLine($"a = {a}, b = {b}");
            *//*참조를 리턴할 수도 있다. 조건에 따라 변수나 배열의 요소를 선택할 수 있으며
             참조는 좌변값이어서 변경할 수도 있다.*//*
            ref int r = ref (a > b ? ref a : ref b);
            r = 1234;
            Console.WriteLine($"a = {a}, b = {b}");
        }
    }
}
*/