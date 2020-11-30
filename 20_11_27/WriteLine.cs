/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_11_27
{
    class WriteLine
    {
        public static void Main()
        {
            *//*int i = 1234;
            double d = 5.6789;
            string s = "문자열";*/

            /*Console.WriteLine(s);
            Console.WriteLine(i);
            Console.WriteLine(d);*/

            /*Console.Write(s);
            Console.Write(i);
            Console.Write(d);*/

            /*Console.WriteLine("정수는 " + i + "이고 실수는 " + d + "이다.");
            Console.WriteLine("정수는 {1}이고 실수는 {0}이다.", i, d);*/

            /*Console.WriteLine("자리수 테스트 : ->{0}<-->{0,6}<-->{0,-6}<-", 123);
            Console.WriteLine("정밀도 테스트 : ->{0:F0}<-->{0:F2}<-->{0:F3}<-", 123);
            Console.WriteLine("10진수 : {0:D}, 16진수 : {0:X}", 123);*/

            /*int age = 18;
            string name = "김한솔";
            double pie = 3.14159265;*/

            /*Console.WriteLine("안녕하세요. {0}세 {1}입니다.", age, name);
            Console.WriteLine($"안녕하세요. {age}세 {name}입니다.");*/

            /*Console.WriteLine($"폭 및 정렬 : ->{age,5}<-->{name,-6}<-입니다.");
            Console.WriteLine($"정밀도 : {pie:F2}, 16진수 : {age:X}, 연산식 : {age + 5}");
            Console.WriteLine($"속성 : {name.Length}, 메서드 : {name.Replace("슬", "결")}");
            Console.WriteLine($"중괄호 : {{}}");*/

            /*Console.WriteLine("이름을 입력하세요 : ");
            string Name = Console.ReadLine();

            Console.Write("나이를 입력하세요 : ");
            string sAge = Console.ReadLine();*//*
            // Age = Convert.ToInt32(Console.ReadLine());
            *//*public static ConsoleKeyInfo ReadKey([boole intercept]);
                키 자체를 입력받을 때. Ctrl, Alt, Shift는 단독으로 사용되지 않아 키 입력으로 간주하지 않는다.
                intercept 인수는 입력받은 키를 화면으로 다시 출력(echo)할 것인지 지정하는데 생략하면
                false가 적용된다. 함수 원형에서 [] 괄호 안의 인수는 생략 가능하다는 뜻.*/
            /*int Age = Convert.ToInt32(sAge);

            Console.WriteLine($"안녕하세요 {Age}세 {Name}님");*/

            /*ConsoleKeyInfo cki;
            int x = 40, y = 12;
            for(; ;)
            {
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.Write('#');
                cki = Console.ReadKey(true);
                switch (cki.Key)
                {
                    case ConsoleKey.LeftArrow:
                        x--;
                        break;
                    case ConsoleKey.RightArrow:
                        x++;
                        break;
                    case ConsoleKey.UpArrow:
                        y--;
                        break;
                    case ConsoleKey.DownArrow:
                        y++;
                        break;
                    case ConsoleKey.Q:
                        return;
                }
            }*//*

            Console.Title = "콘솔 테스트";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.Beep(); *//* 디버깅용으로 유용 *//*
            Console.WriteLine("색상을 변경했습니다.");
            Console.ReadLine(); *//* 엔터키를 누를 때까지 대기하는 용도로도 종종 사용된다. *//*
            Console.ResetColor();
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("디폴트 색상입니다.");
            Console.ReadLine();
        }
    }
}
*/