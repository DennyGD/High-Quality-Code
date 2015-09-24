namespace Specification
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Specifications;

    public class Demo
    {
        public static void Main()
        {
            var someBookstore = new Bookstore("Shakespeare and Company");
            
            var witchesAbroad = new Book("Witches abroad", Genre.Fantasy, 301);
            someBookstore.Add(witchesAbroad);
            var hatFullOfSky = new Book("Hat full of sky", Genre.Fantasy, 310);
            someBookstore.Add(hatFullOfSky);
            var gameOfThrones = new Book("Game of thrones", Genre.Fantasy, 900);
            someBookstore.Add(gameOfThrones);
            var deathOnTheNile = new Book("Death on the Nile", Genre.Crime, 400);
            someBookstore.Add(deathOnTheNile);
            var historyOfTheBalkans = new Book("History of the Balkans", Genre.History, 1120);
            someBookstore.Add(historyOfTheBalkans);
            
            Console.WriteLine(someBookstore);

            var ruleOnlyFantasy = new ExpressionSpecification<Book>(b => b.Genre == Genre.Fantasy);
            var ruleLargeBooks = new ExpressionSpecification<Book>(b => b.Pages > 1000);
            var rulePagesBelow500 = new ExpressionSpecification<Book>(b => b.Pages < 500);
            var ruleFantasyOrLargeBooks = ruleOnlyFantasy.Or(ruleLargeBooks);

            var allBooks = someBookstore.All();
            
            var largeBooks = allBooks.FindAll(b => ruleLargeBooks.IsSatisfiedBy(b));
            Console.WriteLine("Large books:");
            foreach (var book in largeBooks)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine();

            var fantasyAndLargeBooks = allBooks.FindAll(b => ruleFantasyOrLargeBooks.IsSatisfiedBy(b));
            Console.WriteLine("Fantasy and large books:");
            foreach (var book in fantasyAndLargeBooks)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine();
        }
    }
}
