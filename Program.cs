using System;

namespace Horse
{
    class Program
    {
        static string showHorses()
        {
            Console.WriteLine("Choose a horse!");
            string[] horses = { "Tokai Teio", "Symboli Rudolf", "Kitasan Black", "Oguri Cap", "Gentildonna", "Mejiro Palmer", "Agnes Digital", "Nishino Flower" };

            for (int i = 0; i < horses.Length; i++)
            {
                Console.WriteLine(i + ". " + horses[i]);
            }

            Console.WriteLine("Which horse are you going with? [0-" + (horses.Length - 1) + "]: ");
            int choice = Convert.ToInt16(Console.ReadLine());

            if (choice >= horses.Length || choice < 0)
            {
                Console.WriteLine("Invalid choice!");
                Environment.Exit(1);
            }

            return horses[choice];

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}