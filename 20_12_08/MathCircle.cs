/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_08 {
    class MathCircle {
        public static void Main() {
            for (double angle = 0; angle < 360; angle += 10) {
                Console.CursorLeft = 40 + (int)(Math.Cos(angle * Math.PI / 180) * 20);
                Console.CursorTop = 12 + (int)(Math.Sin(angle * Math.PI / 180) * 10);
                Console.Write('o');
            }
        }
    }
}
*/