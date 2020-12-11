/*using System;
using System.Collections.Generic;
using System.Text;
using IronPython.Hosting;

namespace _20_12_09 {
    class callPython {
        public static void Main() {
            var python = Python.CreateEngine();
            var scope = python.CreateScope();

            string script = @"
def calcsum(n):
    sum = 0
    for num in range(n + 1):
        sum += sum
    return sum
";
            python.Execute(script, scope);
            dynamic calcsum = scope.GetVariable("calcsum");
            int sum = calcsum(10);
            Console.WriteLine(sum);
        }
    }
}
*/