using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day29BitwiseAndCalculator;

namespace BitwiseCalculatorANDTests
{
    [TestClass]
    public class BitwiseCalculatorTests
    {
        [TestMethod]
        public void BitwiseCalculator_Constructor()
        {
            BitwiseCalculator calc = new BitwiseCalculator(3);
            
            Assert.AreEqual(3, calc.NumberOfTests);
            Assert.IsNotNull(calc.NKPairs);
            Assert.IsNull(calc.ArrayOfInts);
            Assert.IsNull(calc.BitwiseResultsList);
        }

        [TestMethod]
        public void BitwiseCalculator_Solver1()
        {
            BitwiseCalculator calc = new BitwiseCalculator(3);

            calc.NKPairs.Add(new Tuple<int, int>(5,2), Enumerable.Range(1,5).ToArray());
            calc.NKPairs.Add(new Tuple<int, int>(8,5), Enumerable.Range(1,8).ToArray());
            calc.NKPairs.Add(new Tuple<int, int>(2,2), Enumerable.Range(1,2).ToArray());
            
            string outputString = String.Empty;

            foreach (var pair in calc.NKPairs)
            {
                var biggest = 0;
                calc.N = pair.Key.Item1;
                calc.K = pair.Key.Item2;
                var array = pair.Value;
                var tempList = Enumerable.Range(2,calc.N-1).ToList();
                foreach (var number1 in array)
                {
                    foreach (var number2 in tempList)
                    {
                        var result = number1 & number2;
                        if (result > biggest && result < calc.K)
                            biggest = result;
                        Console.WriteLine($"{number1} & {number2} = {Convert.ToString(number1,2)} & {Convert.ToString(number2, 2)} = result {Convert.ToString(result,2)}");
                    }
                    if (tempList.Count > 0)
                        tempList.RemoveAt(0);
           
                }

                outputString += biggest + " ";
                Console.WriteLine(biggest);
            }
            //    for (int i = 0; i < calc.N - 1; i++)
                //    {
                //        for (int j = 1; j < calc.N - 1; j++)
                //        { 

                //            if (i == j || array[i] > array[j])
                //                continue;
                //            Console.WriteLine($"{array[i]} & {array[j]}");
                //            var result = array[i] & array[j];

                //            if (result > biggest && result < calc.K)
                //                biggest = result;

                //        }
                //    }
                //    outputString += biggest + " ";
                //    Console.WriteLine(biggest);
                //}

                Assert.AreEqual("1 4 0 ", outputString);

        }

        [TestMethod]
        public void BitwiseCalculator_Solver2()
        {
            var inputFilePath = @"d:\Downloads\input02.txt";
            int z = 0;
            using (StreamReader sr = new StreamReader(inputFilePath))
            {
                int t = Convert.ToInt32(sr.ReadLine());
                z = t;
                //BitwiseCalculator calc = new BitwiseCalculator(t);
                for (int a0 = 0; a0 < t; a0++)
                {
                    string[] tokens_n = sr.ReadLine().Split(' ');
                    int n = Convert.ToInt32(tokens_n[0]);
                    int k = Convert.ToInt32(tokens_n[1]);

                    var biggest = 0;
                    var array = Enumerable.Range(1, n);
                    var tempList = Enumerable.Range(2, n - 1).ToList();
                    foreach (var number1 in array)
                    {
                        foreach (var number2 in tempList)
                        {
                            var result = number1 & number2;
                            if (result > biggest && result < k)
                                biggest = result;
                            //Console.WriteLine($"{number1} & {number2} = {Convert.ToString(number1, 2)} & {Convert.ToString(number2, 2)} = result {Convert.ToString(result, 2)}");
                        }
                        if (tempList.Count > 0)
                            tempList.RemoveAt(0);

                    }
                    //array = null;
                    //tempList.Clear();

                    //outputString += biggest + " ";
                    Console.WriteLine(biggest);
                }
            }
                
            Assert.IsTrue(z > 0);
        }



    }
}
