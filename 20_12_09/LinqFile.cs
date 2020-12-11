/*using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _20_12_09 {
    class LinqFile {
        public static void Main() {
            var Files = from f in Directory.GetFiles("c:\\") select f;
            foreach(var f in Files) {
                Console.WriteLine("이름 : " + f);
            }
        }
    }
}
*/