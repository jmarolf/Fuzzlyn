// Generated by Fuzzlyn on 2018-06-03 23:46:26
// Seed: 3578340339630193835
class C0
{
    public long F0;
    public ulong F1;
    public uint F2;
    public long F3;
    public C0(long f0, ulong f1, uint f2, long f3)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
        F3 = f3;
    }
}

class C1
{
    public ushort F0;
    public short F1;
    public C0 F2;
    public sbyte F3;
    public short F4;
    public ushort F5;
    public bool F6;
    public C1(ushort f0, short f1, C0 f2, sbyte f3, short f4, ushort f5, bool f6)
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

struct S0
{
    public C1 F0;
    public short F1;
    public C1 F2;
    public C0 F3;
    public C0 F4;
    public S0(C1 f0, short f1, C1 f2, C0 f3, C0 f4)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
        F3 = f3;
        F4 = f4;
    }
}

public class Program
{
    public static void Main()
    {
        M0();
    }

    static void M0()
    {
        C1 var0 = new C1(0, -12113, new C0(-5707138672626085215L, 2UL, 1850194725U, 1L), -128, 7112, 56899, true);
        var0.F0 = (ushort)(33055373U / (byte)((byte)(var0.F0 ^ var0.F3) | 1));
        var0.F5 <<= 2019255322;
        var0.F5 = var0.F5;
    }
}