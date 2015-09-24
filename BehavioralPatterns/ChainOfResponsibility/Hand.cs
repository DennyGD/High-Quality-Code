namespace ChainOfResponsibility
{
    using System;
    using System.Collections.Generic;

    internal class Hand
    {
        private const int ExpectedCardsCount = 5;

        private IList<Card> cards;

        internal Hand(IList<Card> cards)
        {
            this.Cards = cards;
        }

        internal IList<Card> Cards
        {
            get
            {
                return new List<Card>(this.cards);
            }

            private set
            {
                if (value.Count != ExpectedCardsCount)
                {
                    throw new ArgumentException(string.Format("A hand must contain exactly {0} cards.", ExpectedCardsCount));
                }

                this.cards = new List<Card>(value);
            }
        }

        public override string ToString()
        {
            string result = "Hand: ";

            foreach (var card in this.Cards)
            {
                result += card.ToString() + " ";
            }

            return result;
        }
    }
}
