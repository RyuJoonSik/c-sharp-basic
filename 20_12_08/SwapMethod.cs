/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_08 {
    class SwapMethod {
        public static void Swap<T>(ref T a, ref T b) {
            T t;
            t = a; a = b; b = t;
        }
        *//*public static void Swap(ref string a, ref string b) {
            string t;
            t = a; a = b; b = t;
        }*//*
        public static void Main() {
            int i1 = 3, i2 = 4;
            Console.WriteLine("i1 = {0}, i2 = {1}", i1, i2);
            Swap<int>(ref i1, ref i2);
            Console.WriteLine("i1 = {0}, i2 = {1}", i1, i2);

            string s1 = "멍멍", s2 = "꼬꼬댁";
            Console.WriteLine("s1 = {0}, s2 = {1}", s1, s2);
            Swap(ref s1, ref s2);
            Console.WriteLine("s1 = {0}, s2 = {1}", s1, s2);
        }
    }
}
*/