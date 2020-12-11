/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_07 {
    interface A1 {
        void a();
    }
    interface A2 {
        void a();
    }

    interface B: A1, A2 {
        void b();
    }

    class C : B {
        public void a() { Console.WriteLine("a"); }
        public void b() { Console.WriteLine("b"); }
    }
    class MultiInheritance {
        public static void Method(B b)
        {
            ((A1)b).a();
        }
        public static void Main()
        {
            C c = new C();
            c.a();
            Method(c);
        }
    }
}
*/