// Generated by Fuzzlyn on 2018-06-03 22:58:26
// Seed: 15242310615267493544
// Reduced from 47.8 KB to 0.3 KB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static sbyte[, ] s_2 = new sbyte[, ]{{-29}};
    public static void Main()
    {
        var vr64 = (short)((0 & s_2[0, 0]) + s_2[0, 0]);
        M19(vr64);
    }

    static short[] M19(short arg1)
    {
        return new short[]{0, -1, 21584, 1, 2, 3159, 23496, 10, 1396, 10};
    }
}
