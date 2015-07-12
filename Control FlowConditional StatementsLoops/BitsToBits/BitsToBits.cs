namespace BitsToBits
{
    using System;
    using System.Collections.Generic;

    public class BitsToBits
    {
        public static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());

             List<char> allBits = GetTheRightmostThirtyBitsOfNumbers(numbersCount);

            int allZerosCount = 0;
            int allOnesCount = 0;
            
            foreach (char bit in allBits)
            {
                if (bit == '0')
                {
                    allZerosCount++;
                }
                else if (bit == '1')
                {
                    allOnesCount++;
                }
            }

            if (allZerosCount == allBits.Count)
            {
                Console.WriteLine(allZerosCount);
            }
            else
            {
                int zerosSequenceLength = GetLengthOfLongestSequenceOfChar(allBits, '0');
                Console.WriteLine(zerosSequenceLength);
            }

            if (allOnesCount == allBits.Count)
            {
                Console.WriteLine(allOnesCount);
            }
            else
            {
                int onesSequenceLength = GetLengthOfLongestSequenceOfChar(allBits, '1');
                Console.WriteLine(onesSequenceLength);
            }
        }

        private static int GetLengthOfLongestSequenceOfChar(IList<char> characters, char wantedCharacter)
        {
            int maxCount = 0;
            int currentCount = 0;

            for (int index = 0; index < characters.Count; index++)
            {
                char currentChar = characters[index];
                if (currentChar == wantedCharacter)
                {
                    currentCount++;
                }

                bool isLastIteration = (index == characters.Count - 1);
                if ((currentChar != wantedCharacter) || isLastIteration)
                {
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }

                    currentCount = 0;
                }
            }

            return maxCount;
        }

        private static List<char> GetTheRightmostThirtyBitsOfNumbers(int numbersCount)
        {
            List<char> theRightmostThirtyBits = new List<char>();

            for (int i = 0; i < numbersCount; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                string inputStr = Convert.ToString(currentNum, 2).PadLeft(32, '0');

                // inner loop to take the rightmost 30 bits
                for (int pos = 2; pos <= 31; pos++)
                {
                    theRightmostThirtyBits.Add(inputStr[pos]);
                }
            }

            return theRightmostThirtyBits;
        }
    }
}
