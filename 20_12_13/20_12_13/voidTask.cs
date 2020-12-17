/*using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _20_12_13 {
    class voidTask {
        public static void Main() {
            OutNumber();
            Console.Write("알파벳을 출력합니다.");
            for(char ch = 'A'; ch <= 'J'; ch++) {
                Console.Write(ch);
                Thread.Sleep(500);
            }
        }
        public async static void OutNumber() {
            Console.Write("숫자를 출력합니다.");
            await Task.Run(() => {
                for (int i = 1; i <= 5; i++) {
                    Console.Write(i);
                    Thread.Sleep(500);
                }
            });
        }
    }
}
*/