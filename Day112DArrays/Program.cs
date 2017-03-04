using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day112DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[6][];
            arr[0] = new int[] { 1,1,1,0,0,0};
            arr[1] = new int[] {0, 2, 0, 0, 0, 0};
            arr[2] = new int[] {3, 3, 3, 0, 0, 0};
            arr[3] = new int[] {0, 0,0,0,0,0};
            arr[4] = new int[] { 0, 0, 0, 0, 0, 0 };
            arr[5] = new int[] { 0, 0, 0, 0, 0, 0 };

            //for (int arr_i = 0; arr_i < 6; arr_i++)
            //{
            //    string[] arr_temp = Console.ReadLine().Split(' ');
            //    arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            //}

            var solver = new Day112DArraysSolver();
            var hourGlassCollection = solver.ExtractHourGlasses(arr);
            var largestSum = -9;
            foreach (var glass in hourGlassCollection)
            {
                if (glass.Value > largestSum)
                    largestSum = glass.Value;
            }
            Console.WriteLine(largestSum);

        }
    }
}
