﻿using System.Collections.Generic;

namespace Day29BitwiseAND
{
    public class BitwiseCalculator
    {
        public int NumberOfTests;
        public int N;
        public int K;
        public int[] ArrayOfInts;
        public Dictionary<int, int[]> NKPairs;
        public List<int> BitwiseResultsList;

        public BitwiseCalculator(int numberOfTests)
        {
            NumberOfTests = numberOfTests;
            NKPairs = new Dictionary<int, int[]>(numberOfTests);
        }





    }
}
