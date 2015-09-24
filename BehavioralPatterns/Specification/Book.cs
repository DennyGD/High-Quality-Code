namespace Specification
{
    public class Book
    {
        public Book(string title, Genre genre, int pages)
        {
            this.Title = title;
            this.Genre = genre;
            this.Pages = pages;
        }

        public string Title { get; set; }

        public Genre Genre { get; set; }

        public int Pages { get; set; }

        public override string ToString()
        {
            string result = string.Format("[Title: {0}, Genre: {1}, Pages: {2}]", this.Title, this.Genre, this.Pages);
            return result;
        }
    }
}
