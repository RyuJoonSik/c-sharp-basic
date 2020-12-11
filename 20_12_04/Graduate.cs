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
    class Student : Human {
        protected int StNum;
        public Student(string aName, int aAge, int aStNum):base(aName, aAge)
        {
            StNum = aStNum;
        }
        public void Study()
        {
            Console.WriteLine("23은 6, 24 8, 25 10 ,26은 12...");
        }
    }
    class Graduate2 : Student {
        protected string Major;
        public Graduate2(string aName, int aAge, int aStNum, string aMajor):base(aName, aAge, aStNum)
        {
            Major = aMajor;
        }
        public void WriteThesis()
        {
            Console.WriteLine("서론, 본론, 결론 어쩌고 저쩌고");
        }
    }
    class Graduate {
        public static void Main()
        {
            Graduate2 Kwon = new Graduate2("권성직", 51, 9001223, "영화평론학");
            Kwon.WriteThesis();
        }
    }
}
*/