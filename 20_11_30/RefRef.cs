/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_11_30 {
    class RefRef {
        *//* 참조형을 값으로 받는 경우*//*
        public static void method1(CTime t)
        {
            t.hour = 12;
            t = new CTime(15);
        }

        *//* 참조형을 참조로 받는 경우*//*
        public static void method2(ref CTime t)
        {
            t.hour = 12;
            t = new CTime(15);
        }

        static void Main()
        {
            CTime C1 = new CTime(9);
            method1(C1);
            *//* new CTime(15)에 의해 생성되는 객체는 메서드 호출이 끝나면 지역변수 t와 함게 사라진다.
             t가 가리키는 실인수는 변경 가능하지만 t자체는 값이기 때문에 변경되지 않는다. *//*
            CTime C2 = new CTime(9);
            method2(ref C2);
            *//* 새로운 객체를 생성하여 t에 대입하면 호출원의 C2가 이 객체를 가리킨다.
             t가 가리키는 실인수도 참조형이고 t 자체도 참조형이므로 t의 내용도 바꿀 수 있고 t자체도 바꿀 수 있다.*//*
            Console.WriteLine("값으로 넘겼을 때 : " + C1.hour);
            Console.WriteLine("참조1로 넘겼을 때 : " + C2.hour);
        }
    }

    class CTime {
        public CTime(int ahour) { hour = ahour; }
        public int hour;
    }
}
*/