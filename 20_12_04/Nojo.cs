/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_04 {
    class Staff { public int Salary = 100; }
    class Manager : Staff { }
    class Personnel: Staff { }
    class Account : Staff { }
    class Finance : Staff { }

    class Nojo {
        public static void Main()
        {
            Staff[] nojo = new Staff[5];
            nojo[0] = new Manager();
            nojo[1] = new Personnel();
            nojo[2] = new Account();
            nojo[3] = new Manager();
            nojo[4] = new Finance();

            foreach(Staff s in nojo)
            {
                PrintSalary(s);
            }
        }
        public static void PrintSalary(Staff who)
        {
            Console.WriteLine(who.Salary);
        }
    }
}
*/