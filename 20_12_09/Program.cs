/*#define TRIAL
#define FREE
using System;
using System.Diagnostics;

namespace _20_12_09 {
    class Program {
        [Conditional("TRIAL"), Conditional("FREE")] *//* 둘 중 하나 조건 만족 시 *//* 
        public static void TrialMessage() {
            Console.WriteLine("이 제품은 30일간만 사용할 수 있습니다.");
            Console.WriteLine("정품을 구입하시려면 어쩌고 저쩌고.\n");
        }

        [Conditional("TRIAL")] *//* 두 조건이 다 만족 시*//*
        public static void TrialMessage1() { TrialMessage2(); }
        [Conditional("FREE")]
        public static void TrialMessage2() { }

        static void Main(string[] args) {
            TrialMessage();
            Console.WriteLine("게임을 시작합니다");
        }
    }
}
*/