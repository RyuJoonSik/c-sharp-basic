/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_08 {
    class Human {
        public virtual void Intro() { Console.WriteLine("나 사람"); }
    }
    class Student : Human {
        public override void Intro() { Console.WriteLine("나 학생"); }
    }
    class WhereBase {
        public static void OutValue<T>(T man) where T: Human {
            man.Intro();
        }
        public static void Main() {
            Human A = new Human();
            Student B = new Student();
            string C = "나 문자열";

            OutValue(A);
            OutValue(B);
        }
    }
}
*/