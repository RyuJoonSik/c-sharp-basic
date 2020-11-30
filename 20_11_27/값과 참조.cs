using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class 값과_참조 {
    /*public static int AddAll(params int[] nums)
        *//* 가변 인수 params 
            배열은 정의상 같은 타입의 인수만 전달하는 것이 원칙이지만 모든 타입의 루트인 object의
            배열을 사용하면 임의 타입의 변수 집합을 전달 할 수 있다. 이때 호출원에서는 is, as 등의
            연산자로 실인수의 타입을 점검하여 처리한다.*//*
    {
        int sum = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        return sum;
    }*/
    static void Main()
    {
        /*int[] ar = { 3, 4, 5 };
        Console.WriteLine("1 + 2 = " + AddAll(new int[2] { 1, 2 }));
        Console.WriteLine("3 + 4 + 5 = " + AddAll(ar));
        Console.WriteLine("6 + 7 + 8 + 9 = " + AddAll(6, 7, 8, 9));*/

        /*int value = 3, vcopy;
        vcopy = value;
        vcopy = 4;
        Console.WriteLine($"value = {value}, vcopy = {vcopy}");

        int[] ar, arcopy;
        ar = new int[] { 1, 2, 3, 4, 5 };
        arcopy = ar;
        arcopy[1] = 1234;
        Console.WriteLine($"ar[1] = {ar[1]}, arcopy[1]={arcopy[1]}");*/

        /*int value = 3, vcopy = 3;
        Console.WriteLine("값 타입 : " + (value == vcopy ? "같다" : "다르다"));

        int[] ar = {1, 2, 3, 4, 5};
        int[] arcopy = { 1, 2, 3, 4, 5 };
        Console.Write("참조 타입 : " + (ar == arcopy ? "같다" : "다르다"));*/

        /*string s1 = "텔레토비";
        string s2 = s1;
        s2 = "마시마로";
        Console.WriteLine($"s1 = {s1}, s2 = {s2}");

        string s3 = "로보트 태권 V";
        string s4 = "로보트 태권 V";
        Console.WriteLine("문자열 : " + (s3 == s4 ? "같다" : "다르다"));*/

        /*Pixel p1 = new Pixel(1, 2, 3);
        Pixel p2 = p1;
        p2.Pos.x = 1234;
        p2.Color = 5678;
        p1.OutPixe();
        p2.OutPixe();*/

        /*CTime C = new CTime();
        C.hour = 9;
        STime S;
        S.hour = 9;
        method1(C);
        method2(S);
        Console.WriteLine("클래스 : " + C.hour);
        Console.WriteLine("구조체 : " + S.hour);*/
    }
    /*public static void method1(CTime t)
    {
        t.hour = 12;
    }

    public static void method2(STime t)
    {
        t.hour = 12;
    }*/
    
}

/*class CTime {
    public int hour;
}

struct STime {
    public int hour;
}*/
/*class Position {
    public int x, y;
    public Position(int ax, int ay) { x = ax; y = ay; }
}

struct Pixel {
    public Position Pos;
    public int Color;
    public Pixel(int ax, int ay, int ac) { Pos = new Position(ax, ay); Color = ac; }
    public void OutPixe() { Console.WriteLine($"x = {Pos.x},y = {Pos.y}, Color = {Color}"); }
}*/

