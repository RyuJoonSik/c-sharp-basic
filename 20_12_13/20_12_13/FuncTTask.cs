/*using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _20_12_13 {
    class FuncTTask {
        public static void Main() {
            Func<object, int> sumFunc = (to) => {
                int sum = 0;
                for (int i = 0; i <= (int)to; i++) {
                    Thread.Sleep(50);
                    sum += i;
                }
                return sum;
            };
            var sumTask = new Task<int>(sumFunc, 20);
            sumTask.Start();

            sumTask.Wait();

            Console.WriteLine($"매출 총합은 {sumTask.Result} 입니다.");
        }
    }
}
*/