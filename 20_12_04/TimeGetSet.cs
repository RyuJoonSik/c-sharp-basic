/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_04 {
    class Time {
        private int hour, min, sec;
        public Time(int h, int m, int s) { SetHour(h); SetMin(m); SetSec(s); }
        public int GetHour() { return hour; }
        public void SetHour(int aHour) { if (aHour < 24) hour = aHour; }
        public int GetMin() { return min; }
        public void SetMin(int aMin) { if (aMin < 60) min = aMin; }
        public int GetSec() { return sec; }
        public void SetSec(int aSec) { if (aSec < 60) sec = aSec; }
        public void OutTime()
        {
            Console.WriteLine($"현재 시간은 {hour}시 {min}분 {sec}초이다.");
        }
    }
    class TimeGetSet {
        public static void Main()
        {
            Time Now = new Time(12, 34, 56);
            Now.OutTime();
            Now.SetHour(55);
            Now.OutTime();
            Now.SetMin(55);
            Now.OutTime();
        }
    }
}
*/