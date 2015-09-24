namespace ChainOfResponsibility
{
    using System;

    internal class Straight : HandEvaluator
    {
        internal Straight()
        {
            // TODO set successor
        }

        internal override void Evaluate(Hand hand)
        {
            bool isStraight = HandEvaluatorHelper.IsStraight(hand);

            if (isStraight)
            {
                Console.WriteLine("It is Straight!");
            }
            else
            {
                // since there is no successor yet
                Console.WriteLine("It is lower than Straight!");
            }
        }
    }
}
