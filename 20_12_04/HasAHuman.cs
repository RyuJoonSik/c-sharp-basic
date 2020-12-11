/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_04 {
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
    
    class Student {
        public Human H;
        protected int StNum;
        public Student(string aName, int aAge, int aStNum)
        {
            StNum = aStNum;
            H = new Human(aName, aAge);
        }
        public void Intro()
        {
            H.Intro();
            Console.WriteLine("학번 : " + StNum);
        }
        public void Study()
        {
            Console.WriteLine("하늘 천 따지 겁을 현 누를 황");
        }
    }
    class HasAHuman {
        public static void Main()
        {
            Student Kim;
            Kim = new Student("김상형", 25, 8906299);
            Kim.Intro();
            Kim.Study();
        }
    }
}
*/