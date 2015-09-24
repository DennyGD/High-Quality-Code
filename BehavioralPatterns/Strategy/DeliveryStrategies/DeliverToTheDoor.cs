namespace Strategy.DeliveryStrategies
{
    using System;

    public class DeliverToTheDoor : IDeliver
    {
        public void Execute(Item item)
        {
            Console.WriteLine("Delivered item {0} to the door.", item.TrackingNumber);
        }
    }
}
