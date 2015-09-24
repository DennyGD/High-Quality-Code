namespace State
{
    using States;

    public class Human
    {
        public Human(string name)
        {
            this.Name = name;

            this.EnergyLevel = 10;
            this.State = new EatState(this);
        }

        public string Name { get; set; }

        public State State { get; set; }

        internal int EnergyLevel { get; set; }

        public void Live()
        {
            this.State.Live();
        }
    }
}
