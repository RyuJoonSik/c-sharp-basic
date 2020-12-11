/*using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _20_12_08 {
    class Regex2 {
        public static void Main() {
            string str = "김상형, 김상민, 김철수, 박상형, 김미형, 김철부지형, 김형, 김상형님 ";
            MatchCollection Find = Regex.Matches(str, @"\b김\S*형\b");
            foreach(Match m in Find) {
                Console.WriteLine(m.Value);
            }
        }
    }
}
*/