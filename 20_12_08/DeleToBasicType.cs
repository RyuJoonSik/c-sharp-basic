/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_08 {
    delegate void dLong(long a);
    delegate void dInt(int a);

    class DeleToBasicType {
        public static void GetLong(long a) { }
        public static void GetInt(int a) { }
        public static void Main()
        {
            dLong dl;
            dl = GetLong;
            dInt di;
            di = GetInt;
        }
    }
}
*/