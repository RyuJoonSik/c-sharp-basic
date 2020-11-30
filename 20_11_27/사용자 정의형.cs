/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Origin { East, West, South, North }

    class 사용자_정의형
    {
        public static void Main()
        {
        *//*Origin Turn;
        Turn = Origin.South;
        string name = Turn.ToString();
        Console.WriteLine(name);
        Turn = (Origin)Enum.Parse(typeof(Origin), "East");
        Console.WriteLine(Turn);
        int value = (int)Enum.Parse(typeof(Origin), "East");
        Console.WriteLine(value);*/
        /*int Value = (int)Turn;
        Console.WriteLine(Value);*/

        /*Book b;*/
        /*Book b = new Book(); 참조 타입인 클래스와 사용 방법을 일관되게 통일하기 위해 
                               new 연산자를 쓰는 방법도 지원한다. 선언 형식을 일치시키기 위한
                                예외 적용일 뿐 new로 할당해도 구조체는 여전히 스택에 생성된다.*/
        /*b.Name = "노점상으로 떼돈벌기";
        b.Price = 16000;
        Console.WriteLine($"제목 : {b.Name}\n가격 : {b.Price}");*//*
        Book b = new Book("노점상으로 떼돈벌기", 18000);
        b.OutBook();
        }
    }

struct Book
    *//* 구조체나 클래스의 선언문이 Main보다 더 뒤에 있어도 상관없으며 전방 선언도 필요 없다.*//* 
{
    public string Name;
    public int Price;
    public Book(string aName, int aPrice)
    {
        Name = aName;
        Price = aPrice;
    }
    public void OutBook()
    {
        Console.WriteLine($"제목 : {Name}\n가격 : {Price}");
    }
}

*/