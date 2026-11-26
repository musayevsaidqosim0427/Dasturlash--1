
using System;

class Program
{
    // 1-topshiriq: Unli harflar sonini hisoblash
    static int UnliSanoq(string matn)
    {
        int sanoq = 0;
        string unlilar = "aeiouAEIOU";

        foreach (char harf in matn)
        {
            if (char.IsLetter(harf) && unlilar.Contains(harf))
            {
                sanoq++;
            }
        }

        return sanoq;
    }

    // 2-topshiriq: Ikkita sondan kattasini topish
    static int Katta(int a, int b)
    {
        if (a > b)
            return a;
        else
            return b;
    }

    // 3-topshiriq: Sonlarning o'rtachasini hisoblash
    static double Ortacha(params int[] sonlar)
    {
        if (sonlar.Length == 0)
            return 0;

        int yigindi = 0;

        foreach (int son in sonlar)
        {
            yigindi += son;
        }

        return (double)yigindi / sonlar.Length;
    }

    // 4-topshiriq: Fibonachchi sonini rekursiya yordamida hisoblash
    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main()
    {
        // 1-topshiriq
        Console.WriteLine("--- 1-TOPSHIRIQ ---");
        Console.Write("Matn kiriting: ");
        string matn = Console.ReadLine() ?? "";

        Console.WriteLine("Unli harflar soni: " + UnliSanoq(matn));

        // 2-topshiriq
        Console.WriteLine("\n--- 2-TOPSHIRIQ ---");
        Console.Write("Birinchi sonni kiriting: ");
        int a = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Ikkinchi sonni kiriting: ");
        int b = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Katta son: " + Katta(a, b));

        // 3-topshiriq
        Console.WriteLine("\n--- 3-TOPSHIRIQ ---");
        Console.WriteLine("Sonlarning o'rtachasi: " + Ortacha(10, 20, 30, 40, 50));

        // 4-topshiriq
        Console.WriteLine("\n--- 4-TOPSHIRIQ ---");
        Console.Write("Fibonachchi indeksini kiriting: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        if (n >= 0 && n <= 45)
        {
            Console.WriteLine("Fibonachchi soni: " + Fibonacci(n));
        }
        else
        {
            Console.WriteLine("0 dan 45 gacha son kiriting!");
        }
    }
}
