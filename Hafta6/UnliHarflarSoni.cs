using System;

class Program
{
    static void Main()
    {
        Console.Write("Matn kiriting: ");
        string matn = Console.ReadLine();

        int sanoq = 0;
        string unlilar = "aeiouAEIOUаеиоуўэёАЕИОУЎЭЁ";

        foreach (char harf in matn)
        {
            if (char.IsLetter(harf) && unlilar.Contains(harf))
            {
                sanoq++;
            }
        }

        Console.WriteLine("Unli harflar soni: " + sanoq);
    }
}
