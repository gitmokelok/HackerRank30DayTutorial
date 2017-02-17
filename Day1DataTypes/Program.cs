using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables.
            int i1 = 3;
            double d1 = 2.8;
            string s1 = "is the best place to learn and practice coding!";
            // Read and save an integer, double, and String to your variables.

            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + i1);
            Console.WriteLine($"{d1+d:F1}");
            Console.WriteLine(s + s1);
            // Print the sum of the double variables on a new line.

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
        }
    }
}
