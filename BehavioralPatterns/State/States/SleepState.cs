namespace State.States
{
    using System;

    public class SleepState : State
    {
        public SleepState(Human human)
            : base(human)
        {
            this.MinEnergyLevel = 0;
            this.MaxEnergyLevel = 10;
        }

        public override void Live()
        {
            Console.WriteLine("Sleeping like a log... hrr");
            this.Human.EnergyLevel += 10;

            if (this.Human.EnergyLevel >= this.MaxEnergyLevel)
            {
                this.Human.State = new EatState(this.Human);
            }
        }
    }
}
