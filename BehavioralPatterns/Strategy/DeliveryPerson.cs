namespace Strategy
{
    using DeliveryStrategies;

    public class DeliveryPerson
    {
        public DeliveryPerson(string name, IDeliver strategy)
        {
            this.Name = name;
            this.Strategy = strategy;
        }

        public string Name { get; set; }

        public IDeliver Strategy { get; set; }

        public void Deliver(Item item)
        {
            this.Strategy.Execute(item);
        }
    }
}
