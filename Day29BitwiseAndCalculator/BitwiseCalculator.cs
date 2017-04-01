using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day29BitwiseAndCalculator
{
    public class BitwiseCalculator
    {
        public int NumberOfTests;
        public int N;
        public int K;
        public int[] ArrayOfInts;
        public Dictionary<Tuple<int, int>,int[]> NKPairs;
        public List<int> BitwiseResultsList;

        public BitwiseCalculator(int numberOfTests)
        {
            NumberOfTests = numberOfTests;
            NKPairs = new Dictionary<Tuple<int, int>,int[]>(numberOfTests);
        }
    }
}
