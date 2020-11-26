using System;

namespace Console_this_day
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] str = Console.ReadLine().Split(' ');
            Console.WriteLine(str[0] + " " + str[2] + " " + str[1]);
            Console.ReadLine();
        }
    }
}
