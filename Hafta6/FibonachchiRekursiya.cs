using System;

class Program
{
    static int Fibonacci(int n)
    {
        if (n == 0)
            return 0;

        if (n == 1)
            return 1;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main()
    {
        Console.Write("Son kiriting: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Musbat son kiriting!");
        }
        else
        {
            Console.WriteLine("Fibonachchi soni: " + Fibonacci(n));
        }
    }
}
