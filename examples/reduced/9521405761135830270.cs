// Generated by Fuzzlyn on 2018-06-04 01:10:08
// Seed: 9521405761135830270
// Reduced from 49.8 KB to 0.8 KB
// Debug: Outputs -45
// Release: Outputs -117
class C0
{
    public byte F2;
    public sbyte F5;
    public C0(byte f2, sbyte f5)
    {
        F2 = f2;
        F5 = f5;
    }
}

struct S1
{
    public bool F0;
    public char F1;
    public C0 F2;
    public char F3;
    public sbyte F4;
    public bool F5;
    public S1(bool f0, char f1, C0 f2, char f3, sbyte f4, bool f5)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
        F3 = f3;
        F4 = f4;
        F5 = f5;
    }
}

public class Program
{
    static S1 s_1 = new S1(true, 'Y', new C0(102, 1), '7', 0, false);
    public static void Main()
    {
        s_1 = new S1(false, 'e', new C0(247, -127), '&', 1, false);
        ushort vr130 = 0;
        sbyte vr117 = (sbyte)((ushort)((10 - vr130) | s_1.F2.F5) % s_1.F2.F2);
        System.Console.WriteLine(vr117);
    }
}