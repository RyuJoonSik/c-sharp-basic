/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_09 {
    class DeconClass {
        public static void Main() {
            Human yoon;
            yoon = new Human("윤봉길", 24);
            (int Age, string Name) = yoon;
            Console.WriteLine($"{Age}세 {Name}");
        }
    }
    class Human {
        private string Name;
        private int Age;
        public Human(string aName, int aAge) {
            Name = aName;
            Age = aAge;
        }
        public void Intro() {
            Console.WriteLine($"{Age}살 {Name}입니다.");
        }
        
        public void Deconstruct(out int Age, out string Name) {
            Age = this.Age;
            Name = this.Name;
        }
    }
}
*/