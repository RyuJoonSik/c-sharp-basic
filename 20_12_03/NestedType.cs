/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_03 {
    class Time {
        private class Int60 {
            private int Integer;
            public Int60(int avalue) { Value = avalue; }
            public int Value
            {
                get { return Integer; }
                set { if (value >= 0 && value < 60) Integer = value; }
            }
        }

        private int hour;
        private Int60 min, sec;
        public Time(int aHour, int aMin, int aSec)
        {
            hour = aHour;
            min = new Int60(aMin);
            sec = new Int60(aSec);
        }
        public void OutTime()
        {
            Console.WriteLine($"{hour}시 {min.Value}분 {sec.Value}초");
        }
    }

    class NestedType {
        public static void Main()
        {
            Time Now = new Time(12, 34, 56);
            Now.OutTime();
        }
    }
}
*/