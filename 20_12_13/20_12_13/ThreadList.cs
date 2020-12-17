/*using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace _20_12_13 {
    class ThreadList {
        public static void Main() {
            Process Proc = Process.GetProcessById(7020);
            ProcessThreadCollection col = Proc.Threads;
            foreach (ProcessThread T in col) {
                Console.WriteLine("ID = {0} 우선순위 = {1}", T.Id, T.PriorityLevel);
            }
        }
    }
}
*/