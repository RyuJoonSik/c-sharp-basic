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
        public static bool operator==(Time A, Time B)
        {
            return (A.hour == B.hour && A.min == B.min && A.sec == B.sec);
        }
        public static bool operator!=(Time A, Time B)
        {
            return !(A == B);
        }
    }
    class TimeEqual {
        public static void Main()
        {
            Time A = new Time(5, 5, 5);
            Time B = new Time(5, 5, 5);
            Time C = new Time(6, 6, 6);
            Console.WriteLine("A와 B는 {0}", (A == B ? "같다" : "다르다"));
            Console.WriteLine("A와 B는 {0}", (A == C ? "같다" : "다르다"));
        }
    }
}
*/