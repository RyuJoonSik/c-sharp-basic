/*using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _20_12_13 {
    class Parallel2 {
        public static void Main() {
            Parallel.For(10, 20, CalcScore);
        }

        public static void CalcScore(int student) {
            Thread.Sleep(100);
            Console.WriteLine($"{student}번 학생 성적 처리");
        }
    }
}
*/