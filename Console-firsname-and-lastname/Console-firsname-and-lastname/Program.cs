using System;

namespace Console_firsname_and_lastname
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите фамилию");
            string lastname = Console.ReadLine();
            Console.WriteLine("Введите имя");
            string firstname = Console.ReadLine();
            Console.WriteLine("Приятно познакомится " + lastname + " " + firstname);
            Console.ReadLine();

        }
    }
}
