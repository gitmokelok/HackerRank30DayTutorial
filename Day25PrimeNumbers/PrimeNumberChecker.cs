using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day25PrimeNumbers
{
    public static class PrimeNumberChecker
    {
        public static int[] numbersToCheck;

        public static bool IsPrime(int number)
        {
            if (number == 2 || number == 3)
                return true;
            if (number == 1 || number <= 0)
                return false;

            if (number % 2 == 0)
                return false;

            int divisor = (int) Math.Sqrt(number)+1;
            for (int i = 3; i < divisor; i = i + 2)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }

    public class Solution
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int T = int.Parse(Console.ReadLine());
            int[] arrayOfInts = new int[T];
            int counter = 0;
            while (counter != T)
            {
                arrayOfInts[counter] = int.Parse(Console.ReadLine());
                counter++;
            }
            foreach (int item in arrayOfInts)
                Console.WriteLine(item);

        }
    }
}
