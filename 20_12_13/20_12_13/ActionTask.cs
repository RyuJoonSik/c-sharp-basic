/*using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _20_12_13 {
    class ActionTask {
        public static void calcSales() {
            int sales = 0;
            for(int i = 0; i <= 100; i++) {
                Thread.Sleep(50);
                sales += i;
            }
            Console.WriteLine($"매출은 {sales}원 입니다.");
        }

        public static void Main() {
            Console.WriteLine("오늘 영업 결산을 시작합니다.");

            Task calcTask = new Task(calcSales);
            calcTask.Start();

            for(int i = 0; i < 3; i++) {
                Console.WriteLine("재고 파악중...");
                Thread.Sleep(1000);
            }
            Console.WriteLine("재고 : 당근 2개, 양파 8개, 무우 3개");

            calcTask.Wait();
        }
    }
}
*/