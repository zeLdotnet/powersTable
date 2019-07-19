using System;

namespace Lab6_powersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run)
            {
                int check = ValidateIntegers("Enter a whole number to see it's power table! ");
                NumberHeadings();
                PowerTable(check);
                
                Console.WriteLine("pick another number? [y/n]");
                
                PickAgain:
                string userPick = Console.ReadLine().ToLower();
                if (userPick == "y" || userPick == "yes")
                {
                    continue;
                }
                else if (userPick == "n" || userPick == "no")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("invalid input... please choose [y/n]");
                    goto PickAgain;
                }
            }
        }

        public static void PowerTable(int userNumberChoice)
        {
            for (int i = 1; i <= userNumberChoice; i++)
            {
                Console.WriteLine($"{i}\t\t{Square(i)}\t\t{Cube(i)}\t\t");
            }
        }

        public static int Square(int numberToSquare)
        {
            return numberToSquare * numberToSquare;
        }

        public static int Cube(int numberToCube)
        {
           return numberToCube * numberToCube * numberToCube;
        }

        public static void NumberHeadings()
        {
            Console.WriteLine($"number\t\tsquare\t\tcube");
            Console.WriteLine($"=====================================");
        }

        public static int ValidateIntegers(string message)
        {
            int number;
            Console.WriteLine(message);
            if (int.TryParse(Console.ReadLine(), out number))
            {
                return number;
            }
            else
            {
                return ValidateIntegers("Please input a correct number! ");
            }
        }
    }
}
