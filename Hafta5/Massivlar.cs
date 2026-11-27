using System;

class Program
{
    static void Main()
    {
        // 1-topshiriq: 10 ta int elementli massiv yaratish va foreach bilan chiqarish
        Console.WriteLine("--- 1-topshiriq ---");
        int[] massiv = { 4, 12, 7, 25, 9, 18, 3, 41, 15, 6 };

        Console.Write("Massiv elementlari: ");
        foreach (int element in massiv)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine("\n");

        // 2-topshiriq: Yuqoridagi massiv elementlari yig'indisini for sikli bilan hisoblash
        Console.WriteLine("--- 2-topshiriq ---");
        int yigindi = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            yigindi += massiv[i];
        }
        Console.WriteLine("Elementlar yig'indisi: " + yigindi + "\n");

        // 3-topshiriq: Random yordamida 5 ta elementli massivni 1-6 oralig'ida to'ldirish
        Console.WriteLine("--- 3-topshiriq ---");
        int[] zarMassiv = new int[5];
        Random rnd = new Random();

        for (int i = 0; i < zarMassiv.Length; i++)
        {
            zarMassiv[i] = rnd.Next(1, 7);
        }

        Console.Write("Zar sonlari: ");
        foreach (int son in zarMassiv)
        {
            Console.Write(son + " ");
        }
        Console.WriteLine("\n");

        // 4-topshiriq (qo'shimcha): 3x3 ikki o'lchamli massivni ichma-ich for sikli bilan to'ldirish
        Console.WriteLine("--- 4-topshiriq ---");
        int[,] jadval = new int[3, 3];
        int qiymat = 1;

        for (int i = 0; i < jadval.GetLength(0); i++)
        {
            for (int j = 0; j < jadval.GetLength(1); j++)
            {
                jadval[i, j] = qiymat++;
            }
        }

        Console.WriteLine("3x3 massiv natijasi:");
        for (int i = 0; i < jadval.GetLength(0); i++)
        {
            for (int j = 0; j < jadval.GetLength(1); j++)
            {
                Console.Write(jadval[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
