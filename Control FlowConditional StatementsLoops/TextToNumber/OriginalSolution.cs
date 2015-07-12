//using System;

//namespace TextToNumber
//{
//    class TextToNumber
//    {
//        static void Main()
//        {
//            long M = Int64.Parse(Console.ReadLine());
//            string input = Console.ReadLine();
//            long result = 0;

//            for (int i = 0; i < input.Length; i++)
//            {
//                char currentChar = input[i];
//                if (currentChar == '@')
//                {

//                    break;
//                }
//                else if ((currentChar >= 48) && (currentChar <= 57))
//                {
//                    int multiplier = currentChar - 48;
//                    result *= multiplier;
//                }
//                else if ((currentChar >= 65) && (currentChar <= 90))
//                {
//                    int numToAdd = currentChar - 65;
//                    result += numToAdd;
//                }
//                else if ((currentChar >= 97) && (currentChar <= 122))
//                {
//                    int numToAdd = currentChar - 97;
//                    result += numToAdd;
//                }
//                else
//                {
//                    result %= M;
//                }
//            }

//            Console.WriteLine(result);
//        }
//    }
//}

