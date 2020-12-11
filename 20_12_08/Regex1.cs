/*using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _20_12_08 {
    class Regex1 {
        public static void Main() {
            string str = "간장 공장 공장장은 강공장장이고 된장 공장 공장장은 장공장장이다.";
            MatchCollection Find = Regex.Matches(str, @"공장");
            foreach(Match M in Find) {
                Console.Write(M.Index + " ");
            }
        }
    }
}
*/