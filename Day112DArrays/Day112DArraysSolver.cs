using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day112DArrays
{
    public class Day112DArraysSolver
    {
        public Dictionary<int[],int> ExtractHourGlasses(int[][] arrayOfInts)
        {
            var result = new Dictionary<int[], int>(16);

            for (int i = 0; i < arrayOfInts.Length - 2; i++)
            {
                for (int j = 0; j < arrayOfInts.Length - 2; j++)
                {
                    //var upperRow = new[] {arrayOfInts[i][j], arrayOfInts[i][j + 1], arrayOfInts[i][j + 2]};
                    //var middleNumber = arrayOfInts[i + 1][j + 1];
                    //var lowerRow = new[] {arrayOfInts[i + 2][j], arrayOfInts[i + 2][j + 1], arrayOfInts[i + 2][j + 2]};
                    var tempArray = new[] { arrayOfInts[i][j], arrayOfInts[i][j + 1], arrayOfInts[i][j + 2], arrayOfInts[i + 1][j + 1], arrayOfInts[i + 2][j], arrayOfInts[i + 2][j + 1], arrayOfInts[i + 2][j + 2] };
                    var hourGlassSum = 0;
                    foreach (var number in tempArray)
                    {
                        hourGlassSum += number;
                    }

                    result.Add(tempArray, hourGlassSum);

                }


            }
            return result;
        }
    }
}
