namespace FactoryPattern.Factories
{
    using FactoryPattern.Products;

    public abstract class BulbFactory
    {
        public abstract Bulb CreateBulb();
    }
}
