using System;

namespace ConsoleApp1_14._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte pozdrav :");
            string pozdrav = Console.ReadLine();
            Console.WriteLine("Zadejte jmeno :");
            string jmeno = Console.ReadLine();
            Console.WriteLine(pozdrav + " " + jmeno);
            Console.ReadKey();
        }
    }
}
