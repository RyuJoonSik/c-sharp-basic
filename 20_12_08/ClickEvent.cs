/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_08 {
    public delegate void DeleClick();
    
    class Button {
        public event DeleClick Click;
        public void Draw() {
            Console.WriteLine("나는 버튼입니다.");
        }
        public void OnClick() {
            if (Click != null) Click();
        }
    }
    class ClickEvent {
        public static void GameStart() {
            Console.WriteLine("게임을 시작합니다.");
            for(int i = 0; i < 50; i++) {
                Console.Write('.');
                System.Threading.Thread.Sleep(50);
            }
            Console.WriteLine("\n게임이 끝났다 치고.");
        }
        
        public static void Main() {
            Button BtnStart = new Button();
            BtnStart.Draw();
            BtnStart.Click += GameStart;
            Console.WriteLine("S:게임 시작 . E:끝");
            for (; ; ) {
                if (Console.KeyAvailable) {
                    ConsoleKeyInfo cki;
                    cki = Console.ReadKey();
                    if(cki.Key == ConsoleKey.S) {
                        BtnStart.OnClick();
                    }
                    if(cki.Key == ConsoleKey.E) {
                        break;
                    }
                }
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}
*/