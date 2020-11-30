/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_11_30 {
    class refreturn {
        static int[] arScore = { 11, 22, 33, 44, 55 };

        static ref int GetScore(int student)
        {
            return ref arScore[student];
        }

        static void Main()
        {
            Console.WriteLine(arScore[2]);
            GetScore(2) = 100;
            *//* ref로 리턴하는 갑은 변경 가능하고 리턴 후에도 계속 남아 있어야 한다.
                지역변수는 함수 리턴후 사라져 버려 참조로 리턴할 수 없다. *//*
            Console.WriteLine(arScore[2]);
        }
    }
}
*/