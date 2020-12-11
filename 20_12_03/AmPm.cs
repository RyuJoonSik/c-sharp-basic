/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_03 {
    class Time {
        private int hour, min, sec;
        public Time(int h, int m, int s) { hour = h; min = m; sec = s; }
        private static bool UseAmPm; *//* 정적 필드 *//*
        static Time() { UseAmPm = false; } *//* 정적 생성자(정적 필드 초기화) *//*
        public static void SetAmPm(bool bAmPm) { UseAmPm = bAmPm; } *//* 정적 메서드(정적 필드만 액세스) *//*
        public void OutTime()
        {
            int h;
            string AmPm;
            if(UseAmPm == true)
            {
                if(hour < 12) { AmPm = "오전"; h = hour; } else { AmPm = "오후"; h = hour - 12; }
                Console.WriteLine($"현재 시간은 {AmPm}{h}시 {min}분 {sec}초이다.");
            }
            else
            {
                Console.WriteLine($"현재 시간은 {hour}시 {min}분 {sec}초이다.");
            }
        }
    }
    class AmPm {
        public static void Main()
        {
            Time Now = new Time(18, 25, 55);
            Time Then = new Time(20, 30, 10);
            Now.OutTime();
            Then.OutTime();
            Time.SetAmPm(true);
            Now.OutTime();
            Then.OutTime();
        }
    }
}
*/