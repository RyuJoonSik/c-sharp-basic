/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_08 {
    class Time {
        public int hour, min, sec;
        public Time(int h, int m, int s) { hour = h; min = m; sec = s; }
        *//*public override bool Equals(object obj) {
            Time Other = (Time)obj;
            return (Other.hour == hour && Other.min == min && Other.sec == sec);
        }*//*
    }
    class TimeEquals {
        public static void Main() {
            Time A = new Time(1, 2, 3);
            Time B = new Time(1, 2, 3);
            Time C = A;
            Console.WriteLine("Equals(A, B) = " + A.Equals(B));
            Console.WriteLine("Equals(A, B) = " + object.Equals(A, B));
            Console.WriteLine("Equals(A, C) = " + A.Equals(C));
            Console.WriteLine("Equals(A, C) = " + object.Equals(A, C));
            Console.WriteLine("ReferenceEquals(A, B) = " + object.ReferenceEquals(A, B));
            Console.WriteLine("ReferenceEquals(A, B) = " + object.ReferenceEquals(A, C));
        }
    }
}
*/