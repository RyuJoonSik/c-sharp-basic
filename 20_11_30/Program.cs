/*using System;


class Program {
    public static void PlusOne(int p) { p++; }
    public static void PlusOneRef(ref int p) { p++; }
    *//* 메소드 내에서 실인수의 값을 결정하여 리턴 *//*
    public static void GetValue(out int p) { p = 1234; }
    static void Main(string[] args)
    {
        int a = 1, b;
        PlusOne(a);
        Console.WriteLine($"a = {a}");
        *//* 참조 호출 인수는 반드시 초기화해야한다.*//*
        PlusOneRef(ref a);
        Console.WriteLine($"a = {a}");
        *//* 참조 호출 인수는 초기화 하지 않아도 상관 없다.*//*
        GetValue(out b);
        Console.WriteLine($"b = {b}");
    }
    *//* ref, out 키워드를 사용하면 값 타입인 구조체를 참조 호출로 전달할 수 있다.*//*
}

*/