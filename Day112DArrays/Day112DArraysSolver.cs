using System;
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

            for (int i = 0; i < arrayOfInts.Length-3; i++)
            {
                var hourGlassUpperRow = int[3];
                for (int j = 0; j < arrayOfInts.Length - 3; j++)
                {
                    
                }
            }

            return result;
        }
    }
}
