using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19Interfaces
{
    public class Calculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            int result = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    result += i;
            }

            return result;
        }
    }
}
