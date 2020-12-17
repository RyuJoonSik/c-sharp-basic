/*using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace _20_12_12
{
    class People {
        public People(string aName, int aAge, bool bMale) {
            Name = aName; Age = aAge; Male = bMale;
        }
    
        public string Name;
        public int Age;
        public bool Male;
    }
    class Program
    {
        static void Main(string[] args)
        {
            People[] arPeople = { new People ("정우성", 36, true),
                new People("고소영", 32, false),
                new People("배용준", 37, true),
                new People("김태희", 29, false)};

            var Query = new XElement("사람들", from p in arPeople
                                            select
                         new XElement("사람", new XElement("이름", p.Name), new XElement("나이", p.Age), new XElement("남자", p.Male)));
            Console.WriteLine(Query);

            IEnumerable<People> Query2 = from p in arPeople where p.Age % 2 == 0 select p;
            foreach(People k in Query2) {
                Console.WriteLine("이름 : " + k.Name + ", 나이 : " + k.Age + ", 남자 : " + k.Male);
            }

            IEnumerable<People> Query3 = from p in arPeople where p.Age % 2 == 0 && p.Male == true select p;
            IEnumerable<People> Query4 = from p in arPeople orderby p.Age select p;
            IEnumerable<People> Query5 = from p in arPeople orderby p.Age descending select p;
            IEnumerable<People> Query6 = from p in arPeople orderby p.Male ascending, p.Name descending select p;
            IEnumerable<char> Query7 = from p in arPeople select p.Name[0];
            foreach(char k in Query7) {
                Console.WriteLine(k);
            }
            IEnumerable<char> Query8 = from p in arPeople let x = p.Name[0] where x == '김' select x;
            *//* let 절은 쿼리문내의 변수 선언문이며 결과에 직접적인 영향을 미친다기보다 쿼리를 읽기 쉽게 만드는 역할을 한다.*//*
        }
    }
}
*/