/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_09 {
    class VarPattern {
        public static void Main() {
            string file = "girl.jpg";
            switch (file) {
                case var ext when ext.Contains(".jpg"):
                    Console.WriteLine("JPEG 파일");
                    break;
                case var ext when ext.Contains(".png"):
                    Console.WriteLine("PNG 파일");
                    break;
                case null:
                    Console.WriteLine("무효한 파일입니다.");
                    break;
            }
        }
    }
}*/