/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_03 {
    class Birth {
        public static void Main()
        {
            Human Kim;
            Kim = new Human("김상형", 1980, 6, 29);
            Kim.Intro();
        }
    }

    class Human {
        private class Date {
            int y, m, d;
            public Date(int ay, int am, int ad)
            {
                y = ay;
                m = am;
                d = ad;
            }
            public void OutDate()
            {
                Console.WriteLine($"{y}년 {m}월 {d}일");
            }
        }
        private string Name;
        private Date Birth;
        public Human(string aName, int ay, int am, int ad)
        {
            Name = aName;
            Birth = new Date(ay, am, ad);
        }
        public void Intro()
        {
            Console.Write("이름 : " + Name);
            Console.Write(", 생년월일 : ");
            Birth.OutDate();
        }
    }
}
*/