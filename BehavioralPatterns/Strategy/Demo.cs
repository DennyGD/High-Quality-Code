namespace Strategy
{
    using DeliveryStrategies;

    public class Demo
    {
        public static void Main()
        {
            var someDeliveryPerson = new DeliveryPerson("Jane", new DeliverToTheDoor());
            var itemToBeDelivered = new Item(1, 2.5, 100, 230, 340);
            someDeliveryPerson.Deliver(itemToBeDelivered);

            var anotherDeliveryPerson = new DeliveryPerson("John", new DeliverToANearbyOffice());
            var someHeavyItem = new Item(2, 25, 100, 230, 340);
            anotherDeliveryPerson.Deliver(someHeavyItem);
        }
    }
}
