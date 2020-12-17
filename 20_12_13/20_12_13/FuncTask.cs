/*using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _20_12_13 {
    class FuncTask {
        public static void Main() {
            var evenSumTask = Task<int>.Run(() => {
                int evensum = 0;
                for (int i = 0; i <= 100; i += 2) {
                    Thread.Sleep(50);
                    evensum += i;
                }
                return evensum;
            });

            var oddSumTask = Task<int>.Run(() => {
                int oddsum = 0;
                for(int i=1;i<=100; i += 2) {
                    Thread.Sleep(50);
                    oddsum += i;
                }
                return oddsum;
            });

            evenSumTask.Wait();
            oddSumTask.Wait();

            Console.WriteLine($"매출 총합은 {evenSumTask.Result + oddSumTask.Result}입니다.");
        }
    }
}
*/