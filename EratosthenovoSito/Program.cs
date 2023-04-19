using System;
using System.Collections.Generic;
using System.Linq;

namespace EratosthenovoSito
{
    public class Program
    {
        private static List<int> numbersToCheck = new List<int>();
        private static List<int> checkedNumbers = new List<int>();
        static int maxInterval = 500;
        public static void Main(string[] args)
        {
            Console.WriteLine("Select last number of interval:");

            string input = Console.ReadLine();

            int.TryParse(input, out maxInterval);

            checkNumbers();
            Console.WriteLine(checkedNumbers.Count);
        }

        public static void checkNumbers()
        {
            for (int i = 2; i <= maxInterval; i++)
            {
                numbersToCheck.Add(i);
            }

            int current = 2;

            do
            {
                removeNumbers(current);
                current++;
            }
            while (current < maxInterval);

            foreach (int number in numbersToCheck)
            {
                //Console.WriteLine(number);
                checkedNumbers.Add(number);
            }
        }

        public static void removeNumbers(int current)
        {
            for (int number = current; number <= maxInterval; number++)
            {
                if (number % current == 0)
                {
                    if (number == current) continue;
                    numbersToCheck.Remove(number);
                }
            }
        }
    }
}