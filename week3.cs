
using System;

class Program
{
    static void Main()
    {
        // 1-topshiriq: Arifmetik amallar
        int a = 15;
        int b = 4;

        Console.WriteLine("1-TOPSHIRIQ");
        Console.WriteLine("Yig'indisi: " + (a + b));
        Console.WriteLine("Ayirmasi: " + (a - b));
        Console.WriteLine("Ko'paytmasi: " + (a * b));
        Console.WriteLine("Bo'linmasi: " + ((double)a / b));
        Console.WriteLine("Qoldiq: " + (a % b));

        // 2-topshiriq: Ma'lumot turini o'zgartirish
        Console.WriteLine("\n2-TOPSHIRIQ");

        int son = 7;
        double natija = (double)son;

        Console.WriteLine("Butun son: " + son);
        Console.WriteLine("Double son: " + natija);

        /*
         int butun sonlarni saqlaydi.
         double esa kasr sonlarni ham saqlaydi.
         */

        // 3-topshiriq: Ternary amal yordamida juft yoki toqligini aniqlash
        Console.WriteLine("\n3-TOPSHIRIQ");

        int raqam = 9;
        string javob = (raqam % 2 == 0) ? "Juft son" : "Toq son";

        Console.WriteLine(raqam + " - " + javob);

        // 4-topshiriq: Amallar ketma-ketligi
        Console.WriteLine("\n4-TOPSHIRIQ");

        int ifoda = 2 + 3 * 4 - 1;

        // Qo'lda hisoblash: 2 + 12 - 1 = 13
        Console.WriteLine("Ifoda: 2 + 3 * 4 - 1");
        Console.WriteLine("Qo'lda hisoblangan natija: 13");
        Console.WriteLine("Dastur natijasi: " + ifoda);

        Console.WriteLine("\nBarcha topshiriqlar bajarildi!");
    }
}
