namespace LinqBookStore
{
    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Author(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public DateTime PublishDate { get; set; }
        public int Rating { get; set; }
        public double Price { get; set; }
        public int NumberOfPages { get; set; }
        public string Genre { get; set; }


        public Book(string title, string authorFirst, string authorSecond, DateTime publishDate, int rating, double price, int numberOfPages, string genre)
        {
            Title = title;
            Author = new Author(authorFirst, authorSecond);
            PublishDate = publishDate;
            Rating = rating;
            Price = price;
            NumberOfPages = numberOfPages;
            Genre = genre;
        }

    }
}
