
using System;

class Program
{
    static void Main()
    {
        double[] harorat = new double[7];

        Console.WriteLine("7 kunlik haroratni kiriting:");

        for (int i = 0; i < 7; i++)
        {
            Console.Write((i + 1) + "-kun: ");
            harorat[i] = Convert.ToDouble(Console.ReadLine());
        }

        double engIssiq = harorat[0];
        double engSovuq = harorat[0];

        int issiqKun = 1;
        int sovuqKun = 1;

        for (int i = 1; i < 7; i++)
        {
            if (harorat[i] > engIssiq)
            {
                engIssiq = harorat[i];
                issiqKun = i + 1;
            }

            if (harorat[i] < engSovuq)
            {
                engSovuq = harorat[i];
                sovuqKun = i + 1;
            }
        }

        Console.WriteLine("\nNatijalar:");
        Console.WriteLine("Eng issiq kun: " + issiqKun);
        Console.WriteLine("Eng yuqori harorat: " + engIssiq);

        Console.WriteLine("Eng sovuq kun: " + sovuqKun);
        Console.WriteLine("Eng past harorat: " + engSovuq);
    }
}
