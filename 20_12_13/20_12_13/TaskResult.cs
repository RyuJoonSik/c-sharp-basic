/*using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _20_12_13 {
    class TaskResult {
        public static void Main() {
            int evensum = 0;
            for(int i = 0; i <= 100; i += 2) {
                Thread.Sleep(50);
                evensum += i;
            }

            int oddsum = 0;
            for(int i= 1;i<= 100; i += 2) {
                Thread.Sleep(50);
                oddsum += i;
            }

            Console.WriteLine($"매출 총합은 {evensum + oddsum}입니다.");
        }
    }
}
*/