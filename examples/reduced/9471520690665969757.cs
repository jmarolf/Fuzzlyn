// Generated by Fuzzlyn on 2018-06-04 01:09:06
// Seed: 9471520690665969757
// Reduced from 32.9 KB to 0.2 KB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static byte[, ] s_1 = new byte[, ]{{1}};
    public static void Main()
    {
        M6();
    }

    static ulong M6()
    {
        return (ulong)(0 & s_1[0, 0]) & s_1[0, 0]--;
    }
}
