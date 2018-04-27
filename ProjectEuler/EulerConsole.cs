using ProjectEuler.Problems;

namespace ProjectEuler
{
    using System;

    class EulerConsole
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                ;
                Console.WriteLine("Welcome to the Euler test suite.");
                Console.WriteLine("Enter a problem number to generate the correct answer or press Esc to exit:");

                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
                string decision = Console.ReadLine();
                if (int.TryParse(decision, out int iDecision))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (iDecision)
                    {
                        case 1:
                            new MultiplesOfThreeAndFive();
                            break;
                        default:
                            Console.WriteLine("Invalid entry. Please try another.");
                        break;
                    }
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Press any key to continue..");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
