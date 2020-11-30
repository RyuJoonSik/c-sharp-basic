/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_11_30 {
    class reflocal {
        static void Main()
        {
            int a = 12;
            *//* 참조할 대상에 대해서도 ref 키워드를 붙인다.(두 변수는 같은 메모리를 가리킨다.)
                초기화 필수 !
                레퍼런스가 다른 변수를 가리키도록 참조를 변경할 수도 있다.*//*
            ref int b = ref a;

            b = 34;
            Console.WriteLine($"a = {a}, b = {b}");

            int c = 58;
            b = ref c;
            b = 78;
            Console.WriteLine($"a = {a}, b = {b}, c = {c}");
        }
    }
}
*/