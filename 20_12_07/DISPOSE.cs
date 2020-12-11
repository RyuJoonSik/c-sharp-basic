/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_07 {
    class Socket : IDisposable {
        private int SocketPort;
        private bool Disposed = false;
        public Socket(int port)
        {
            SocketPort = port;
            Console.WriteLine($"{port} 포트로 소켓을 연결한다.");
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public virtual void Dispose(bool bManage)
        {
            if (Disposed) return;
            Disposed = true;
            if (bManage)
            {
                // 관리 자원 해제.
            }
            SocketPort = 0;
            Console.WriteLine("소켓 연결을 해제한다.");
        }
        ~Socket()
        {
            Dispose(false);
        }
    }
    class DISPOSE {
        public static void Main()
        {
            Socket S = new Socket(1234);
            Console.WriteLine("주거니 받거니 통신했다 치고...");
            S.Dispose();
        }
    }
}
*/