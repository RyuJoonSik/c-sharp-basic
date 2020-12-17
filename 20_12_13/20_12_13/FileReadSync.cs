/*using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _20_12_13 {
    class FileReadSync {
        public static void Main() {
            ReadTextFile();
            Console.ReadLine();
        }
        static async void ReadTextFile() {
            char[] buf;

            using (StreamReader sr = new StreamReader(@"c:\Temp\sample.txt")) {
                int length = (int)sr.BaseStream.Length;
                buf = new char[length];
                await sr.ReadAsync(buf, 0, length);
            }
            Console.WriteLine(new string(buf));
        }
    }
}
*/