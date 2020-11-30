/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_11_30 {
    class outpara {
        static void GetPosition(out int x, out int y)
        {
            x = 12;
            y = 34;
        }

        static void Main()
        {
            *//* 초기화 필요 x *//*
            int x;
            int y;
            GetPosition(out x, out y);
            Console.WriteLine($"{x}, {y}");

            *//*GetPosition(out int x, out int y);
            GetPosition(out var x, out var y);
            컴파일러는 호출측에 선언된 출력용 변수를 호출 이전에 선언하는 형태로 바꿔 컴파일한다.
            호출할 때 변수를 선언할 수 있다. *//*
        }
    }
}
*/