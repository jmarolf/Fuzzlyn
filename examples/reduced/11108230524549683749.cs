// Generated by Fuzzlyn on 2018-06-03 22:10:00
// Seed: 11108230524549683749
// Reduced from 5.2 KB to 0.3 KB
// Debug: Outputs 59280
// Release: Outputs 4294961040
public class Program
{
    static sbyte s_1 = 101;
    public static void Main()
    {
        s_1 %= s_1;
        var vr18 = 9183913460816025711L;
        var vr20 = s_1--;
        var vr22 = (char)(s_1 ^ (ushort)vr18);
        uint vr24 = vr22;
        System.Console.WriteLine(vr24);
    }
}