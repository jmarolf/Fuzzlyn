// Generated by Fuzzlyn on 2018-06-03 22:03:35
// Seed: 10102492169664265785
// Reduced from 141.8 KB to 0.3 KB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static short s_5 = 2199;
    static short[, ] s_6 = new short[, ]{{-2}};
    public static void Main()
    {
        uint vr157 = (uint)(s_6[0, 0] & 0);
        s_6[0, 0] = s_5;
        System.Console.WriteLine(vr157);
    }
}