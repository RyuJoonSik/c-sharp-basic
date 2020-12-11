/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_07 {
    delegate void Dele(int a);
    class DELEGATE {
        public static void Method1(int a) { Console.WriteLine("Method1 " + a); }
        public static void Method2(int a) { Console.WriteLine("Method2 " + a); }
        public static void Main()
        {
            Dele d;
            d = Method1;
            d(12);
            d = Method2;
            d(34);
        }
    }
}
*/