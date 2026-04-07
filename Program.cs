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

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}