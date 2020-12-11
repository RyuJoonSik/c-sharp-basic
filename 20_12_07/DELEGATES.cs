/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_07 {
    delegate int Delea(string s);
    delegate double Deleb(int i, long l);
    delegate void Delec(char ch);

    class DELEGATES {
        public static int a(string s) { Console.WriteLine(s); return 0; }
        public static double b(int i, long l) { Console.WriteLine(i); return 1.0; }
        public static void c(char ch) { Console.WriteLine(ch); }

        public static void Main()
        {
            Delea da = a;
            da("a 메서드");
            Deleb db = b;
            db(1234, 5678);
            Delec dc = c;
            dc('델');
        }
    }
}
*/