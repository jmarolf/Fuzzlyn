// Generated by Fuzzlyn on 2018-06-03 23:53:39
// Seed: 4592549405922659252
class C0
{
    public long F0;
    public sbyte F1;
    public char F2;
    public bool F3;
    public uint F4;
    public C0(long f0, sbyte f1, char f2, bool f3, uint f4)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
        F3 = f3;
        F4 = f4;
    }
}

struct S0
{
    public C0 F0;
    public C0 F1;
    public sbyte F2;
    public uint F3;
    public ushort F4;
    public long F5;
    public int F6;
    public ushort F7;
    public S0(C0 f0, C0 f1, sbyte f2, uint f3, ushort f4, long f5, int f6, ushort f7)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
        F3 = f3;
        F4 = f4;
        F5 = f5;
        F6 = f6;
        F7 = f7;
    }
}

public class Program
{
    static S0[, ] s_1 = new S0[, ]{{new S0(new C0(-4767108023525822536L, 36, 'K', false, 0U), new C0(3054650660698503535L, 102, 'S', false, 3910987143U), -90, 4294967295U, 52103, -9223372036854775808L, -2, 3828)}, {new S0(new C0(0L, -8, ':', false, 1U), new C0(7349391193600735170L, 110, 'j', true, 1U), 126, 1178761413U, 5849, 9223372036854775807L, 568144997, 57648)}, {new S0(new C0(1L, 0, '|', false, 1U), new C0(2224634481285982684L, 1, '2', false, 0U), 115, 765713706U, 15739, 1L, -1380708917, 0)}, {new S0(new C0(8672384575978239464L, -46, 'c', true, 698541059U), new C0(1L, 2, '=', false, 653503402U), 33, 3219621553U, 25992, -6152802491783332738L, 1, 53560)}};
    public static void Main()
    {
        M0();
    }

    static void M0()
    {
        short var0 = (short)(-1004359925 ^ (((long)('4' % (sbyte)((sbyte)((2538046016U ^ (uint)(0 | (ushort)(-65 % (ushort)((ushort)(0UL & (uint)('?' - (short)(4294967295U % (ulong)((ulong)(0 - (byte)(-5404430116473586042L + (sbyte)(-2L * (uint)((ushort)((byte)(0U & (uint)(604646391U & (long)((253 & (short)(47198 % (uint)((0U | M1()) | 1))) % (int)(1787562993 | 1)))) % (long)(s_1[0, 0].F5 | 1)) % (int)(s_1[0, 0].F6 | 1))))) | 1)))) | 1)))) * 49715) | 1)) & s_1[0, 0].F0.F0) - 'E'));
        {
            s_1[0, 0].F1.F2 = s_1[0, 0].F1.F2;
            M3();
        }

        M1();
    }

    static ushort M1()
    {
        M2();
        ulong var0 = 10473320718960377313UL;
        return (ushort)(123 * M4());
    }

    static S0 M2()
    {
        bool var0 = false;
        M3();
        var0 = true;
        return new S0(new C0(-308992302833850428L, 0, '|', true, 4294967294U), new C0(-6819807198811883478L, 40, '9', false, 1U), 108, 4038970567U, 1, 1L, 731021426, 0);
    }

    static ushort[] M3()
    {
        C0 var0 = new C0(-1422700861214992221L, 101, '\'', true, 0U);
        return new ushort[]{19072, 10, 20509};
    }

    static sbyte M4()
    {
        bool var0 = false & false;
        {
            uint var1 = 10U;
            var1 = var1;
            {
                var1 = var1;
                var1 = (uint)(4 ^ (ulong)(32767 % (ushort)((ushort)(1 | (ulong)(32766 + var1)) | 1)));
            }

            var0 = var0;
            s_1 = s_1;
        }

        {
            s_1[0, 0].F1.F3 = var0;
            s_1[0, 0].F1 = s_1[0, 0].F1;
        }

        return s_1[0, 0].F1.F1;
    }
}