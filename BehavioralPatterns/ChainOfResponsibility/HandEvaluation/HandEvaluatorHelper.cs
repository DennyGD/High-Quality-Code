namespace ChainOfResponsibility
{
    using System;
    using System.Linq;

    internal static class HandEvaluatorHelper
    {
        internal static bool IsFlush(Hand hand)
        {
            var firstSuit = hand.Cards.First().Suit;
            bool allAreOfTheSameSuit = hand.Cards.All(card => card.Suit == firstSuit);

            return allAreOfTheSameSuit;
        }

        internal static bool IsStraight(Hand hand)
        {
            var values = hand.Cards.Select(card => (int)card.Value).ToArray();
            Array.Sort(values);

            for (int i = 0; i < values.Length - 1; i++)
            {
                int currentValue = values[i];
                int nextValue = values[i + 1];

                bool areSequental = (currentValue + 1) == nextValue;

                if (!areSequental)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
