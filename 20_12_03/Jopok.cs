/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_03 {
    class CSTest {
        public static void Main()
        {
            Jopok NalaliPa;
            NalaliPa = new Jopok("김상형", 25, 500);
            NalaliPa.Intro();
        }
    }

    class Human {
        private string Name;
        private int Age;
        public Human(string aName, int aAge)
        {
            Name = aName;
            Age = aAge;
        }
        public void Intro()
        {
            Console.WriteLine($"{Age}살 {Name}입니다.");
        }
    }

    class Jopok {
        readonly private Human Dumok;
        private int Jolgae;
        public Jopok(string aName, int aAge, int aJolgae)
        {
            Dumok = new Human(aName, aAge);
            Jolgae = aJolgae;
        }
        public void Intro()
        {
            Console.Write("대빵 : ");
            Dumok.Intro();
            Console.WriteLine($"조직원 : {Jolgae}명");
        }
    }
}
*/