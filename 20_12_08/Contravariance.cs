/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_08 {
    class Base { }
    class Derived : Base { }

    delegate void dBase(Base a);
    delegate void dDerived(Derived a);
    class Contravariance {
        public static void GetBase(Base a) { }
        public static void GetDerived(Derived a) { }
        public static void Main()
        {
            dBase db;
            db = GetBase;
            dDerived dd;
            dd = GetDerived;

            dd = GetBase;
            dd(new Derived());
        }
    }
}
*/