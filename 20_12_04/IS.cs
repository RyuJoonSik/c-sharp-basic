/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_04 {
    class Human { }
    class Student : Human { }
    class Graduate : Student { }
    class Assistant : Human { }
    class Professor : Human { }
    class Suwi : Human { }
    class IS {
        public static void Register(Human H)
        {
            if(H is Student || H is Assistant)
            {
                Console.WriteLine("등록했다 치고");
            }
            else
            {
                Console.WriteLine("학생이 아니므로 등록 안됨");
            }

            *//* as 연산자는 참조 타입에만 사용할 수 있다. *//*
            Student S = H as Student;
            Assistant A = H as Assistant;
            if(S != null ||  A != null)
            {
                Console.WriteLine("등록했다 치고");
            }
            else
            {
                Console.WriteLine("학생이 아니므로 등록 안됨");
            }

            *//*if(H is Student T)
            {
                T.Study();
            }*/
            /* is 연산자의 우변은 타입이지만 상수도 사용할 수 있다.(리터럴, const 상수, 열거형 상수, null)*//*
        }

        public static void Main()
        {
            Graduate Kim = new Graduate();
            Assistant Lee = new Assistant();
            Professor Park = new Professor();
            Suwi Choi = new Suwi();
            Register(Kim);
            Register(Lee);
            Register(Park);
            Register(Choi);
        }
    }
}
*/