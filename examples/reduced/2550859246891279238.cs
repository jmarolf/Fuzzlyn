// Generated by Fuzzlyn on 2018-06-03 23:35:15
// Seed: 2550859246891279238
// Reduced from 9.7 KB to 0.3 KB
// Debug: Outputs 128
// Release: Outputs 4294967168
public class Program
{
    static uint s_2 = 1U;
    static sbyte s_5 = -127;
    static uint s_6 = 4294967294U;
    public static void Main()
    {
        s_6 = (byte)(1L ^ s_5);
        s_2 = s_6;
        System.Console.WriteLine(s_2);
    }
}
