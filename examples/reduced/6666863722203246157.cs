// Generated by Fuzzlyn on 2018-06-04 00:14:28
// Seed: 6666863722203246157
// Reduced from 52.6 KB to 0.3 KB
// Debug: Outputs 65442
// Release: Outputs 4294967202
public class Program
{
    static ulong[] s_1 = new ulong[]{4440770631036152738UL};
    static long s_8 = 5112872248023557333L;
    public static void Main()
    {
        s_8 = (ushort)(sbyte)s_1[0];
        System.Console.WriteLine(s_8);
    }
}
