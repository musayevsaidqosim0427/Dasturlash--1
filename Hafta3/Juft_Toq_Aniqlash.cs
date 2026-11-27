
using System;

class Program
{
    static void Main()
    {
        int son = 9;

        string natija = (son % 2 == 0) ? "Juft son" : "Toq son";

        Console.WriteLine("Kiritilgan son: " + son);
        Console.WriteLine("Natija: " + natija);
    }
}
