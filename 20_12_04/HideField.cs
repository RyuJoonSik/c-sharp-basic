/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_04 {
    class Base {
        public int a;
    }
    class Derived : Base {
        public new double a;
    }
    class HideField {
        public static void Main()
        {
            Base B = new Base();
            Derived D = new Derived();
            B.a = 1234;
            D.a = 5.678;
            Console.WriteLine(B.a);
            Console.WriteLine(D.a);
        }
    }
}
*/