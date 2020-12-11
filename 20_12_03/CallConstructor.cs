/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_03 {
    class CallConstructor {
        public static void Main()
        {
            Human Kim = new Human("김상형", 25);
            Kim.Intro();
            Human Lee = new Human("이순신");
            Lee.Intro();
        }
    }

    class Human {
        private string Name;
        private int Age;

        *//* 필드 초기식은 생성자보다 먼저 실행된다.
         * private string Name = "이름모름";
        private int Age = 22;*/

        /* 코드의 중복을 방지하기 위해 생성자끼리 서로 호출할 수 있다. *//*
        public Human(string aName, int aAge) : this(aName)
        {
            Age = aAge;
        }

        public Human(string aName)
        {
            Name = aName;
            Age = 1;
        }
        
        public void Intro()
        {
            Console.WriteLine($"{Age}살 {Name}입니다.");
        }
    }
}
*/