// Generated by Fuzzlyn on 2018-06-04 00:32:32
// Seed: 7739025950339802573
// Reduced from 93.8 KB to 0.2 KB
// Debug: Outputs 1
// Release: Outputs 67
public class Program
{
    public static void Main()
    {
        var vr67 = new byte[]{52};
        vr67[0] = 254;
        vr67[0] = (byte)('C' % (-70 | vr67[0]));
        System.Console.WriteLine(vr67[0]);
    }
}
