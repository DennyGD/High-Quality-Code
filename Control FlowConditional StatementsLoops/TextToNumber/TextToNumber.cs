namespace TextToNumber
{
    using System;

    public class TextToNumber
    {
        public static void Main()
        {
            const char StopChar = '@';
            const int AsciiCodeZero = 48;
            const int AsciiCodeUppercaseA = 65;
            const int AsciiCodeUppercaseZ = 90;
            const int AsciiCodeLowercaseA = 97;
            const int AsciiCodeLowercaseZ = 122;

            long initialNumber = Int64.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            
            long result = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];

                if (currentChar == StopChar)
                {
                    break;
                }
                else if (Char.IsDigit(currentChar))
                {
                    int multiplier = currentChar - AsciiCodeZero;
                    result *= multiplier;
                }
                else if ((currentChar >= AsciiCodeUppercaseA) && (currentChar <= AsciiCodeUppercaseZ))
                {
                    int numberToAdd = currentChar - AsciiCodeUppercaseA;
                    result += numberToAdd;
                }
                else if ((currentChar >= AsciiCodeLowercaseA) && (currentChar <= AsciiCodeLowercaseZ))
                {
                    int numberToAdd = currentChar - AsciiCodeLowercaseA;
                    result += numberToAdd;
                }
                else
                {
                    result %= initialNumber;
                }
            }

            Console.WriteLine(result);
        }
    }
}
