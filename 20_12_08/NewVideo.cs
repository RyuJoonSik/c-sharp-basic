/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_08 {
    delegate void Notice(string Movie);

    class Mania {
        private int id;
        public Mania(int aid) {
            id = aid;
        }
        public void RendMe(string Movie) {
            Console.WriteLine($"{id}번 고객이 {Movie}를 빌려간다.");
        }
    }

    class NewVideo {
        public static void Main() {
            Mania[] arMania = new Mania[10];
            for(int i = 0; i < 10; i++) {
                arMania[i] = new Mania(i);
            }

            Notice RentCall = null;
            RentCall += arMania[1].RendMe;
            RentCall += arMania[4].RendMe;
            RentCall += arMania[6].RendMe;
            RentCall += arMania[9].RendMe;

            RentCall("연필부인 흑심 품었네");
        }
    }
}*/