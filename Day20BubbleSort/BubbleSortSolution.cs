using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20BubbleSort
{
    public class BubbleSortSolution
    {
        public void bubbleSort(int[] a, int n)
        {
            var swapCounter = 0;
            var tempArray = new int[n];
            for (int i = 0; i < n-1; i++)
            {
                // Track number of elements swapped during a single array traversal
                int numberOfSwaps = 0;

                for (int j = 0; j < n-1; j++)
                {
                    // Swap adjacent elements if they are in decreasing order
                    if (a[j] > a[j + 1])
                    {
                        a = swap(a, j);
                        numberOfSwaps++;
                        swapCounter++;
                    }

                }

                //swapCounter = numberOfSwaps;

                // If no elements were swapped during a traversal, array is sorted
                if (numberOfSwaps == 0)
                {
                    break;
                }
            }
            Console.WriteLine($"Array is sorted in {swapCounter} swaps.");
            Console.WriteLine($"First Element: {a[0]}");
            Console.WriteLine($"Last Element: {a[n-1]}");
        }

        public int[] swap(int[] a, int index)
        {
            var tempValue = a[index + 1];
            a[index + 1] = a[index];
            a[index] = tempValue;
            return a;
        }


    }
}
