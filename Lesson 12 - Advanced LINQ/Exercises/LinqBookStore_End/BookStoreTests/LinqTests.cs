using LinqBookStore;

namespace BookStoreTests
{
    public class LinqTests
    {
        [Fact]
        public void GetBooksByPrice_MiddlePrice_ReturnsCorrectResults()
        {
            List<Book> data = Program.PopulateData();
            IEnumerable<Book> filteredBooks = Program.GetBooksByPrice(data, 9.99);
            Assert.Equal(9, filteredBooks.Count());
        }
        [Fact]
        public void GetGenres_All_ReturnsAllGenres()
        {
            List<Book> data = Program.PopulateData();
            IEnumerable<string> genres = Program.GetGenres(data);
            Assert.Equal(8, genres.Count());
        }
        [Fact]
        public void GetBooksByGenre_ClassicGenre_ReturnsCorrectResults()
        {
            List<Book> data = Program.PopulateData();
            IEnumerable<Book> books = Program.GetBooksByGenre(data, "Classic").ToList();
            Assert.Equal("Pride and Prejudice", books.FirstOrDefault().Title);
        }
        [Fact]
        public void GetBooksByPublishDate_2000_01_01_ReturnsCorrectResults()
        {
            List<Book> data = Program.PopulateData();
            DateTime.TryParse("2000-01-01", out DateTime date);
            IEnumerable<Book> books = Program.GetBooksByPublishDate(data, date);
            Assert.Equal(4, books.Count());
        }
        [Fact]
        public void GetBooksByRating_Rating8_ReturnsCorrectResults()
        {
            List<Book> data = Program.PopulateData();
            IEnumerable<Book> books = Program.GetBooksByRating(data, 8).ToList();
            Assert.Equal("Dune", books.FirstOrDefault().Title);
        }
        [Theory]
        [InlineData("Fantasy", 6)]
        [InlineData("Mystery", 1)]
        public void GetNumberOfBooksByGenre_MultipleGenres_ReturnsCorrectCount(string genre, int expectedCount)
        {
            List<Book> data = Program.PopulateData();
            int numBooks = Program.GetNumberOfBooksByGenre(data, genre);
            Assert.Equal(expectedCount, numBooks);
        }
        [Fact]
        public void GetTotalValueOfBooks_CompleteInventory_ReturnsCorrectSum()
        {
            List<Book> data = Program.PopulateData();
            double expectedValue = 183.28;
            double totalValue = Program.GetTotalValueOfBooks(data);

            Assert.Equal(expectedValue, Math.Round(totalValue, 2));
        }
        [Fact]
        public void GetCheapestBooks_LowestPrice_ReturnsCorrectResults()
        {
            List<Book> data = Program.PopulateData();
            IEnumerable<Book> results = Program.GetCheapestBooks(data);
            Assert.Equal(1, results.Count());
        }
        [Fact]
        public void GetCheapestBooks_HighestPrice_ReturnsCorrectResults()
        {
            List<Book> data = Program.PopulateData();
            IEnumerable<Book> results = Program.GetMostExpensiveBooks(data);
            Assert.Equal(4, results.Count());
        }
    }
}
