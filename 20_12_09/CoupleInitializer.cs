/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_09 {
    class Human {
        public string Name;
        public int Age;
    }
    class Couple {
        public Human Husband;
        public Human Wife;
    }
    class CoupleInitializer {
        public static void Main() {
            Couple Inko = new Couple();
            Inko.Husband = new Human();
            Inko.Husband.Name = "차인표";
            Inko.Husband.Age = 40;
            Inko.Wife = new Human();
            Inko.Wife.Name = "신애라";
            Inko.Wife.Age = 38;

            Couple Inko2 = new Couple {
                Husband = new Human { Name = "차인표", Age = 40 },
                Wife = new Human { Name = "신애라", Age = 38 }
            };

            Console.WriteLine($"남편 : {Inko.Husband.Age}세 {Inko.Husband.Name}," +
                $" 아내 : {Inko.Wife.Age}세 {Inko.Wife.Name}");
        }
    }
}
*/