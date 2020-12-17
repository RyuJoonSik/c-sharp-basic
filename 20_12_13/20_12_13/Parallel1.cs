/*using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _20_12_13 {
    class Parallel {
        public static void Main() {
            for(int student =0;student < 100; student++) {
                CalcScore(student);
            }
        }

        public static void CalcScore(int student) {
            Thread.Sleep(100);
            Console.WriteLine($"{student}번 학생 성적 처리");
        }
    }
}
*/