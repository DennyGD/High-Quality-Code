namespace SumOfDifferences
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class SumOfDifferences
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            long[] sequence = input.Split(' ').Select(x => long.Parse(x)).ToArray();

            BigInteger result = 0;
            int position = 0;
            int step = 1;
            bool canJump = true;

            while (canJump)
            {
                position += step;
                long previousNumber = sequence[position - 1];
                long currentNumber = sequence[position];
                
                long difference = GetAbsoluteDifference(previousNumber, currentNumber);

                bool differenceIsEvenNumber = (difference % 2 == 0);
                
                if (differenceIsEvenNumber)
                {
                    step = 2;
                }
                else
                {
                    step = 1;
                    result += difference;
                }

                canJump = ((position + step) <= sequence.Length - 1);
            }

            Console.WriteLine(result);
        }

        private static long GetAbsoluteDifference(long a, long b)
        {
            long absoluteDifference = 0;

            if (a >= b)
            {
                absoluteDifference = a - b;
            }
            else
            {
                absoluteDifference = b - a;
            }

            return absoluteDifference;
        }
    }
}
