
using System;

class Program
{
    static void Main()
    {
        int[,] massiv = new int[3, 3];

        Console.WriteLine("3x3 massiv elementlarini kiriting:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"massiv[{i},{j}] = ");
                massiv[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Massiv elementlari:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(massiv[i, j] + "\t");
            }

            Console.WriteLine();
        }
    }
}
