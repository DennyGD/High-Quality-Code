namespace ChainOfResponsibility
{
    using System;
    using System.Linq;

    internal class StraightFlush : HandEvaluator
    {
        internal StraightFlush()
        {
            this.SetSuccessor(new FourOfAKindAndFullHouse());
        }

        internal override void Evaluate(Hand hand)
        {
            bool isStraightFlush = HandEvaluatorHelper.IsFlush(hand) && HandEvaluatorHelper.IsStraight(hand);

            if (isStraightFlush)
            {
                Console.WriteLine("It is Straight Flush!");
            }
            else
            {
                this.Successor.Evaluate(hand);
            }
        }
    }
}
