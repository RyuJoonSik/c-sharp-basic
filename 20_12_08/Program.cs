/*using System;

namespace _20_12_08 {
    class Base { }
    class Derived : Base { }

    delegate Base dBase();
    delegate Derived dDerived();

    class Program {
        public static Base GetBase() { return new Base(); }
        public static Derived GetDerived() { return new Derived(); }
        static void Main(string[] args)
        {
            dBase db;
            db = GetBase;
            dDerived dd;
            dd = GetDerived;

            db = GetDerived;
            Base b = db();
            Derived d = dd();
        }
    }
}
*/