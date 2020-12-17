/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20_12_12 {
    class Staff {
        public Staff(string aName, string aDepart, int aSalary) { Name = aName; Depart = aDepart; Salary = aSalary; }
        public string Name;
        public string Depart;
        public int Salary;
    }

    class SUBQuery {
        public static void Main() {
            Staff[] arStaff = { new Staff("김유신", "관리부", 180),
            new Staff("유관순", "지원부", 190),
            new Staff("안중근", "영업부", 185),
            new Staff("윤봉길", "생산부", 200)};

            *//*int MaxSal = (from p in arStaff select p.Salary).Max();
            IEnumerable<string> Query = from p in arStaff where p.Salary == MaxSal select p.Name;
            foreach(var k in Query) {
                Console.WriteLine("이름 : " + k);
            }*//*

            var Query = from p in arStaff where p.Salary == (from p2 in arStaff select p2.Salary).Max() select p.Name;
            foreach (var k in Query) {
                Console.WriteLine("이름 : " + k);
            }
        }
    }
}
*/