// Generated by Fuzzlyn on 2018-06-03 23:39:37
// Seed: 3064625897244566545
// Reduced from 97.1 KB to 0.4 KB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C2
{
    public long F2;
    public C2()
    {
    }
}

class C4
{
    public char F7;
    public C4()
    {
    }
}

public class Program
{
    static C4[, ] s_7 = new C4[, ]{{new C4()}};
    static C2[][][] s_8 = new C2[][][]{new C2[][]{new C2[]{new C2()}}};
    public static void Main()
    {
        bool vr55 = (-122 / (byte)((0UL & s_7[0, 0].F7) ^ 18446744073709551615UL)) <= s_8[0][0][0].F2;
    }
}