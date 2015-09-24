namespace Strategy.DeliveryStrategies
{
    using System;

    public class DeliverToANearbyOffice : IDeliver
    {
        public void Execute(Item item)
        {
            Console.WriteLine("Delivered item {0} to a nearby office.", item.TrackingNumber);
        }
    }
}
