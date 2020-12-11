/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_04 {
    class Time {
        private int hour, min, sec;
        public Time(int h, int m, int s) { Hour = h; Min = m; Sec = s; }
        public int Hour
        {
            get { return hour; }
            set { if (value < 24) hour = value; }
        }
        public int Min
        {
            get { return min; }
            set { if (value < 60) min = value; }
        }
        public int Sec
        {
            get { return sec; }
            set { if (value < 60) sec = value; }
        }
        public void OutTime()
        {
            Console.WriteLine($"현재 시간은 {hour}시 {min}분 {sec}초이다.");
        }
    }
    class TimeProperty {
        public static void Main() {
            Time Now;
            Now = new Time(12, 34, 56);
            Now.OutTime();
            Now.Hour = 55;
            Now.OutTime();
            Now.Min = 55;
            Now.OutTime();

            Console.WriteLine(Now.Hour);
            Console.WriteLine(Now.Min);
            Console.WriteLine(Now.Sec);
        }
        
    }
}
*/