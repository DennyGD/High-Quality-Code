namespace FactoryPattern.Products
{
    public class FancyBulb : Bulb
    {
        private const string CompanyName = "Philips";

        public FancyBulb()
        {
            this.Company = CompanyName;
        }
    }
}
