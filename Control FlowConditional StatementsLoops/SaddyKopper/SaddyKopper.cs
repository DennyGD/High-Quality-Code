namespace SaddyKopper
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class SaddyKopper
    {
        public static void Main()
        {
            const int MaxTransformations = 10;

            string inputNumberAsString = Console.ReadLine();

            List<char> digits = new List<char>();
            StringToListOfChars(inputNumberAsString, digits);
            digits.RemoveAt(digits.Count - 1);
            
            string newNumber = "";
            int transformations = 0;
            bool oneDigit = false;

            while ((oneDigit == false) && (transformations < MaxTransformations))
            {
                BigInteger productOfAllSums = 1;

                //loop for current number
                while (digits.Count > 0)
                {
                    long sumOfEvenPositions = GetSumOfEvenPositions(digits);
                    productOfAllSums *= sumOfEvenPositions;
                    
                    sumOfEvenPositions = 0;
                    digits.RemoveAt(digits.Count - 1);
                }

                newNumber = productOfAllSums.ToString();

                if (newNumber.Length == 1)
                {
                    oneDigit = true;
                }
                else
                {
                    StringToListOfChars(newNumber, digits);
                    digits.RemoveAt(digits.Count - 1);
                }
                
                transformations++;
            }


            //result
            if (oneDigit)
            {
                Console.WriteLine(transformations);
            }
            
            Console.WriteLine(newNumber);
        }

        private static long GetSumOfEvenPositions(List<char> digits)
        {
            const int ZeroAsciiCode = 48;

            long sumOfEvenPositions = 0;

            for (int position = 0; position < digits.Count; position++)
            {
                bool positionIsEven = (position == 0) || (position % 2 == 0);

                if (positionIsEven)
                {
                    int currentDigit = digits[position] - ZeroAsciiCode;
                    sumOfEvenPositions += currentDigit;
                }
            }

            return sumOfEvenPositions;
        }

        private static void StringToListOfChars(string str, IList<char> collection)
        {
            for (int i = 0; i < str.Length; i++)
            {
                collection.Add(str[i]);
            }
        }
    }
}
