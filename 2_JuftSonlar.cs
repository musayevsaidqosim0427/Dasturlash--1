
using System;

class Program
{
    static void Main()
    {
        int[] sonlar = { 12, 5, 8, 17, 24, 9, 6, 11, 20 };

        Console.WriteLine("Massiv elementlari:");

        foreach (int son in sonlar)
        {
            Console.Write(son + " ");
        }

        Console.WriteLine("\nJuft sonlar:");

        foreach (int son in sonlar)
        {
            if (son % 2 == 0)
            {
                Console.WriteLine(son);
            }
        }
    }
}
