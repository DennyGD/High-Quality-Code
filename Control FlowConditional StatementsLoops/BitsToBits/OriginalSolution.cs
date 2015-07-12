//using System;
//using System.Collections.Generic;

//namespace BitsToBits
//{
//    class BitsToBits
//    {
//        static void Main()
//        {
//            int N = Int32.Parse(Console.ReadLine());
//            List<char> finalConcatenation = new List<char>();

//            //outer loop for input
//            for (int i = 0; i < N; i++)
//            {
//                int currentNum = int.Parse(Console.ReadLine());
//                string inputStr = Convert.ToString(currentNum, 2).PadLeft(32, '0');

//                //inner loop to take the rightmost 30 bits
//                for (int pos = 2; pos <= 31; pos++)
//                {
//                    finalConcatenation.Add(inputStr[pos]);
//                }
//            }

//            //foreach (var item in finalConcatenation)
//            //{
//            //    Console.Write(item);
//            //}
//            //Console.WriteLine(finalConcatenation.Count);

//            //count ALL the 0s and 1s
//            int countAll0 = 0;
//            int countAll1 = 0;
//            foreach (char bit in finalConcatenation)
//            {
//                if (bit == '0')
//                {
//                    countAll0++;
//                }
//                else if (bit == '1')
//                {
//                    countAll1++;
//                }
//            }

//            //count 0s
//            int count0 = 0;
//            int maxCount0 = 0;

//            for (int index = 0; index < finalConcatenation.Count; index++)
//            {
//                char currentChar = finalConcatenation[index];
//                if (currentChar == '0')
//                {
//                    count0++;
//                }
//                if ((currentChar == '1') || (index == finalConcatenation.Count - 1))
//                {
//                    if (count0 > maxCount0)
//                    {
//                        maxCount0 = count0;
//                    }
//                    count0 = 0;
//                }
//            }

//            if (countAll0 == finalConcatenation.Count)
//            {
//                Console.WriteLine(countAll0);
//            }
//            else
//            {
//                Console.WriteLine(maxCount0);
//            }

//            //count 1s
//            int count1 = 0;
//            int maxCount1 = 0;


//            for (int index = 0; index < finalConcatenation.Count; index++)
//            {
//                char currentChar = finalConcatenation[index];
//                if (currentChar == '1')
//                {
//                    count1++;
//                }
//                //edit condition
//                if ((currentChar == '0') || (index == finalConcatenation.Count - 1))
//                {
//                    if (count1 > maxCount1)
//                    {
//                        maxCount1 = count1;
//                    }
//                    count1 = 0;
//                }
//            }

//            if (countAll1 == finalConcatenation.Count)
//            {
//                Console.WriteLine(countAll1);
//            }
//            else
//            {
//                Console.WriteLine(maxCount1);
//            }

//        }
//    }
//}

