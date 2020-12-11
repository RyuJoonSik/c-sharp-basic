/*using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace _20_12_08 {
    class Time {
        public int hour, min, sec;
        public Time(int h, int m, int s) { hour = h;min = m; sec = s; }
        public void OuTimeTypeime() {
            Console.WriteLine($"현재 시간은 {hour}시 {min}분 {sec}초이다.");
        }
    }
    class TimeInfo {
        public static void Main() {
            _20_12_08.Time Now = new _20_12_08.Time(1, 2, 3);
            Type TimeType = Now.GetType();
            Type TimeType1 = Type.GetType("_20_12_08.Time");
            Type TimeType2 = typeof(_20_12_08.Time);

            Console.WriteLine(TimeType.Name);
            Console.WriteLine(TimeType.FullName);
            Console.WriteLine(TimeType.Namespace);
            Console.WriteLine(TimeType.BaseType.Name);
            Console.WriteLine(TimeType.UnderlyingSystemType.Name);
            if (TimeType.IsValueType) { Console.WriteLine("값 타입입니다."); }

            FieldInfo[] Timefield = TimeType.GetFields();
            for(int i = 0; i < Timefield.Length; i++) {
                Console.WriteLine($"{i}번째 필드 = {Timefield[i].Name}");
            }

            MethodInfo[] TimeMethod = TimeType.GetMethods();
            for(int i = 0; i < TimeMethod.Length; i++) {
                Console.WriteLine($"{i}번재 메서드 = {TimeMethod[i].Name}");
            }
        }
    }
}
*/