namespace Strategy
{
    public class Item
    {
        public Item(int trackingNumber, double weight, double width, double height, double depth)
        {
            this.TrackingNumber = trackingNumber;
            this.Weight = weight;
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public int TrackingNumber { get; set; }

        public double Weight { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

        public double Depth { get; set; }
    }
}
