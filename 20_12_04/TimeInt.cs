/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_04 {
    class Time {
        public int hour, min, sec;
        public Time() { }
        public Time(int h, int m, int s) { hour = h; min = m; sec = s; }
        public void OutTime()
        {
            Console.WriteLine($"현재 시간은 {hour}시 {min}분 {sec}초이다.");
        }
        public static implicit operator int(Time T)
        {
            return T.hour * 3600 + T.min * 60 + T.sec;
        }
        public static explicit operator Time(int abs)
        {
            Time T = new Time();
            T.hour = abs / 3600;
            T.min = (abs / 60) % 60;
            T.sec = abs % 60;
            return T;
        }
    }
    class TimeInt {
        public static void Main()
        {
            Time Now = new Time(12, 30, 40);
            Now.OutTime();
            int absec = Now; *//* 암시적 변환 *//*
            Console.WriteLine("절대초 = {0}", absec);
            Time Then = new Time();
            Then = (Time)12345; *//* 명시적 변환 *//*
            Then.OutTime();
        }
    }
}
*/