// Generated by Fuzzlyn on 2018-06-04 00:18:45
// Seed: 6915691799871466979
// Reduced from 7.9 KB to 0.7 KB
// Debug: Outputs -14
// Release: Outputs -20238
struct S0
{
    public ushort F0;
    public byte F1;
    public int F2;
    public long F3;
    public bool F4;
    public ushort F5;
    public short F6;
    public S0(ushort f0, byte f1, int f2, long f3, bool f4, ushort f5, short f6)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
        F3 = f3;
        F4 = f4;
        F5 = f5;
        F6 = f6;
    }
}

public class Program
{
    static short s_1 = 19305;
    public static void Main()
    {
        s_1 = (short)M2();
        System.Console.WriteLine(s_1);
    }

    static ulong M2()
    {
        S0 var0 = new S0(45298, 254, 169016647, 9223372036854775806L, false, 0, -4254);
        return (ulong)(sbyte)var0.F0;
    }
}
