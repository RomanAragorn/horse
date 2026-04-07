using System;

namespace Horse
{
    class Program
    {
        static string Race(string horse)
        {
            Console.WriteLine("Enter race? [y/n]: ");
            char answer = Convert.ToChar(Console.ReadLine());

            if (answer == 'y')
            {
                Console.WriteLine(horse + " entered the race!");

                int result = RaceResult();

                if (result > 0)
                {
                    return "Congratulations!  " + horse + " won!";
                }
                else
                {
                    return "Sorry.  " + horse + " lost!";
                }
            }
            else if (answer == 'n')
            {
                return horse + " did not enter the race.";
            }
            else
            {
                return "Not a valid answer!";
            }
        }

        static int RaceResult()
        {
            Random rnd = new Random();
            int result = rnd.Next(2);

            return result;
        }

        static string showHorses()
        {
            Console.WriteLine("Choose a horse!");
            string[] horses = { "Tokai Teio", "Symboli Rudolf", "Kitasan Black", "Oguri Cap", "Gentildonna", "Mejiro Palmer", "Agnes Digital", "Nishino Flower", "Agnes Tachyon" };

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
            string horse = showHorses();
            Console.WriteLine(Race(horse));
        }
    }
}