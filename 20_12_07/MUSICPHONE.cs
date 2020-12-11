/*using System;
using System.Collections.Generic;
using System.Text;

namespace _20_12_07 {
    class HandPhone {
        public virtual void Send() { Console.WriteLine("띠리리리"); }
        public virtual void Receive() { Console.WriteLine("여보세요");
        }
    }

    interface IMap3 {
        void PlayMusic();
    }

    interface ICamera {
        void TakePhoto();
    }

    class MusicPhone : HandPhone, IMap3, ICamera {
        public void PlayMusic() { Console.WriteLine("동해물과 백두산이"); }
        public void TakePhoto() { Console.WriteLine("찰칵"); }
    }
    class MUSICPHONE {
        public static void Main()
        {
            MusicPhone EveryCall = new MusicPhone();
            EveryCall.Receive();
            EveryCall.PlayMusic();
            EveryCall.TakePhoto();
        }
    }
}

*/