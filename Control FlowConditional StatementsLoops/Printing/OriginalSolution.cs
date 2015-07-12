//using System;
//using System.Threading;
//using System.Globalization;

//namespace PrintingDescription
//{
//    class PrintingDescription
//    {
//        static void Main()
//        {
//            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

//            int numberStudents = Int32.Parse(Console.ReadLine());
//            int sheetsForEach = Int32.Parse(Console.ReadLine());
//            decimal priceBox = Convert.ToDecimal(Console.ReadLine());

//            int totalSheets = numberStudents * sheetsForEach;
//            int remainder = totalSheets % 500;
//            int wholeBoxes = totalSheets / 500;
//            decimal priceWholeBoxes = wholeBoxes * priceBox;
//            decimal priceRemainder = 0;

//            decimal remainderPart = 0;
//            if (remainder >= 0)
//            {
//                remainderPart = Convert.ToDecimal(remainder) / 500;
//                priceRemainder = remainderPart * priceBox;
//            }

//            Console.WriteLine("{0:F2}", priceWholeBoxes + priceRemainder);
//        }
//    }
//}
