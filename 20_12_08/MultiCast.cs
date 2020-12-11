/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_08 {
    delegate void Dele(int a);
    class MultiCast {
        public static void Method1(int a) { Console.WriteLine("Method1 " + a); }
        public static void Method2(int a) { Console.WriteLine("Method2 " + a); }
        public static void Main() {
            *//* 여러 메서드를 한거번에 호출하려면 리턴 타입은 void여야 한다. *//*
            Dele d = null;
            d = Method1;
            d += Method2;
            d(34);
        }
    }
}
*/