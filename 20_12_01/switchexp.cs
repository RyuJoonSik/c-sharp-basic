/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_01 {
    class switchexp {
        static void Main()
        {
            int rank = 2;
            string medal = rank switch
            {
                *//* rank값에 따라 대응된다. *//*
                1 => "금메달",
                2 => "은메달",
                3 => "동메달",
                _ => "참가상"
            };
            Console.WriteLine(medal);
            Console.WriteLine(rank switch { 1 => "금메달", 2 => "은메달", 3 => "동메달", _ => "참가상" });
        }
    }
}
*/