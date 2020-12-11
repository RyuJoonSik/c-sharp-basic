/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_07 {
    interface IUnit {
        void Move(int x, int y);
        void Attack(int x, int y);
        void Die();
    }
    class Marine:IUnit {
        public void Move(int x, int y) { Console.WriteLine("아장 아장"); }
        public void Attack(int x, int y) { Console.WriteLine("두두두두"); }
        public void Die() { Console.WriteLine("으아악"); }
    }

    class CSTest {
        public static void Main()
        {
            Marine M = new Marine();
            M.Move(5, 5);
            M.Attack(10, 10);
            M.Die();
        }
    }
}
*/