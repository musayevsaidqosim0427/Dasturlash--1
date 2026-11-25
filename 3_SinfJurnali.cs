
using System;

class Program
{
    static void Main()
    {
        int[] ballar = { 85, 65, 90, 45, 70, 55, 95, 60 };

        double yigindi = 0;

        for (int i = 0; i < ballar.Length; i++)
        {
            yigindi += ballar[i];
        }

        double ortacha = yigindi / ballar.Length;

        int soni = 0;

        for (int i = 0; i < ballar.Length; i++)
        {
            if (ballar[i] < ortacha)
            {
                soni++;
            }
        }

        Console.WriteLine("O'quvchilar ballari:");

        for (int i = 0; i < ballar.Length; i++)
        {
            Console.Write(ballar[i] + " ");
        }

        Console.WriteLine("\nO'rtacha ball: " + ortacha);
        Console.WriteLine("O'rtachadan past ball olganlar soni: " + soni);
    }
}
