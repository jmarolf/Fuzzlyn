// Generated by Fuzzlyn on 2018-06-03 22:11:12
// Seed: 11255734272580693715
struct S0
{
    public int F0;
    public uint F1;
    public int F2;
    public short F3;
    public bool F4;
    public sbyte F5;
    public uint F6;
    public long F7;
    public char F8;
    public S0(int f0, uint f1, int f2, short f3, bool f4, sbyte f5, uint f6, long f7, char f8)
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
    static ulong s_1 = 17439122441727536739UL;
    public static void Main()
    {
        M0();
    }

    static void M0()
    {
        sbyte var0 = -116;
        if (true)
        {
            var0 = var0;
        }
        else
        {
            var0 = var0;
        }

        if (true)
        {
            if (false)
            {
                if (false)
                {
                    M1();
                    int[] var1 = new int[]{1635460286, 1342992560, 10, -1692282878, -1175036561, 1738715295};
                    ulong[] var2 = new ulong[]{0UL};
                    M1();
                }
                else
                {
                    var0 = var0--;
                }

                var0 = -128;
            }
            else
            {
                {
                    short var3 = (short)((uint)M2(var0) % (char)('0' | 1));
                }
            }

            var0 = var0;
        }

        {
            int var4 = 2036700988;
            M2(var0);
            byte[] var5 = new byte[]{0, 0, 0, 1, 127, 0, 72, 0, 120};
            if (true)
            {
                var5 = new byte[]{254, 255, 45, 218, 0, 0, 0};
                if (false)
                {
                    return;
                }

                s_1 = 14031591596992498912UL;
                var4 = 1116727607;
                bool var6 = true;
                s_1 = s_1;
            }

            int var7 = var4;
        }

        if (false)
        {
            s_1 = (ulong)M2(var0);
        }
    }

    static uint M1()
    {
        if (true)
        {
            sbyte var0 = 10;
            M2(var0++);
            var0 = (sbyte)M2(126);
        }

        ulong[] var1 = new ulong[]{4708932972370433783UL, 1UL, 1UL, 1UL, 1UL, 14640710373664038629UL};
        {
            var1 = new ulong[]{5275661290997048279UL, 8366265593499098713UL, 13376374291443171352UL, 3745869426316308594UL, 1UL, 7131323602827657243UL, 18446744073709551615UL, 1UL, 0UL};
        }

        return 3092819500U;
    }

    static byte M2(sbyte arg0)
    {
        S0 var0 = new S0(-2147483648, 1341605664U, 633751326, -21309, false, 1, 3163264511U, -4308099387693617225L, '#');
        var0.F3 = -1125;
        if (207 <= 127)
        {
            {
                M3(new char[]{'Y', '4', '#', 'k', ',', '!', 'h', 'R'}, new long[][]{new long[]{-1197930189734747608L}, new long[]{-8553038109709369529L}, new long[]{1L}, new long[]{0L}, new long[]{-5393979519858997338L}, new long[]{9223372036854775806L}, new long[]{-1070014610298944322L}, new long[]{9223372036854775807L}, new long[]{2L}, new long[]{2707946064428668410L}});
            }

            var0.F0 = -10;
        }

        long var1 = var0.F7;
        return (byte)(254 ^ var0.F6);
    }

    static short[] M3(char[] arg0, long[][] arg1)
    {
        S0 var0 = new S0(-10, 0U, -2147483648, 1998, true, -10, 0U, -8206701852640778369L, '#');
        arg0[0] = '!';
        return new short[]{0};
    }
}