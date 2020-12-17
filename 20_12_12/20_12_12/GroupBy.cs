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
    class GroupBy {
        public static void Main() {
            Staff[] arStaff = { new Staff("김유신", "관리부", 180),
            new Staff("유관순", "지원부", 190),
            new Staff("안중근", "영업부", 185),
            new Staff("윤봉길", "생산부", 200)};

            *//*IEnumerable<IGrouping<char, Staff>> Query = from p in arStaff group p by p.Depart[0];

                foreach (IGrouping<char, Staff> g in Query) {
                    Console.WriteLine("\r\n" + g.Key);
                    foreach(Staff k in g) {
                        Console.WriteLine("이름 : " + k.Name + ", 월급 : " + k.Salary);
                    }
                }*/
            /*var Query = from p in arStaff group p by p.Salary >= 200;
            foreach(var g in Query) {
                Console.WriteLine("\r\n" + (g.Key ? "200만원 이상" : "200만원 이하"));
                foreach(Staff k in g) {
                    Console.WriteLine("이름 : " + k.Name + ", 월급 : " + k.Salary);
                }
            }*/

            /*var Query = from p in arStaff group p by p.Depart into gp orderby gp.Key select gp;
            foreach(var g in Query) {
                Console.WriteLine("\r\n" + g.Key);
                foreach(Staff k in g) {
                    Console.WriteLine("이름 : " + k.Name + ", 월급 : " + k.Salary);
                }
            }*//*

            IEnumerable<IGrouping<string, Staff>> Query = from p in arStaff group p by p.Depart
                                                          into gp where gp.Key == "관리부" select gp;
            foreach (var g in Query) {
                Console.WriteLine("\r\n" + g.Key);
                foreach (Staff k in g) {
                    Console.WriteLine("이름 : " + k.Name + ", 월급 : " + k.Salary);
                }
            }
        }
    }
}
*/