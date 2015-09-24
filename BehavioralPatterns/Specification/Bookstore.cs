namespace Specification
{
    using System.Collections.Generic;
    using System.Text;

    public class Bookstore
    {
        private IList<Book> books;

        public Bookstore(string name)
        {
            this.Name = name;

            this.books = new List<Book>();
        }

        public string Name { get; set; }

        public void Add(Book book)
        {
            this.books.Add(book);
        }

        public List<Book> All()
        {
            return new List<Book>(this.books);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("{0}: ", this.Name));

            foreach (var book in this.books)
            {
                result.AppendLine(book.ToString());
            }

            result.AppendLine("=====================");
            return result.ToString();
        }
    }
}
