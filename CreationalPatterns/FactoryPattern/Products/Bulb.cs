namespace FactoryPattern.Products
{
    public abstract class Bulb
    {
        public int Power { get; set; }
        
        public int Lumens { get; set; }
        
        public int Life { get; set; }

        public string Company { get; set; }

        public override string ToString()
        {
            string result = string.Format("Power: {0}W, Lumens: {1}, Company: {2}", this.Power, this.Lumens, this.Company);
            return result;
        }
    }
}
