// Generated by Fuzzlyn on 2018-06-03 23:19:53
// Seed: 17340061302800513795
// Reduced from 2.7 KB to 0.4 KB
// Debug: Outputs -1108443763
// Release: Outputs 32141
class C0
{
    public int F1;
    public C0(uint f0, int f1)
    {
        F1 = f1;
    }
}

public class Program
{
    public static void Main()
    {
        C0 vr5 = new C0(10U, -1108443763);
        vr5 = new C0((char)vr5.F1, M1(vr5.F1));
    }

    static byte M1(int arg1)
    {
        System.Console.WriteLine(arg1);
        return 180;
    }
}