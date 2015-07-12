//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;

//namespace SumOfDifferences
//{
//    class SumOfDifferences
//    {
//        static void Main()
//        {
//            // get input
//            string input = Console.ReadLine();
//            long[] sequence = input.Split(' ').Select(x => Int64.Parse(x)).ToArray();

//            // start iterating through the sequence
//            BigInteger result = 0;
//            int position = 0;
//            int step = 1;
//            long difference = 0;

//            while (true)
//            {
//                if (((position + step) > sequence.Length - 1))
//                {
//                    break;
//                }

//                position += step;
//                difference = ReturnDifference(sequence[position - 1], sequence[position]);
//                // check even or odd
//                if (difference % 2 == 0)
//                {
//                    step = 2;
//                }
//                else
//                {
//                    step = 1;
//                    result += difference;
//                }
//            }

//            Console.WriteLine(result);
//        }

//        static long ReturnDifference(long numA, long numB)
//        {
//            if (numA >= numB)
//            {
//                return numA - numB;
//            }
//            else
//            {
//                return numB - numA;
//            }
//        }
//    }
//}

