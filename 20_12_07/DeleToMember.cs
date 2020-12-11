using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_07 {
    delegate void Dele(string s);
    class DeleToMember {
        public static void m1(string s) { Console.WriteLine(s); }
        public void m2(string s) { Console.WriteLine(s); }
        public static void Main()
        {
            Dele d = m1;
            d("정적 메서드");
            DeleToMember CS = new DeleToMember();
            d = CS.m2;
            d("인스턴스 메서드");

            d = Outer.m3;
            d("외부 정적 메서드");
            Outer O = new Outer();
            d = O.m4;
            d("외부 인스턴스 메서드");
        }
    }

    class Outer {
        public static void m3(string s) { Console.WriteLine(s); }
        public void m4(string s) { Console.WriteLine(s); }
    }
}
