// Generated by Fuzzlyn on 2018-06-03 23:56:47
// Seed: 4875637055389468069
class C0
{
    public short F0;
    public int F1;
    public long F2;
    public short F3;
    public C0(short f0, int f1, long f2, short f3)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
        F3 = f3;
    }
}

class C1
{
    public uint F0;
    public sbyte F1;
    public bool F2;
    public sbyte F3;
    public long F4;
    public bool F5;
    public uint F6;
    public long F7;
    public uint F8;
    public C1(uint f0, sbyte f1, bool f2, sbyte f3, long f4, bool f5, uint f6, long f7, uint f8)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
        F3 = f3;
        F4 = f4;
        F5 = f5;
        F6 = f6;
        F7 = f7;
        F8 = f8;
    }
}

public class Program
{
    static sbyte[][] s_1 = new sbyte[][]{new sbyte[]{1, 10, 1}, new sbyte[]{102, 1, -128}, new sbyte[]{2, 62, 1}, new sbyte[]{0, -9}, new sbyte[]{-127, 1, 0}, new sbyte[]{-122, 17, 0, -46}};
    static short s_2 = -16436;
    public static void Main()
    {
        M0();
    }

    static void M0()
    {
        s_1 = s_1;
        s_1[0][0] = -27;
        {
            ushort var0 = (ushort)(s_1[0][0] % (long)(2L | 1));
        }

        s_1[0] = s_1[0];
        s_1[0] = s_1[0];
        ++s_2;
        {
            if (true)
            {
                s_1[0][0] = s_1[0][0];
            }

            if (true)
            {
                ulong var1 = 10UL | (char)(1U ^ s_2);
            }
        }
    }
}