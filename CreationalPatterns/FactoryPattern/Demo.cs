namespace FactoryPattern
{
    using System;

    using FactoryPattern.Factories;

    public class Demo
    {
        public static void Main()
        {
            BulbFactory firstFactory = new UnknownFactory();
            var someChineseBulb = firstFactory.CreateBulb();
            Console.WriteLine(someChineseBulb);

            BulbFactory secondFactory = new PhilipsFactory();
            var someFancyBulb = secondFactory.CreateBulb();
            Console.WriteLine(someFancyBulb);
        }
    }
}
