using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21Generics
{
    public class Printer
    {
        public static void PrintArray<T>(IList<T> array)
        {
            foreach (var element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}
