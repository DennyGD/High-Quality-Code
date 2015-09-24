namespace ChainOfResponsibility
{
    using System;

    internal class Flush : HandEvaluator
    {
        internal Flush()
        {
            this.SetSuccessor(new Straight());
        }

        internal override void Evaluate(Hand hand)
        {
            bool isFlush = HandEvaluatorHelper.IsFlush(hand);

            if (isFlush)
            {
                Console.WriteLine("It is Flush!");
            }
            else
            {
                this.Successor.Evaluate(hand);
            }
        }
    }
}
