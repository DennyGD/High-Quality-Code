namespace ChainOfResponsibility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class RoyalFlush : HandEvaluator
    {
        private readonly HashSet<CardValue> NeededCardValues = new HashSet<CardValue>
        {
            CardValue.Ten,
            CardValue.Jack,
            CardValue.Queen,
            CardValue.King,
            CardValue.Ace
        };

        internal RoyalFlush()
        {
            this.SetSuccessor(new StraightFlush());
        }

        internal override void Evaluate(Hand hand)
        {
            bool isRoyalFlush = this.IsRoyalFlush(hand);

            if (isRoyalFlush)
            {
                Console.WriteLine("It is Royal Flush!");
            }
            else
            {
                this.Successor.Evaluate(hand);
            }
        }

        private bool IsRoyalFlush(Hand hand)
        {
            bool isFlush = HandEvaluatorHelper.IsFlush(hand);

            if (!isFlush)
            {
                return false;
            }

            var cardsValues = new HashSet<CardValue>(hand.Cards.Select(card => card.Value));
            return cardsValues.SetEquals(this.NeededCardValues);
        }
    }
}
