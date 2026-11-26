
using System;

class Program
{
    static void Main()
    {
        string[] kunlar =
        {
            "Dushanba",
            "Seshanba",
            "Chorshanba",
            "Payshanba",
            "Juma",
            "Shanba",
            "Yakshanba"
        };

        string[][] vazifalar = new string[7][];

        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine(kunlar[i] + " uchun vazifalar sonini kiriting:");
            int soni = int.Parse(Console.ReadLine());

            vazifalar[i] = new string[soni];

            for (int j = 0; j < soni; j++)
            {
                Console.WriteLine("Vazifani kiriting:");
                vazifalar[i][j] = Console.ReadLine();
            }
        }

        Console.WriteLine("\nHAFTALIK VAZIFALAR:");

        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine(kunlar[i] + ":");

            for (int j = 0; j < vazifalar[i].Length; j++)
            {
                Console.WriteLine("- " + vazifalar[i][j]);
            }
        }
    }
}
