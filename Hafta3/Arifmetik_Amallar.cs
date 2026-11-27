
using System;

class Program
{
    static void Main()
    {
        int a = 15;
        int b = 4;

        Console.WriteLine("Birinchi son: " + a);
        Console.WriteLine("Ikkinchi son: " + b);

        Console.WriteLine("Yig'indisi: " + (a + b));
        Console.WriteLine("Ayirmasi: " + (a - b));
        Console.WriteLine("Ko'paytmasi: " + (a * b));
        Console.WriteLine("Bo'linmasi: " + ((double)a / b));
        Console.WriteLine("Qoldig'i: " + (a % b));
    }
}
