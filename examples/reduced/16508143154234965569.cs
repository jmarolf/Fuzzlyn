// Generated by Fuzzlyn on 2018-06-03 23:05:59
// Seed: 16508143154234965569
// Reduced from 122.4 KB to 0.2 KB
// Debug: Outputs 131
// Release: Outputs 4294967171
public class Program
{
    static sbyte s_2 = -126;
    public static void Main()
    {
        byte vr161 = (byte)(s_2 | 1U);
        uint vr163 = vr161;
        System.Console.WriteLine(vr163);
    }
}
