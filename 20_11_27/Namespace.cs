/*using System;
using static System.Console; *//* using static문으로 클래스를 지정하면 이 클래스에 소속된 정적 멤버를 모두
                               임포트하여 메서드 이름만으로 호출할 수 있다.
                                열거형과 상수 멤버에도 사용할 수 있다.(속성값이라기 보다는 구분을 위한 값이어서)*//*
using static Origin;
using static Race;
*//*using 별명 = 네임스페이스; 별명을 지정하여 네임스페이스를 짧게 칭할 수 있다.*/

/*함수나 변수는 네임스페이스 안에 직접 선언할 수 없고 클래스나 구조체의 멤버로 선언한다.
  네임스페이스끼리 중첩하여 명칭을 계칭적으로 조직화할 수 있다.(한꺼번에 정의하는 것도 가능)
  긴 명칭 참조문을 짧게 쓰기 위해 using을 사용한다. *//*

enum Origin { East, West, South, North }
    class Race { public const int ZERG = 0, TERRAN = 1, PROTOSS = 2; }

    class Namespace
    {
        public static void Main()
        {
            *//*System.Console.WriteLine("안녕하세요");
            Console.WriteLine("안녕하세요");
            WriteLine("안녕하세요");*//*
            Origin Turn = South;
            WriteLine(Turn);
        int YunYoul = TERRAN;
        WriteLine(YunYoul);
        }
    }
*/