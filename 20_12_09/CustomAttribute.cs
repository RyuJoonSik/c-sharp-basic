/*using System;
using System.Collections.Generic;
using System.Text;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Field,
    AllowMultiple = true, Inherited = false)]
class ProgrammerAttribute : Attribute {
    private string Name;
    private string Time;
    public ProgrammerAttribute(string aName) {
        Name = aName;
        Time = "기록없음";
    }
    public string When {
        get { return Time; }
        set { Time = value; }
    }
}
    class CustomAttribute {
    [Programmer("Kim")]
    public static int Field1 = 0;

    [Programmer("Kim", When = "2019년 6월 29일")]
    public static void Method1() { }

    [Programmer("Lee")]
    public static void Method2() { }

    [Programmer("Park"), Programmer("Choi")]
    public static void Method3() { }

    public static void Main() {
    }
    }
*/