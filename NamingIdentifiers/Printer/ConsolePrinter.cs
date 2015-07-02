namespace Class123
{
    using System;

    public class ConsolePrinter
    {
        private const int MaxCount = 6;

        public void PrintBoolToConsole(bool valueToBePrinted)
        {
            string valueAsString = valueToBePrinted.ToString();
            Console.WriteLine(valueAsString);
        }
    }
}
