namespace FactoryPattern.Products
{
    public class BasicBulb : Bulb
    {
        private const string CompanyName = "Unknown";

        public BasicBulb()
        {
            this.Company = CompanyName;
        }
    }
}
