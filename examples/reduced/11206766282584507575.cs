// Generated by Fuzzlyn on 2018-06-03 22:11:05
// Seed: 11206766282584507575
// Reduced from 16.2 KB to 0.3 KB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static long s_1 = 887303721353470405L;
    static long[, ] s_2 = new long[, ]{{5776432457927526450L}};
    public static void Main()
    {
        bool vr19 = s_1 > (0 & s_2[0, 0]);
        if (vr19)
        {
            var vr20 = s_2[0, 0];
        }
    }
}
