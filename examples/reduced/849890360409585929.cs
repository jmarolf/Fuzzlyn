// Generated by Fuzzlyn on 2018-06-04 00:54:49
// Seed: 849890360409585929
// Reduced from 19.1 KB to 0.3 KB
// Debug: Outputs -26231
// Release: Outputs -12246
public class Program
{
    public static void Main()
    {
        var vr28 = new short[]{-12246};
        uint vr30 = 1U;
        long vr31 = 6635680541797784670L;
        bool vr32 = (char)(vr28[0] / vr30) >= (sbyte)vr31;
        if (vr32)
        {
            vr28[0] = -26231;
        }

        System.Console.WriteLine(vr28[0]);
    }
}