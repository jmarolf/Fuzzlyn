// Generated by Fuzzlyn on 2018-06-03 23:51:15
// Seed: 4528629800774140510
// Reduced from 28.2 KB to 0.3 KB
// Debug: Outputs 129
// Release: Outputs 4294967169
class C0
{
    public sbyte F4;
    public C0(sbyte f4)
    {
        F4 = f4;
    }
}

public class Program
{
    static C0 s_4 = new C0(-127);
    public static void Main()
    {
        var vr28 = new C0(s_4.F4);
        byte vr30 = (byte)(vr28.F4 / (uint)1);
        ulong vr32 = vr30;
        System.Console.WriteLine(vr32);
    }
}
