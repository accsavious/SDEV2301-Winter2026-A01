using LinqBookStore;
namespace BookTests
{
    public class UnitTest1
    {
        static public List<Book> TestLibrary()
        {
            return new List<Book>
            {
                new Book("The Hobbit", "J. R. R.", "Tolkien",
                                new DateTime(1937, 9, 21), 6, 6.99, 310, "Fantasy"),

            };
        }

        [Fact]
        public void GetBooksByPriceReturnsCorrectBook()
        {
            string title = "title";
            string first = "first";
            string last = "last";
            int rating = 10;
            double price = 100;
            int pages = 10;
            string category = "category";
            DateTime testDate = new DateTime(2000, 01, 01);

            List<Book> books = new List<Book>{
                new Book(title, first, last,
                         testDate, rating, price, pages, category),
            };
        }
    }
}
