// Generated by Fuzzlyn on 2018-06-03 23:05:30
// Seed: 16286288538065300418
// Reduced from 188.6 KB to 0.4 KB
// Debug: Prints 1 line(s)
// Release: Prints 0 line(s)
class C0
{
    public uint F0;
    public C0()
    {
    }
}

class C1
{
    public C0 F4;
    public C1(C0 f4)
    {
        F4 = f4;
    }
}

public class Program
{
    static sbyte s_1 = -51;
    public static void Main()
    {
        bool vr101 = (ushort)((byte)(0U * s_1) ^ s_1) >= 'w';
        if (vr101)
        {
            C1 vr102 = new C1(new C0());
            System.Console.WriteLine(vr102.F4.F0);
        }
    }
}
