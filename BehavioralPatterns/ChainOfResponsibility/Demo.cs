namespace ChainOfResponsibility
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Demo
    {
        public static void Main()
        {
            var cardsFormingRoyalFlush = new List<Card> 
            { 
                new Card(CardValue.King, CardSuit.Club),
                new Card(CardValue.Jack, CardSuit.Club),
                new Card(CardValue.Ten, CardSuit.Club),
                new Card(CardValue.Ace, CardSuit.Club),
                new Card(CardValue.Queen, CardSuit.Club)
            };
            var handWithRoyalFlush = new Hand(cardsFormingRoyalFlush);
            var royalFlushChecker = new RoyalFlush();
            royalFlushChecker.Evaluate(handWithRoyalFlush);

            var cardsFormingStraightFlush = new List<Card> 
            { 
                new Card(CardValue.Three, CardSuit.Club),
                new Card(CardValue.Five, CardSuit.Club),
                new Card(CardValue.Four, CardSuit.Club),
                new Card(CardValue.Seven, CardSuit.Club),
                new Card(CardValue.Six, CardSuit.Club)
            };
            var handWithStraightFlush = new Hand(cardsFormingStraightFlush);
            royalFlushChecker.Evaluate(handWithStraightFlush);

            var cardsFormingFourOfAKind = new List<Card> 
            { 
                new Card(CardValue.Jack, CardSuit.Heart),
                new Card(CardValue.Five, CardSuit.Club),
                new Card(CardValue.Jack, CardSuit.Diamond),
                new Card(CardValue.Jack, CardSuit.Spade),
                new Card(CardValue.Jack, CardSuit.Club)
            };
            var handWithFourOfAKind = new Hand(cardsFormingFourOfAKind);
            royalFlushChecker.Evaluate(handWithFourOfAKind);

            var cardsFormingFullHouse = new List<Card> 
            { 
                new Card(CardValue.Jack, CardSuit.Heart),
                new Card(CardValue.Five, CardSuit.Club),
                new Card(CardValue.Jack, CardSuit.Diamond),
                new Card(CardValue.Five, CardSuit.Spade),
                new Card(CardValue.Jack, CardSuit.Club)
            };
            var handWithFullHouse = new Hand(cardsFormingFullHouse);
            royalFlushChecker.Evaluate(handWithFullHouse);

            var cardsFormingFlush = new List<Card> 
            { 
                new Card(CardValue.Jack, CardSuit.Heart),
                new Card(CardValue.Five, CardSuit.Heart),
                new Card(CardValue.Two, CardSuit.Heart),
                new Card(CardValue.King, CardSuit.Heart),
                new Card(CardValue.Eight, CardSuit.Heart)
            };
            var handWithFlush = new Hand(cardsFormingFlush);
            royalFlushChecker.Evaluate(handWithFlush);
        }
    }
}
