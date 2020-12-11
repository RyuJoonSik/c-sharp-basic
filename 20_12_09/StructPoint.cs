/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_09 {
    class StructPoint {
        public static void Main() {
            Position pos = new Position(10, 20);
            unsafe {
                Position* pPos;
                pPos = &pos;
                Console.WriteLine((*pPos).x);
                Console.WriteLine(pPos->y);
            }
        }
    }

    struct Position {
        public int x, y;
        public Position(int ax, int ay) { x = ax; y = ay; }
    }
}
*/