// Generated by Fuzzlyn on 2018-06-04 01:08:20
// Seed: 9307920185443613861
// Reduced from 35.6 KB to 0.3 KB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static int[, ] s_20 = new int[, ]{{0}};
    public static void Main()
    {
        byte vr29 = (byte)(0 & s_20[0, 0]);
        s_20 = s_20;
        System.Console.WriteLine(vr29);
        System.Console.WriteLine(s_20[0, 0]);
    }
}
