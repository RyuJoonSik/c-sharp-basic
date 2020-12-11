/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_08 {
    class Time {
        public int hour, min, sec;
        public Time(int h, int m, int s) { hour = h; min = m; sec = s; }
        public void OutTime() {
            Console.WriteLine($"현재 시간은 {hour}시 {min}분 {sec}초이다.");
        }
        public override string ToString() {
            return hour + "시" + min + "분" + sec + "초";
        }
    }
    class TimeToString {
        public static void Main() {
            Time Now = new Time(18, 25, 55);
            Now.OutTime();
            Console.WriteLine(Now);
            Console.WriteLine(Now.ToString());
        }
    }
}
*/