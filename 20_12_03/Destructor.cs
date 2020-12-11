/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_03 {
    class Socket {
        private int SocketPort;
        public Socket(int port)
        {
            SocketPort = port;
            Console.WriteLine("{0} 포트로 소켓을 연결한다.", port);
        }

        *//* 가비지 컬렉터가 자원을 자동으로 회수하지만, 파일이나 네트워크처럼 
         가비지 컬렉터의 관리 대상이 아닌 자원에 대해서만 가끔 사용한다. *//*
        ~Socket()
        {
            SocketPort = 0;
            Console.WriteLine("소켓 연결을 해제한다.");
        }
    }
    class Destructor {
        public static void Main()
        {
            Socket S = new Socket(1234);
            Console.WriteLine("주거니 받거니 통신했다 치고...");
        }
    }
}
*/