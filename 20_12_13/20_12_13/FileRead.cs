/*using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _20_12_13 {
    class FileRead {
        public static void Main() { }
        public static void ReadTextFile() {
            char[] buf;

            using(StreamReader sr = new StreamReader(@"C:\Temp\sample.txt")) {
                int length = (int)sr.BaseStream.Length;
                buf = new char[length];
                sr.Read(buf, 0, length);
            }
            Console.WriteLine(new string(buf));
        }
    }
}
*/