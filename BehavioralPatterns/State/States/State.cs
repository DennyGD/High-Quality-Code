namespace State.States
{
    public abstract class State
    {
        protected State(Human human)
        {
            this.Human = human;
        }

        public Human Human { get; set; }

        protected int MinEnergyLevel { get; set; }

        protected int MaxEnergyLevel { get; set; }

        public abstract void Live();
    }
}
