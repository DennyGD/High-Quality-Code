namespace State.States
{
    using System;

    public class WorkState : State
    {
        public WorkState(Human human)
            : base(human)
        {
            this.MinEnergyLevel = 20;
            this.MaxEnergyLevel = 100;
        }

        public override void Live()
        {
            Console.WriteLine("Working :(");
            this.Human.EnergyLevel -= 10;

            if (this.Human.EnergyLevel <= this.MinEnergyLevel)
            {
                this.Human.State = new FunState(this.Human);
            }
        }
    }
}
