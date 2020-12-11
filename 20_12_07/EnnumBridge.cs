/*using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _20_12_07 {
    class HanBridge {
        static string[] Bridge = { "팔당", "강동", "광진" };
        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < Bridge.Length; i++)
            {
                yield return Bridge[i];
            }
        }
    }
    class EnnumBridge {
        public static void Main()
        {
            HanBridge hb = new HanBridge();
            foreach(string b in hb)
            {
                Console.WriteLine(b);
            }
        }
    }
}
*/