// Generated by Fuzzlyn on 2018-06-03 23:24:03
// Seed: 1766743282082234802
// Reduced from 27.9 KB to 0.4 KB
// Debug: Outputs 65473
// Release: Outputs 4294967233
class C1
{
    public sbyte F8;
    public C1(sbyte f8)
    {
        F8 = f8;
    }
}

public class Program
{
    public static void Main()
    {
        var vr41 = new C1(-127);
        char vr42 = M3(vr41);
        uint vr44 = vr42;
        System.Console.WriteLine(vr44);
    }

    static char M3(C1 arg3)
    {
        return (char)('A' | arg3.F8);
    }
}
