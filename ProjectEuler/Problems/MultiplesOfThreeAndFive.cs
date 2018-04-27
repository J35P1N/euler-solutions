namespace ProjectEuler.Problems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MultiplesOfThreeAndFive
    {
        public MultiplesOfThreeAndFive()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Question 1:");
            Console.WriteLine("If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.");
            Console.WriteLine("Find the sum of all the multiples of 3 or 5 below 1000.");


            var numberArray = new int[] {3, 5};
            var multiplesList = new List<int>();
            for (int i = 1; i < 1000; i++)
            {
                foreach (var n in numberArray)
                {
                    // Modulus allows us to see if a number is divisible by another number therefore indicating
                    // if it is a multiple
                    if (i % n == 0)
                    {
                        multiplesList.Add(i);
                    }
                }
            }

            var result = multiplesList.Distinct().Sum();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(result);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
