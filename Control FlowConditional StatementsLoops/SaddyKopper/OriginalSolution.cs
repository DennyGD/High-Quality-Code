//using System;
//using System.Collections.Generic;
//using System.Numerics;

//namespace SaddyKopper
//{
//    class SaddyKopper
//    {
//        static void Main()
//        {
//            string input = Console.ReadLine();
//            List<char> numList = new List<char>();

//            for (int i = 0; i < input.Length; i++)
//            {
//                numList.Add(input[i]);
//            }
//            numList.RemoveAt(numList.Count - 1);

//            int transformations = 0;
//            long sumOfEvenPos = 0;
//            BigInteger productOfAll = 1;
//            bool oneDigit = false;
//            string newNumber = "";

//            //outer loop for transformations
//            //for (int i = 0; i < 10; i++)
//            while ((oneDigit == false) && (transformations < 10))
//            {
//                //loop for current number
//                while (numList.Count > 0)
//                {
//                    //inner loop for positions of current List
//                    for (int pos = 0; pos < numList.Count; pos++)
//                    {
//                        if ((pos == 0) || (pos % 2 == 0))
//                        {
//                            int currentDigit = numList[pos] - 48;
//                            sumOfEvenPos += currentDigit;
//                        }
//                    }
//                    productOfAll *= sumOfEvenPos;
//                    sumOfEvenPos = 0;
//                    numList.RemoveAt(numList.Count - 1);
//                }

//                newNumber = productOfAll.ToString();
//                productOfAll = 1;
//                //create a list with product(new number)
//                for (int ch = 0; ch < newNumber.Length; ch++)
//                {
//                    numList.Add(newNumber[ch]);
//                }

//                transformations++;
//                //check if new number is 1 digit
//                if (numList.Count == 1)
//                {
//                    oneDigit = true;

//                }
//                else
//                {
//                    numList.RemoveAt(numList.Count - 1);
//                }
//            }

//            //result

//            if (oneDigit == true)
//            {
//                Console.WriteLine(transformations);
//                Console.WriteLine(newNumber);
//            }
//            else
//            {
//                Console.WriteLine(newNumber);
//            }
//        }
//    }
//}

