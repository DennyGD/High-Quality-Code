namespace FactoryPattern.Factories
{
    using FactoryPattern.Products;

    public class UnknownFactory : BulbFactory
    {
        public override Bulb CreateBulb()
        {
            var bulb = new BasicBulb { Life = 5000, Lumens = 800, Power = 15 };
            return bulb;
        }
    }
}
