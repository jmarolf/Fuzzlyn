// Generated by Fuzzlyn on 2018-06-04 00:53:41
// Seed: 8481609375777363329
// Reduced from 12.8 KB to 0.3 KB
// Debug: Outputs 65466
// Release: Outputs 4294967226
public class Program
{
    static sbyte s_1 = -70;
    public static void Main()
    {
        ushort vr19 = (ushort)(0 ^ M5());
        long vr21 = vr19;
        System.Console.WriteLine(vr21);
    }

    static sbyte M5()
    {
        return s_1;
    }
}
