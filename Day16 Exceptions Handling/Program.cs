using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day16_Exceptions_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();

            try
            {
                int convertedString = int.Parse(S);
                Console.WriteLine(convertedString);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Bad String");
            }

        }
    }
}
