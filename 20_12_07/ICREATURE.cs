/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_07 {
    interface ICreature {
        void Propagate();
    }

    interface IPlant : ICreature {
        void Flower();
    }
    interface IAnimal : ICreature {
        void Move();
    }

    class Lion: IAnimal {
        public void Move() { Console.WriteLine("왔다리 갔다리"); }
        public void Propagate() { Console.WriteLine("이걸 어떻게 표현하지?"); }
    }
    class ICREATURE {
        public static void Main()
        {
            Lion Simba = new Lion();
            Simba.Move();
        }
    }
}
*/