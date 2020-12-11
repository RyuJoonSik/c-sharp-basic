/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_04 {
    class Human {
        protected string Name;
        protected int Age;
        public Human(string aName, int aAge)
        {
            Name = aName;
            Age = aAge;
        }
    }

    class Teacher : Human {
        protected string Subject;
        public Teacher(string aName, int aAge, string aSubject):base(aName, aAge)
        {
            Subject = aSubject;
        }
        public void Teach()
        {
            Console.WriteLine("얘들아 공부 열심히 해라");
        }
    }

    class Thief : Human {
        protected int Career;
        public Thief(string aName, int aAge, int aCareer):base(aName, aAge)
        {
            Career = aCareer;
        }
        public void Steal()
        {
            Console.WriteLine("오늘은 어디를 털어 볼까?");
        }
    }
    class TeacherThief {
        public static void Main()
        {
            Teacher Choi = new Teacher("최상미", 35, "피아노");
            Thief KangDo = new Thief("야월담", 25, 3);
            Choi.Teach();
            KangDo.Steal();
        }
    }
}
*/