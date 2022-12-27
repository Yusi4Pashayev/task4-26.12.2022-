using System.Globalization;

namespace task4_26._12._2022_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            4.Rəqəmlərin yoxlanilması
            //Verilmiş n ədədin rəqəmlərinin müxtəlif olduğunu yoxlayan proqram yazın
            //Giris: 12546
            //Cixis: Muxtelifreqemli

            Console.Write("Eded daxil edin:");
            int number=int.Parse(Console.ReadLine());
            int a, b, c, d, e, f, g, h, i, j,  newnumber;
            a = b = c = d = e = f = g = h = i = j = 0;

            while (number > 0)
            {
                newnumber = number % 10;
                number = number / 10;

                switch (newnumber)
                {
                    case 1:
                        a = a + 1;
                        break;
                    case 2:
                        b = b + 1;
                        break;
                    case 3:
                        c = c + 1;
                        break;
                    case 4:
                        d = d + 1;
                        break;
                    case 5:
                        e = e + 1;
                        break;
                    case 6:
                        f = f + 1;
                        break;
                    case 7:
                        g = g + 1;
                        break;
                    case 8:
                        h = h + 1;
                        break;
                    case 9:
                        i = i + 1;
                        break;
                    case 0:
                        j = j + 1;
                        break;

                }
            }

            if (a > 1) Console.WriteLine($"1 reqemi {a} defe tekrarlanib");
            if (b > 1) Console.WriteLine($"2 reqemi {b} defe tekrarlanib");
            if (c > 1) Console.WriteLine($"3 reqemi {c} defe tekrarlanib");
            if (d > 1) Console.WriteLine($"4 reqemi {d} defe tekrarlanib");
            if (e > 1) Console.WriteLine($"5 reqemi {e} defe tekrarlanib");
            if (f > 1) Console.WriteLine($"6 reqemi {f} defe tekrarlanib");
            if (g > 1) Console.WriteLine($"7 reqemi {g} defe tekrarlanib");
            if (h > 1) Console.WriteLine($"8 reqemi {h} defe tekrarlanib");
            if (i > 1) Console.WriteLine($"9 reqemi {i} defe tekrarlanib");
            if (j > 1) Console.WriteLine($"0 reqemi {j} defe tekrarlanib");
            if (a <= 1 && b <= 1 && c <= 1 && d <= 1 && e <= 1 && f <= 1 && g <= 1 && h <= 1 && i <= 1 && j <= 1) Console.WriteLine("hec bir reqem tekrarlanmayib");

        }
    }
}