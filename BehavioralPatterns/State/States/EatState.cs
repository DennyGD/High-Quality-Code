namespace State.States
{
    using System;

    public class EatState : State
    {
        public EatState(Human human)
            : base(human)
        {
            this.MinEnergyLevel = 10;
            this.MaxEnergyLevel = 20;
        }

        public override void Live()
        {
            Console.WriteLine("Eating...");
            this.Human.EnergyLevel += 10;

            if (this.Human.EnergyLevel >= this.MaxEnergyLevel)
            {
                this.Human.State = new WorkState(this.Human);
            }
        }
    }
}
