namespace ChainOfResponsibility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class FourOfAKindAndFullHouse : HandEvaluator
    {
        private const int NeededUniqueCardsCount = 2;

        internal FourOfAKindAndFullHouse()
        {
            this.SetSuccessor(new Flush());
        }

        internal override void Evaluate(Hand hand)
        {
            var uniqueCardValues = hand.Cards.Select(card => card.Value).Distinct().ToArray();
            bool isFourOfAKindOrAFullHouse = uniqueCardValues.Length == NeededUniqueCardsCount;

            if (!isFourOfAKindOrAFullHouse)
            {
                this.Successor.Evaluate(hand);
                return;
            }

            var uniqueCardValueToCheck = uniqueCardValues[0];
            int cardValueFrequency = 0;
            foreach (var card in hand.Cards)
            {
                var currentCardValue = card.Value;
                if (uniqueCardValueToCheck == currentCardValue)
                {
                    cardValueFrequency += 1;
                }
            }

            bool isFourOfAKind = (cardValueFrequency == 1) || (cardValueFrequency == 4);

            Console.WriteLine("It is {0}!", isFourOfAKind == true ? "Four Of A Kind" : "Full House");
        }
    }
}
