// Generated by Fuzzlyn on 2018-06-03 23:16:45
// Seed: 17266971542552460528
// Reduced from 232.3 KB to 0.4 KB
// Debug: Throws 'System.OverflowException'
// Release: Runs successfully
public class Program
{
    public static void Main()
    {
        ushort vr115 = 65534;
        var vr116 = (char)vr115;
        int vr117 = (char)(619077040 / (10U - (0UL & (ushort)(-2147483648 / (sbyte)(M1(vr116) | 1)))));
    }

    static ushort M1(char arg0)
    {
        System.Console.WriteLine((int)arg0);
        return 65534;
    }
}