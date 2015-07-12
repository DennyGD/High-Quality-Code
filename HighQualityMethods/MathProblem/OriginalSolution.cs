//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace MathProblem
//{
//    class MathProblem
//    {
//        static void Main()
//        {
//            // get input
//            string number19 = Console.ReadLine();
//            string[] numbersIn19 = number19.Split(' ');

//            // convert each number in 19 to decimal and sum
//            long sumOfAll = 0;
//            string currNum = "";
//            long currSum = 0;

//            for (int i = 0; i < numbersIn19.Length; i++)
//            {
//                currNum = numbersIn19[i];
//                int power = 0;
//                for (int j = currNum.Length - 1; j >= 0; j--)
//                {
//                    int currDigit = currNum[j] - 97;
//                    currSum += currDigit * Raise19ToPower(power);
//                    power++;
//                }

//                sumOfAll += currSum;
//                currSum = 0;
//            }

//            //Console.WriteLine(sumOfAll);

//            // convert sum of all to 19-base

//            StringBuilder prepareForLetters = new StringBuilder();
//            int remainder = 0;
//            long decimalNum = sumOfAll;
//            while (decimalNum > 0)
//            {
//                remainder = (int)decimalNum % 19;
//                char letter = (char)(remainder + 97);
//                prepareForLetters.Append(letter);
//                decimalNum /= 19;
//            }

//            // print output
//            StringBuilder reversed = new StringBuilder(prepareForLetters.ToString().Length);
//            for (int i = prepareForLetters.Length - 1; i >= 0; i--)
//            {
//                reversed.Append(prepareForLetters[i]);
//            }

//            Console.WriteLine("{0} = {1}", reversed.ToString(), sumOfAll);
//        }

//        static long Raise19ToPower(int power)
//        {
//            long result = 1;
//            for (int i = 0; i < power; i++)
//            {
//                result *= 19;
//            }

//            return result;
//        }
//    }
//}

