/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_04 {
    class Time {
        private int hour, min, sec;
        public Time() { }
        public Time(int h, int m, int s) { hour = h; min = m; sec = s; }
        public void OutTime()
        {
            Console.WriteLine($"{hour}시 {min}분 {sec}초");
        }
        public static Time operator++(Time A)
        {
            Time T = new Time();
            T.hour = A.hour;
            T.min = A.min;
            T.sec = A.sec;

            T.sec++;
            T.min += T.sec / 60;
            T.sec %= 60;
            T.hour += T.min / 60;
            T.min %= 60;
            return T;
        }
    }
    class TimePlusPlus {
        public static void Main()
        {
            Time A = new Time(1, 1, 1);
            Time t1, t2;
            t1 = A++;
            t2 = ++A;
            A++;

            t1.OutTime();
            t2.OutTime();
            A.OutTime();
        }
    }
}
*/