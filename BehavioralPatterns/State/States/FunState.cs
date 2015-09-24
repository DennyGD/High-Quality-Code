namespace State.States
{
    using System;

    public class FunState : State
    {
        public FunState(Human human)
            : base(human)
        {
            this.MinEnergyLevel = 0;
            this.MaxEnergyLevel = 100;
        }

        public override void Live()
        {
            Console.WriteLine("Just enjoying the world :)");
            this.Human.EnergyLevel -= 10;

            if (this.Human.EnergyLevel <= this.MinEnergyLevel)
            {
                this.Human.State = new SleepState(this.Human);
            }
        }
    }
}
