// Generated by Fuzzlyn on 2018-06-03 23:50:13
// Seed: 4389206461469309881
// Reduced from 6.2 KB to 0.3 KB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public short F3;
    public byte F7;
    public C0()
    {
    }
}

public class Program
{
    static C0[, ] s_1 = new C0[, ]{{new C0()}};
    public static void Main()
    {
        sbyte vr11 = 126;
        bool vr12 = ('a' % (((1U % ((0 * vr11) | 1)) * s_1[0, 0].F7) | 1)) == s_1[0, 0].F3;
    }
}