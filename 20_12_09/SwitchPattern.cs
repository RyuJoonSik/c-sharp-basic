/*using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _20_12_09 {
    class SwitchPattern {
        public static void OutScore(object score){
            switch (score) {
                case null:
                    Console.WriteLine("성적 정보 없음");
                    break;
                case 100:
                    Console.WriteLine("만점");
                    break;
                case int value when value < 0 || value > 100:
                    Console.WriteLine("무효한 성적");
                    break;
                case int value:
                    Console.WriteLine(value);
                    break;
                case string why:
                    Console.WriteLine(why);
                    break;
                case DateTime tran:
                    Console.WriteLine(tran + "에 전학감");
                    break;
                case ArrayList list:
                    foreach(int a in list) {
                        Console.Write(a + ",");
                    }
                    Console.WriteLine();
                    break;
            }
        }

        public static void Main() {
            OutScore(88);
            OutScore(null);
            OutScore("결석");
            OutScore(new DateTime(2020, 4, 15));
            OutScore(100);
            ArrayList ar = new ArrayList();
            ar.Add(70);
            ar.Add(80);
            ar.Add(90);
            OutScore(ar);
        }
    }
}
*/