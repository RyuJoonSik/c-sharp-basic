/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_04 {
    *//* virtual - override : 재정의
       new : 숨김
       비가상 메서드는 항상 정적 타입을 따른다.
       가상 메서드는 동적 타입을 따른다.*//*
    class Base {
        public void Message() { Console.WriteLine("Base Message"); }
    }
    class Derived: Base {
        public new void Message() { Console.WriteLine("Derived Message"); }
    }
    class OverRide {
        public static void Main()
        {
            Base B = new Base();
            Derived D = new Derived();
            B.Message();
            D.Message();
            Base B2 = D;
            B2.Message();
        }
    }
}
*/