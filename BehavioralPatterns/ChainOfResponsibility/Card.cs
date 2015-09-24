namespace ChainOfResponsibility
{
    using System;

    internal class Card
    {
        internal Card(CardValue value, CardSuit suit)
        {
            this.Value = value;
            this.Suit = suit;
        }

        internal CardValue Value { get; private set; }

        internal CardSuit Suit { get; private set; }

        public override string ToString()
        {
            string result = string.Format("[{0} of {1}]", this.Value, this.Suit);
            return result;
        }
    }
}
