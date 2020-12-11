/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_09 {
    class OBSOLETE {
        [Obsolete("NewMethod를 사용하시오")]
        public static void OldMethod() { }

        public static void NewMethod() {
            Console.WriteLine("새로 만든 최신형 메서드입니다.");
        }

        [Obsolete("아프올는 이 메서드를 쓰지 마시오.", true)]
        public static void OutDateMethod() { }

        public static void Main() {
            OldMethod();
            NewMethod();
            // OutDateMethod();
        }
    }
}
*/