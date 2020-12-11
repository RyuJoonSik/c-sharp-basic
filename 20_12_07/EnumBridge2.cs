/*using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _20_12_07 {
    class HanBridge {
        static string[] Bridge = { "팔당", "강동", "광진" };
        public IEnumerable EastToWest()
        {
            for(int i = 0; i < Bridge.Length; i++)
            {
                yield return Bridge[i];
            }
        }

        public IEnumerable WestToEast()
        {
            for(int i = Bridge.Length-1; i>=0; i--)
            {
                yield return Bridge[i];
            }
        }
    }
    class EnumBridge2 {
        public static void Main()
        {
            HanBridge hb = new HanBridge();
            foreach(string b in hb.EastToWest())
            {
                Console.WriteLine(b);
            }
            foreach(string b in hb.WestToEast())
            {
                Console.WriteLine(b);
            }
        }
    }
}
*/