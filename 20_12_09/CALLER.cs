/*using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace _20_12_09 {
    class CALLER {
        public static void Main() {
            OutMonthSales(3);
            YearReport();
        }
        public static void YearReport() {
            OutMonthSales(15);
        }

        public static void OutMonthSales(int month,
            [CallerMemberName] string Caller = "",
            [CallerFilePath] string Path = "",
            [CallerLineNumber] int Line = 0) {
            if(month >= 1 && month <= 12) {
                Console.WriteLine($"{month}월 매출 보고를 출력합니다.");
            } else {
                Console.WriteLine("잘못된 요청입니다.");
                Console.WriteLine($"{Path}의 {Caller}메서드 {Line}줄을 점검하십시오.");
            }
        }
    }
}
*/