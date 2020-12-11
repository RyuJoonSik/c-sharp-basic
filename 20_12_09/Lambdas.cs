/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_09 {
    delegate int Dele1(int a, int b);
    delegate int Dele2();
    delegate void Dele3();

    class Lambdas {
        public static void Main() {
            Dele1 d1 = (x, y) => x + y;
            int b = d1(4, 5);
            Console.WriteLine("b = " + b);

            Dele2 d2 = () => 1234;
            int c = d2();
            Console.WriteLine("c = " + c);

            Dele3 d3 = () => { Console.WriteLine("명령문으로 된 람다"); };
            d3();
                }
    }
}
*/