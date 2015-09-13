namespace FactoryPattern.Factories
{
    using FactoryPattern.Products;

    public class PhilipsFactory : BulbFactory
    {
        public override Bulb CreateBulb()
        {
            var bulb = new FancyBulb { Life = 10000, Lumens = 1000, Power = 5 };
            return bulb;
        }
    }
}
