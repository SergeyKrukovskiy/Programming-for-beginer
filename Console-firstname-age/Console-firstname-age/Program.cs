using System;

namespace Console_firstname_age
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите Возраст");
            string age = Console.ReadLine();
            Console.WriteLine("Приятно познакомится " + name + " " + age + " лет.");
            Console.ReadLine();
        }
    }
}
