namespace Printing
{
    using System;
    using System.Globalization;
    using System.Threading;

    public class Print
    {
        public static void Main()
        {
            const int SheetsCountInBox = 500;
            
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            int studentsCount = Int32.Parse(Console.ReadLine());
            int sheetsPerStudent = Int32.Parse(Console.ReadLine());
            decimal pricePerBox = Convert.ToDecimal(Console.ReadLine());

            int totalSheetsCount = studentsCount * sheetsPerStudent;
            int fullBoxes = totalSheetsCount / SheetsCountInBox;
            decimal priceFullBoxes = fullBoxes * pricePerBox;
            
            int remainingSheetsCount = totalSheetsCount % SheetsCountInBox;

            decimal partOfBox = 0;
            decimal pricePartOfBox = 0;

            if (remainingSheetsCount > 0)
            {
                partOfBox = Convert.ToDecimal(remainingSheetsCount) / SheetsCountInBox;
                pricePartOfBox = partOfBox * pricePerBox;
            }

            decimal priceTotalSheets = priceFullBoxes + pricePartOfBox;
            Console.WriteLine("{0:F2}", priceTotalSheets);
        }
    }
}
