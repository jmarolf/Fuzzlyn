// Generated by Fuzzlyn on 2018-06-03 22:30:46
// Seed: 12608692609812968309
// Reduced from 142.8 KB to 0.5 KB
// Debug: Outputs 1
// Release: Outputs 0
public class Program
{
    static bool s_9 = true;
    static uint s_13 = 3851437713U;
    static short[] s_15 = new short[]{1};
    static ulong[] s_18 = new ulong[]{11161413193656714398UL};
    static uint s_25 = 1U;
    public static void Main()
    {
        var vr143 = s_15[0];
        s_9 = M59(vr143, s_9);
    }

    static bool M59(short arg0, bool arg2)
    {
        s_18[0] >>= (int)(s_13 % s_25);
        short var0 = arg0;
        System.Console.WriteLine(var0);
        return arg2;
    }
}