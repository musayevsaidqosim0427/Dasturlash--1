using System;

class Program
{
    static int Katta(int a, int b)
    {
        if (a > b)
            return a;
        else
            return b;
    }

    static void Main()
    {
        Console.Write("Birinchi sonni kiriting: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Ikkinchi sonni kiriting: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Katta son: " + Katta(a, b));
    }
}
