
using System;

class Program
{
    static void Main()
    {
        // 1-topshiriq: Shaxsiy ma'lumotlar
        string ism = "Saidqosim";
        string familiya = "Musayev";
        int yosh = 20;
        string fakultet = "Axborot xavfsizligi";

        Console.WriteLine("Ism: " + ism);
        Console.WriteLine("Familiya: " + familiya);
        Console.WriteLine("Yosh: " + yosh);
        Console.WriteLine("Fakultet: " + fakultet);

        // 2-topshiriq: Guruh raqamini const orqali e'lon qilish
        const string GURUH = "Guruh raqamingiz";

        Console.WriteLine("Guruh: " + GURUH);

        /*
         3-topshiriq:
         Ko'p qatorli izoh.
         Bu izoh dastur haqida ma'lumot beradi.
        */

        // 4-topshiriq: Noto'g'ri identifikatorlar

        // 1. 1ism - raqam bilan boshlanmaydi
        // 2. my name - bo'sh joy ishlatish mumkin emas
        // 3. class - C# ning kalit so'zi
        // 4. ism-familiya - defis ishlatish mumkin emas
        // 5. int - C# ning ma'lumot turi nomi

        Console.WriteLine("Noto'g'ri identifikatorlar misollari kod izohlarida berilgan.");
    }
}
