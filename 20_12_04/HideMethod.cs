/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_04 {
    class Base {
        public void Message() { Console.WriteLine("Base Message"); }
    }
    class Derived : Base {
        public new void Message() { Console.WriteLine("Derived Message"); }
        public void Original() { base.Message(); }
    }
    class HideMethod {
        public static void Main()
        {
            Base B = new Base();
            Derived D = new Derived();
            B.Message();
            D.Message();
            D.Original();
        }
    }
}
*/