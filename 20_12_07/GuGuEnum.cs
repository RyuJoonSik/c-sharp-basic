/*using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _20_12_07 {
    class GuGuEnum {
        public static IEnumerable Intlerator(int s, int e)
        {
            for (int i = s; i <= e; i++) yield return i;
        }

        public static void Main()
        {
            foreach (int x in Intlerator(1, 9))
                foreach (int y in Intlerator(1, 9))
                    Console.WriteLine($"{x} * {y} = {x * y}");
        }
    }
}
*/