// Generated by Fuzzlyn on 2018-06-03 22:47:53
// Seed: 14574763782559838994
// Reduced from 2.4 KB to 0.2 KB
// Debug: Outputs 2094
// Release: Outputs 0
public class Program
{
    public static void Main()
    {
        ushort[] vr2 = new ushort[]{65535};
        short vr3 = (short)(18849 / (byte)(int)(10L + vr2[0]));
        System.Console.WriteLine(vr3);
    }
}
