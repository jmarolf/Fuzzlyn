// Generated by Fuzzlyn on 2018-06-03 22:09:59
// Seed: 11073346900054231394
struct S0
{
    public long F0;
    public S0(long f0)
    {
        F0 = f0;
    }
}

class C0
{
    public S0 F0;
    public S0 F1;
    public ulong F2;
    public sbyte F3;
    public C0(S0 f0, S0 f1, ulong f2, sbyte f3)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
        F3 = f3;
    }
}

struct S1
{
    public C0 F0;
    public S1(C0 f0)
    {
        F0 = f0;
    }
}

class C1
{
    public sbyte F0;
    public uint F1;
    public C1(sbyte f0, uint f1)
    {
        F0 = f0;
        F1 = f1;
    }
}

public class Program
{
    static uint s_1 = 846000890U;
    static ushort s_2 = 10;
    static sbyte s_3 = 4;
    static ushort s_4 = 8095;
    static char s_5 = '_';
    static sbyte s_6 = -128;
    static ushort s_7 = 0;
    static ushort s_8 = 1;
    static ushort s_9 = 60137;
    static char s_10 = '?';
    static short[] s_11 = new short[]{0, 2624, 31531, -2, 1, -32141, 0, 1, 3437, -10};
    static char s_12 = ' ';
    public static void Main()
    {
        M0();
    }

    static void M0()
    {
        if (true)
        {
            M1(new C0(new S0(1L), new S0(-7686060440423707192L), 6209630718429692226UL, 86));
        }
        else
        {
            s_4 = 0;
            s_2 = (ushort)M2(true);
        }

        {
            M3();
            s_3 = s_3;
            {
                {
                    s_3 = s_3;
                    M2(true);
                    {
                        {
                            s_2 = s_4;
                        }

                        if (false)
                        {
                            M3();
                            s_3 = s_3--;
                            s_2 = 47819;
                            s_2 = 1;
                            s_2 = M4(M8(s_1), 0);
                            if (true)
                            {
                                s_3 = s_6;
                                bool[, ] var0 = new bool[, ]{{true}, {true}, {false}, {true}};
                            }
                            else
                            {
                                s_3 = (sbyte)M4(-8132483381793483138L, (int)M2(s_4 > -1));
                                s_5 = 'h';
                                s_3 = -14;
                                sbyte[] var1 = new sbyte[]{126, -68, 12, -71, -32, -15, 1, 65};
                            }
                        }
                    }
                }

                C0 var2 = M9(s_4);
                s_3 = s_6;
                s_1 = s_1;
                if (M10(new ushort[, ][][, ]{{new ushort[][, ]{new ushort[, ]{{39896}}, new ushort[, ]{{51263}}}, new ushort[][, ]{new ushort[, ]{{0}, {32254}}, new ushort[, ]{{17036}}, new ushort[, ]{{2}, {1}, {635}}, new ushort[, ]{{1}, {0}, {1122}}}, new ushort[][, ]{new ushort[, ]{{65534}, {2}, {1239}}, new ushort[, ]{{0}, {22218}, {21648}}, new ushort[, ]{{2702}}, new ushort[, ]{{127}, {62951}}, new ushort[, ]{{65534}, {8954}, {1}}}}, {new ushort[][, ]{new ushort[, ]{{0}}, new ushort[, ]{{1}, {10}}}, new ushort[][, ]{new ushort[, ]{{0}, {1}}, new ushort[, ]{{17994}}}, new ushort[][, ]{new ushort[, ]{{19418}, {65535}}, new ushort[, ]{{65535}, {0}, {6969}}}}, {new ushort[][, ]{new ushort[, ]{{0}}}, new ushort[][, ]{new ushort[, ]{{65534}, {65416}, {0}}, new ushort[, ]{{29780}, {1}}, new ushort[, ]{{39683}}, new ushort[, ]{{37311}, {37942}, {43466}}}, new ushort[][, ]{new ushort[, ]{{8681}}, new ushort[, ]{{2}, {1}}}}}, s_5, new C0(new S0(1668479314338345797L), new S0(4932802963108281905L), 1UL, 113)))
                {
                    var2.F1 = new S0(9223372036854775807L);
                    var2.F0.F0 = 9223372036854775807L;
                    s_1 = (uint)M4(var2.F0.F0, (char)M2(M10(new ushort[, ][][, ]{{new ushort[][, ]{new ushort[, ]{{65534}}}, new ushort[][, ]{new ushort[, ]{{65535}}}, new ushort[][, ]{new ushort[, ]{{51911}, {22822}, {0}}, new ushort[, ]{{31478}, {0}, {0}}}, new ushort[][, ]{new ushort[, ]{{18897}, {0}, {0}}, new ushort[, ]{{12205}, {42605}}}}, {new ushort[][, ]{new ushort[, ]{{61098}, {0}}}, new ushort[][, ]{new ushort[, ]{{43401}, {0}, {42462}}, new ushort[, ]{{47803}}}, new ushort[][, ]{new ushort[, ]{{37305}, {62302}, {22587}}, new ushort[, ]{{65535}}}, new ushort[][, ]{new ushort[, ]{{0}, {10}, {63704}}}}, {new ushort[][, ]{new ushort[, ]{{6851}}}, new ushort[][, ]{new ushort[, ]{{21362}}}, new ushort[][, ]{new ushort[, ]{{1}, {4194}, {1}}, new ushort[, ]{{60284}, {22351}}}, new ushort[][, ]{new ushort[, ]{{1}}}}, {new ushort[][, ]{new ushort[, ]{{54975}, {41008}, {65534}}, new ushort[, ]{{36595}, {1}}}, new ushort[][, ]{new ushort[, ]{{12725}}}, new ushort[][, ]{new ushort[, ]{{43523}, {65534}, {0}}}, new ushort[][, ]{new ushort[, ]{{1}, {56353}}, new ushort[, ]{{2526}, {0}}}}, {new ushort[][, ]{new ushort[, ]{{15574}, {3507}, {1}}}, new ushort[][, ]{new ushort[, ]{{10}, {9262}}}, new ushort[][, ]{new ushort[, ]{{1}}}, new ushort[][, ]{new ushort[, ]{{1}, {1}, {34496}}}}, {new ushort[][, ]{new ushort[, ]{{1}}, new ushort[, ]{{0}, {65534}}}, new ushort[][, ]{new ushort[, ]{{1}, {30003}}, new ushort[, ]{{47161}, {1}, {2658}}}, new ushort[][, ]{new ushort[, ]{{65535}, {1}}, new ushort[, ]{{65535}, {60868}}}, new ushort[][, ]{new ushort[, ]{{26536}, {57135}, {61674}}, new ushort[, ]{{2}}}}, {new ushort[][, ]{new ushort[, ]{{0}}}, new ushort[][, ]{new ushort[, ]{{44855}}}, new ushort[][, ]{new ushort[, ]{{0}, {27242}}}, new ushort[][, ]{new ushort[, ]{{62684}, {19798}}}}, {new ushort[][, ]{new ushort[, ]{{0}}}, new ushort[][, ]{new ushort[, ]{{37698}}}, new ushort[][, ]{new ushort[, ]{{4942}, {28716}}}, new ushort[][, ]{new ushort[, ]{{1}}, new ushort[, ]{{1}, {33048}}}}, {new ushort[][, ]{new ushort[, ]{{48863}}}, new ushort[][, ]{new ushort[, ]{{0}, {3022}, {65534}}, new ushort[, ]{{65534}, {11441}, {46934}}}, new ushort[][, ]{new ushort[, ]{{3282}, {17598}}}, new ushort[][, ]{new ushort[, ]{{0}}}}}, s_5, var2)) * 48329987);
                    if (true)
                    {
                        s_3 = var2.F3;
                    }
                    else
                    {
                        s_4 = 2;
                    }

                    s_9 = M7();
                    s_6 = var2.F3++;
                    s_10 = (char)M11(s_1, 32766);
                    s_1 = 2387128438U;
                }
                else
                {
                    M5(0);
                    M3();
                }

                s_6 = s_6--;
            }

            if (false)
            {
                s_5 = (char)(s_8-- % (uint)(s_1 | 1));
                if (M10(new ushort[, ][][, ]{{new ushort[][, ]{new ushort[, ]{{44312, 50920}, {33087, 4078}, {1, 23734}, {25455, 4924}}}, new ushort[][, ]{new ushort[, ]{{11132, 1}, {2, 2}, {1, 1}, {19192, 0}, {891, 10412}, {8984, 62865}}}, new ushort[][, ]{new ushort[, ]{{29398, 2}, {1, 0}, {1, 24423}, {61087, 17254}, {0, 4026}}}, new ushort[][, ]{new ushort[, ]{{5909, 0}, {0, 0}, {13804, 1}, {30749, 34601}}}, new ushort[][, ]{new ushort[, ]{{10, 65535}, {65534, 65534}, {65535, 28391}}}, new ushort[][, ]{new ushort[, ]{{18857, 64387}, {35245, 58647}}}, new ushort[][, ]{new ushort[, ]{{43701, 65534}, {62277, 1}}}, new ushort[][, ]{new ushort[, ]{{45407, 9989}, {41129, 29381}, {2, 0}, {1, 0}, {36263, 19627}, {13996, 51470}}}, new ushort[][, ]{new ushort[, ]{{50929, 11916}, {55367, 58578}, {0, 62315}, {0, 23215}}}}, {new ushort[][, ]{new ushort[, ]{{1, 45462}}}, new ushort[][, ]{new ushort[, ]{{61859, 44881}, {28555, 9461}, {32783, 1}, {0, 0}}}, new ushort[][, ]{new ushort[, ]{{0, 0}}}, new ushort[][, ]{new ushort[, ]{{0, 30353}, {65534, 3862}, {12204, 65534}, {51543, 65534}, {0, 64168}, {1, 1}}}, new ushort[][, ]{new ushort[, ]{{10, 48440}}}, new ushort[][, ]{new ushort[, ]{{61470, 0}, {0, 1}, {28687, 31858}, {1, 34336}, {42989, 0}}}, new ushort[][, ]{new ushort[, ]{{0, 43693}, {0, 1}}}, new ushort[][, ]{new ushort[, ]{{18927, 65535}, {36694, 63082}, {13374, 0}, {22523, 0}}}, new ushort[][, ]{new ushort[, ]{{17476, 25752}}}}}, s_5, new C0(new S0(3834449964616349111L), new S0(0L), 1UL, -88)))
                {
                    s_2 = s_8;
                    {
                        s_2 = M11((uint)M4((long)M4(0L, (int)(s_10 + -9223372036854775807L)), (int)M1(new C0(new S0(-9223372036854775808L), new S0(-1L), 4558199299481720750UL, 1))), (short)M7());
                    }
                }
                else
                {
                    s_11 = new short[]{10, 5800, -10, 0, -23590, -24227, -2};
                    s_3 = s_3++;
                    return;
                }
            }

            s_2 = s_7;
            {
                if (true)
                {
                    s_2 = M12(s_8);
                    s_7 = 1;
                }
                else
                {
                    s_5 = '|';
                }

                s_8 = s_7++;
                C0 var3 = new C0(new S0(-9223372036854775807L), new S0(-1594252571662435667L), 12811166082943402603UL, 0);
                {
                    s_9 = s_9--;
                }

                s_12 = s_5;
                if (M10(new ushort[, ][][, ]{{new ushort[][, ]{new ushort[, ]{{50778, 0}}, new ushort[, ]{{0, 1}, {33621, 32752}}}}, {new ushort[][, ]{new ushort[, ]{{65535, 64450}}, new ushort[, ]{{45865, 29241}}}}, {new ushort[][, ]{new ushort[, ]{{28184, 1}}, new ushort[, ]{{0, 38304}, {28509, 0}, {15692, 5215}, {4286, 3244}}, new ushort[, ]{{65534, 64098}, {2, 48770}, {5426, 43574}, {28188, 15761}}}}, {new ushort[][, ]{new ushort[, ]{{0, 54536}, {20551, 39169}}, new ushort[, ]{{0, 65534}, {1, 0}, {58537, 1793}, {0, 27914}, {65534, 1}}}}}, 'R', new C0(new S0(0L), new S0(2803325218001267790L), 15342684433477756522UL, -128)))
                {
                    if (false)
                    {
                        s_1 = s_1;
                    }
                }
            }

            {
                s_3 = s_3;
                s_1 = 0U;
                s_4 = s_9;
            }

            C0 var4 = new C0(new S0(-1391767310445177640L), new S0(-2399441993762215134L), 0UL, 28);
        }

        s_6 = 96;
    }

    static char M1(C0 arg0)
    {
        s_1 = 535037136U;
        if (true)
        {
            return 'f';
        }
        else
        {
            --arg0.F0.F0;
            {
                if (true)
                {
                    M2(true);
                    arg0.F1 = arg0.F1;
                    M3();
                    arg0.F3 = (sbyte)M2((byte)M2(true) <= arg0.F0.F0);
                    if (true)
                    {
                        s_1 %= (uint)(s_1 | 1);
                        arg0.F2 = arg0.F2;
                        s_1 = (uint)('P' * arg0.F2);
                    }
                    else
                    {
                        arg0.F1.F0 = arg0.F1.F0;
                        bool var0 = true;
                    }
                }
                else
                {
                    arg0.F1.F0 = arg0.F1.F0++ / (uint)(s_1 | 1);
                    if ('4' <= (int)M2(false))
                    {
                        arg0.F2 = arg0.F2;
                    }
                    else
                    {
                        if (false)
                        {
                            S1 var1 = new S1(new C0(new S0(1L), new S0(-9223372036854775808L), 17781468042773272493UL, -60));
                            M2(false);
                        }

                        arg0.F1 = new S0(1L);
                    }

                    {
                        s_3 = arg0.F3;
                        arg0.F1.F0 = 0L;
                    }

                    arg0.F0 = new S0(-9223372036854775808L);
                }
            }

            M3();
            M2(false);
            {
                int var2 = 0;
                {
                    M2(true);
                    arg0.F1.F0 = arg0.F1.F0;
                }

                S1 var3 = new S1(new C0(new S0(10L), new S0(-9223372036854775807L), 8521528751685839631UL, -127));
                if (false)
                {
                    s_3 = arg0.F3;
                    s_2 = s_2--;
                }
                else
                {
                    s_3 = s_3;
                    s_4 = s_4;
                }

                if (false)
                {
                    s_1 = s_1;
                    var3.F0.F1.F0 = 0L;
                }

                M2(false);
                var2 = var2;
                arg0.F3 = var3.F0.F3;
                arg0.F2 = var3.F0.F2;
                M3();
                var2 = var2++;
            }

            {
                arg0.F1 = new S0(5507010095540219744L);
                {
                    s_4 = 6514;
                    {
                        {
                            S1[] var4 = new S1[]{new S1(new C0(new S0(0L), new S0(-9223372036854775808L), 18446744073709551614UL, 101)), new S1(new C0(new S0(1L), new S0(3165975396075952809L), 16051887474889458740UL, -24)), new S1(new C0(new S0(9223372036854775806L), new S0(6588300571668993638L), 9626382685383653408UL, -128)), new S1(new C0(new S0(-356175536350310216L), new S0(-1165502578061024386L), 0UL, -109)), new S1(new C0(new S0(1L), new S0(-280591353401362163L), 10UL, 126)), new S1(new C0(new S0(0L), new S0(1L), 0UL, 126)), new S1(new C0(new S0(6214488749551993551L), new S0(4548562326838011366L), 2728263335934905466UL, -82)), new S1(new C0(new S0(-2754921019896383384L), new S0(-3953053966652711087L), 10UL, -64))};
                            var4[0].F0.F1 = var4[0].F0.F1;
                            M2(false);
                            var4[0].F0.F1 = var4[0].F0.F1;
                            s_5 = s_5;
                            S0 var5 = arg0.F0;
                            long var6 = (long)(60 & s_3);
                        }

                        M2(true);
                        arg0.F3++;
                    }

                    return 'Z';
                }

                arg0.F0.F0 = arg0.F1.F0;
                M3();
            }

            ulong[][, ] var7 = new ulong[][, ]{new ulong[, ]{{569182545616794366UL, 0UL, 18446744073709551614UL, 1535882914896187902UL, 2440091384071389043UL, 14229749236976215203UL, 4270257104707568526UL}, {18446744073709551614UL, 1UL, 10UL, 3658177537697377119UL, 1UL, 12867588365823973936UL, 0UL}}, new ulong[, ]{{0UL, 0UL, 0UL, 3801590256649448419UL, 0UL, 1UL, 13084566986813255934UL}, {18446744073709551615UL, 13905361717816602335UL, 11070253390964127733UL, 0UL, 14645483729170831577UL, 0UL, 14246971677273169835UL}}, new ulong[, ]{{7490967031371912948UL, 3036203474258578287UL, 13977310537642693746UL, 0UL, 2UL, 7523807085709604455UL, 12064584919077434348UL}}, new ulong[, ]{{12231039409029748707UL, 15184464596124591483UL, 8764221119298819409UL, 1UL, 17469148403675652052UL, 16083127688231635080UL, 18446744073709551614UL}}, new ulong[, ]{{16217660047656606628UL, 4001161339532533470UL, 12163010090783907221UL, 18446744073709551614UL, 1029415172211102784UL, 14955826827203951378UL, 1UL}}, new ulong[, ]{{5833360977121164136UL, 6868173862587243357UL, 6871811518469724159UL, 3306124896038334372UL, 1563618272098863428UL, 10474071115688721530UL, 10UL}, {1UL, 18446744073709551614UL, 9591067459565911745UL, 1UL, 0UL, 11774912581984531588UL, 0UL}}, new ulong[, ]{{0UL, 10127488400482556909UL, 1396577412313185078UL, 4003581789616077059UL, 0UL, 18446744073709551615UL, 15891728220404411782UL}, {10013518801743352543UL, 16152454160967561709UL, 2969788070214226092UL, 0UL, 1UL, 10358028565789007996UL, 1UL}}, new ulong[, ]{{0UL, 18446744073709551614UL, 0UL, 18446744073709551615UL, 0UL, 15101535588899757025UL, 10UL}, {4237509250279708007UL, 18446744073709551614UL, 1UL, 11119273297008160656UL, 10UL, 18446744073709551614UL, 10726254201944354466UL}}};
            s_5 = s_5;
            M3();
        }

        return s_5;
    }

    static ulong M2(bool arg0)
    {
        s_1 = s_1;
        arg0 = arg0;
        return 1UL;
    }

    static S0[, ] M3()
    {
        s_1 = s_1--;
        s_2 = 1;
        S1 var0 = new S1(new C0(new S0(-9053049048193193067L), new S0(0L), 18446744073709551615UL, 1));
        return new S0[, ]{{new S0(5626190705970323267L), new S0(3256755613706406924L), new S0(1L)}, {new S0(9223372036854775806L), new S0(2L), new S0(1L)}, {new S0(-9223372036854775808L), new S0(9223372036854775806L), new S0(9223372036854775806L)}, {new S0(-5524566420843586449L), new S0(-10L), new S0(-1L)}};
    }

    static ushort M4(long arg0, int arg1)
    {
        if (false)
        {
            {
                {
                    if (true)
                    {
                        {
                            s_6 = s_3;
                            s_2 = s_4;
                        }

                        s_7 <<= 2147483647;
                        s_3 |= s_3--;
                        C0 var0 = new C0(new S0(2L), new S0(0L), 9837644614317491648UL, s_6);
                        M5(s_2);
                        var0.F0 = var0.F0;
                        var0.F1.F0 = var0.F1.F0--;
                    }
                    else
                    {
                        s_8 = s_4;
                        byte var1 = 2;
                        M5(s_2++);
                        M7();
                    }

                    s_1 = s_1;
                    M7();
                    s_3 = s_3++;
                    uint[,, ] var2 = new uint[,, ]{{{1U, 0U}, {0U, 335901424U}, {3329477134U, 2712279489U}, {1U, 1U}, {3716466439U, 2747664921U}, {1U, 2706739984U}}};
                }

                s_7 = s_7;
                M7();
                arg0 = 2L;
                long var3 = arg0;
                M5(s_2);
                M5(s_8);
            }
        }

        return 46889;
    }

    static ushort[] M5(ushort arg0)
    {
        C0[] var0 = new C0[]{new C0(new S0(-1343378209177874991L), new S0(1626487047184424691L), 14338431731344779345UL, 80), new C0(new S0(9223372036854775807L), new S0(-7355287178831194485L), 1UL, -81), new C0(new S0(7371772918902697677L), new S0(8674983025391772085L), 1610263912013510191UL, 1), new C0(new S0(3144861531924677210L), new S0(-66661252930336962L), 3546514074252009448UL, -91), new C0(new S0(-4656092296110881961L), new S0(-3831680923676101008L), 18446744073709551614UL, 1), new C0(new S0(-6004127002962765200L), new S0(-8225654234112529760L), 10005550970466850414UL, -13), new C0(new S0(0L), new S0(2527934944983769946L), 18446744073709551614UL, 4), new C0(new S0(7816031718450076492L), new S0(-9223372036854775808L), 1UL, 126), new C0(new S0(-10L), new S0(-6281958666163577086L), 18446744073709551615UL, 1)};
        {
            var0[0] = var0[0];
            if (true)
            {
                var0[0].F0 = var0[0].F1;
            }
            else
            {
                s_7 = s_4;
                var0[0].F2 += var0[0].F2;
                S1 var1 = new S1(new C0(new S0(-2144620709378650667L), new S0(0L), 10UL, 2));
                {
                    if (false)
                    {
                        arg0 = arg0;
                        var1.F0.F0.F0 = var0[0].F1.F0 | 1;
                        var1.F0 = var1.F0;
                        var1.F0.F0.F0 = 1L;
                        M6();
                    }

                    s_8 = 2;
                    if (false)
                    {
                        sbyte var2 = var1.F0.F3;
                        M7();
                        char[][] var3 = new char[][]{new char[]{'5', 'D', 'D', '=', 'R', 'O', ';'}, new char[]{'(', 'g', '<'}, new char[]{'i', 'L', 'D', 'x'}, new char[]{'t', '3', 'q', 'Q', 'x', '8', 'T'}, new char[]{'`', 'Q'}, new char[]{'d', '"', 'S'}};
                    }
                    else
                    {
                        arg0 = 0;
                        C0 var4 = new C0(new S0(-4267311932612672981L), new S0(-6168862286059639852L), 2741217338383289954UL, 1);
                        M7();
                        var0[0].F1.F0 = 5555806712368512685L;
                        var4.F3 = s_3;
                        char[][] var5 = new char[][]{new char[]{'g', 'n'}, new char[]{'5', ';', 'v', 'x', 'Y'}, new char[]{'O', 'O', '2', '7'}, new char[]{'8', 's', 'm'}, new char[]{'f', 'r', 'A', 'u'}, new char[]{'&', '{', 'V', 'D', '<'}, new char[]{'('}, new char[]{'3'}};
                    }

                    s_5 = s_5;
                }

                s_1 = (uint)(0L + (byte)M7());
                var0[0].F1.F0 = var1.F0.F0.F0;
            }

            var0[0].F1 = var0[0].F1;
        }

        if (true)
        {
            s_3 = s_3--;
            M6();
        }

        var0[0] = new C0(new S0(0L), new S0(-9223372036854775808L), 11365811670504873473UL, -89);
        return new ushort[]{45955, 19016, 0, 0, 1, 46550, 65535, 2, 48450, 43921};
    }

    static C1 M6()
    {
        if (true)
        {
            s_5 = s_5;
        }
        else
        {
            s_4 = M7();
            s_2 = s_2;
        }

        return new C1(-98, 1U);
    }

    static ushort M7()
    {
        s_1 = (uint)(1254663230 & (byte)(1L ^ s_3));
        return s_4;
    }

    static long M8(uint arg0)
    {
        s_8 = s_8;
        s_8 = s_2;
        s_3 = 1;
        s_2 = s_7++;
        return 4969691923163891131L;
    }

    static C0 M9(ushort arg0)
    {
        M10(new ushort[, ][][, ]{{new ushort[][, ]{new ushort[, ]{{0, 65534, 65534, 7650, 16844, 0}, {0, 65534, 1, 17533, 1, 37991}, {2579, 14980, 1, 2, 65535, 1}, {1, 10, 24185, 32012, 10006, 0}, {0, 59610, 0, 10, 60398, 11847}}}, new ushort[][, ]{new ushort[, ]{{63488, 65535, 0, 50486, 1, 50576}, {28886, 20669, 65534, 1, 21127, 0}, {49552, 2, 63618, 1, 42444, 65534}}}}, {new ushort[][, ]{new ushort[, ]{{61406, 45383, 50511, 1, 65534, 0}, {28497, 1, 55650, 0, 64763, 1}, {21539, 65534, 1, 63640, 44716, 42322}, {0, 2, 0, 1, 7232, 0}, {0, 36473, 59731, 1, 39483, 65535}, {1, 1, 0, 19662, 21028, 36309}, {0, 513, 65535, 56589, 52363, 1}, {0, 40471, 44589, 63943, 0, 20225}}}, new ushort[][, ]{new ushort[, ]{{60477, 1, 10147, 1, 10, 0}, {57692, 0, 65534, 0, 1, 1}}}}, {new ushort[][, ]{new ushort[, ]{{1, 0, 0, 0, 31776, 65534}, {0, 1, 5574, 10, 7679, 1}}}, new ushort[][, ]{new ushort[, ]{{0, 39749, 10, 39006, 61538, 2}, {65534, 20495, 10123, 56395, 42214, 1}, {0, 2, 20632, 35899, 49309, 52954}}}}}, s_5, new C0(new S0(2273455809368433149L), new S0(0L), 0UL, 108));
        bool var0 = false;
        s_9 = s_4;
        s_6 *= -59;
        return new C0(new S0(-3897637685553474804L), new S0(-9223372036854775807L), 0UL, -85);
    }

    static bool M10(ushort[, ][][, ] arg0, char arg1, C0 arg2)
    {
        C0 var0 = arg2;
        if (false)
        {
            var0.F1 = var0.F1;
        }

        M11(755047832U, (short)M11(s_1--, 32767));
        {
            uint var1 = (uint)M11(s_1, -9699);
            ushort var2 = s_4;
            arg1 = arg1;
            {
                if (false)
                {
                    if (true)
                    {
                        arg2.F1.F0 = (long)M11(s_1, 6422);
                        if (false)
                        {
                            M11((uint)(arg1-- % (char)(s_5 | 1)), -31217);
                            arg2.F2 = 13270741382458182989UL;
                            s_3 = (sbyte)M11(var1++, (short)M11(s_1, 19342));
                        }
                        else
                        {
                            var1 = (uint)((byte)M11(s_1, 7976) - 10);
                            {
                                char var3 = arg1;
                            }
                        }

                        M11(var1, -32767);
                    }

                    M11(s_1, (short)M11((uint)M11((uint)M11(1U, (short)M11(s_1, 0)), 9496), 26130));
                    arg2.F1.F0 = arg2.F0.F0;
                    arg2.F0.F0 = 1L;
                    short var4 = 0;
                    {
                        arg2.F0 = new S0(2L);
                    }

                    arg2.F0.F0 = -8554174493584814319L;
                }
                else
                {
                    s_1 = var1++;
                    {
                        S1 var5 = new S1(new C0(new S0(10L), new S0(1974699954282622795L), 2499354769599976189UL, -127));
                        C0 var6 = arg2;
                        M11(var1, -32768);
                        arg0[0, 0][0] = new ushort[, ]{{42785, 1, 34554, 0, 16028, 0, 15734}};
                        C1[] var7 = new C1[]{new C1(-16, 3474230677U), new C1(-98, 0U), new C1(0, 1945806210U), new C1(36, 480110893U), new C1(116, 0U), new C1(1, 0U), new C1(-10, 3521640822U), new C1(-70, 4020485359U), new C1(2, 1649996076U), new C1(-127, 1622115057U)};
                        arg2 = new C0(new S0(-9223372036854775807L), new S0(2879441618419230164L), 2131589116604329626UL, 127);
                    }

                    arg0 = arg0;
                    C0 var8 = arg2;
                    var1 = 0U;
                    var0.F0.F0 = -7061767398751631356L;
                    long var9 = var0.F1.F0;
                    if (true)
                    {
                        S0 var10 = var8.F0;
                    }

                    return true;
                }

                s_2 = var2;
                s_8 = s_2;
            }

            {
                long[] var11 = new long[]{3444536430880297847L, -700736780039830532L, -9223372036854775808L};
                var2 = 49807;
            }

            s_7 = var2;
        }

        return true;
    }

    static ushort M11(uint arg0, short arg1)
    {
        s_7 = s_8;
        s_4 = 65535;
        arg1 = arg1;
        return s_2;
    }

    static ushort M12(ushort arg0)
    {
        sbyte var0 = s_6;
        s_5 = s_5;
        s_2 = 2;
        long var1 = 1L;
        if (true)
        {
            {
                s_4 = 40238;
                s_11 = s_11;
            }
        }
        else
        {
            s_11 = s_11;
            s_11[0] = 32766;
        }

        return s_7;
    }
}