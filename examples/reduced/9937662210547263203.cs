// Generated by Fuzzlyn on 2018-06-04 01:19:04
// Seed: 9937662210547263203
// Reduced from 116.3 KB to 0.3 KB
// Debug: Outputs 146
// Release: Outputs 4294967186
class C0
{
    public uint F7;
    public C0()
    {
    }
}

public class Program
{
    static sbyte s_8 = -110;
    static C0[][] s_9 = new C0[][]{new C0[]{new C0()}};
    public static void Main()
    {
        s_9[0][0].F7 = (byte)(0L | s_8);
        System.Console.WriteLine(s_9[0][0].F7);
    }
}
