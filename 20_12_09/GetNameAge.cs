using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20_12_09 {
    class People {
        public People(string aName, int aAge, bool bMale) { Name = aName; Age = aAge; Male = bMale; }
        public string Name;
        public int Age;
        public bool Male;
    }
    class ResultNameAge {
        public ResultNameAge(string aName, int aAge) {
            Name = aName;
            Age = aAge;
        }
        public string Name;
        public int Age;
    }
        class GetNameAge {
        public static void Main() {
            People[] arPeople = {new People("정우성", 36, true), new People("고소영", 32, false),
            new People("배용준", 37, true), new People("김태희", 29, false)};

            /*IEnumerable<ResultNameAge> Query = from p in arPeople select new ResultNameAge(p.Name, p.Age);*/
            var Query = from p in arPeople select new { p.Name, p.Age };
            foreach(var k in Query) {
                Console.WriteLine("이름 : " + k.Name + ", 나이 : " + k.Age);
            }
        }
    }
}
