using LinqBookStore;
using System.Diagnostics;

namespace LinqBookStore
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = PopulateData();

            bool runProgram = true;

            while (runProgram)
            {
                PrintMenu();
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        FilterBooks(books);
                        break;
                    case "2":
                        GetBookDetails(books);
                        break;
                    case "3":
                        GetInventoryDetails(books);
                        break;
                    case "4":
                        Console.Clear();
                        break;
                    case "5":
                        runProgram = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Option.");
                        break;
                }
            }
        }

        #region Methods To Implement

        static public IEnumerable<Book> GetBooksByPrice(List<Book> books, double price)
        {
            throw new NotImplementedException();
        }

        static public IEnumerable<string> GetGenres(List<Book> books)
        {
            throw new NotImplementedException();
        }
        static public IEnumerable<Book> GetBooksByGenre(List<Book> books, string genre)
        {
            throw new NotImplementedException();
        }
        static public IEnumerable<Book> GetBooksByPublishDate(List<Book> books, DateTime date)
        {
            throw new NotImplementedException();
        }

        static public IEnumerable<Book> GetBooksByRating(List<Book> books, int rating)
        {
            throw new NotImplementedException();
        }
        static public void FindRecommendedBooksByGenre(List<Book> books, string genre)
        {
            throw new NotImplementedException();
        }
        static public void FindApproximateSizeOfBooks(List<Book> books)
        {
            throw new NotImplementedException();
        }
        static public void FindCheapestbooks(List<Book> books)
        {
            throw new NotImplementedException();
        }

        static public int GetNumberOfBooksByGenre(List<Book> books, string genre)
        {
            throw new NotImplementedException();
        }

        static public double GetTotalValueOfBooks(List<Book> books)
        {

            throw new NotImplementedException();
        }
        static public IEnumerable<Book> GetCheapestBooks(List<Book> books)
        {
            throw new NotImplementedException();
        }
        static public IEnumerable<Book> GetMostExpensiveBooks(List<Book> books)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Filter Books
        static void FilterBooks(List<Book> books)
        {
            PrintFilterBooksMenu();
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    FilterBooksByPrice(books);
                    break;
                case "2":
                    FilterBooksByGenre(books);
                    break;
                case "3":
                    FilterBooksByPublishDate(books);
                    break;
                case "4":
                    FilterBooksByRating(books);
                    break;
                default:
                    Console.WriteLine("Invalid Option.");
                    break;
            }
        }
        static void FilterBooksByPrice(List<Book> books)
        {
            Console.Write("What is the minimum price? ");
            bool success = double.TryParse(Console.ReadLine(), out double price);
            var filteredBooks = GetBooksByPrice(books, price);
            PrintTitleAuthorPublishDate(filteredBooks);
        }
        static void FilterBooksByGenre(List<Book> books)
        {
            Console.WriteLine("Available Genres:");
            var genres = GetGenres(books);
            foreach (var g in genres)
                Console.WriteLine($"- {g}");

            Console.Write("\nSelect a genre: ");
            string genre = Console.ReadLine();
            var booksByGenre = GetBooksByGenre(books, genre);

            PrintTitleAuthorPublishDate(booksByGenre);
        }

        static void FilterBooksByPublishDate(List<Book> books)
        {
            Console.Write("Enter the date (yyyy-MM-dd): ");
            bool success = DateTime.TryParse(Console.ReadLine(), out DateTime date);
            var booksByPublishDate = GetBooksByPublishDate(books, date);

            PrintTitleAuthorPublishDate(booksByPublishDate);
        }

        static void FilterBooksByRating(List<Book> books)
        {
            Console.Write("Enter the rating: ");
            bool success = int.TryParse(Console.ReadLine(), out int rating);
            var booksByRating = GetBooksByRating(books, rating);

            PrintTitleAuthorPublishDate(booksByRating);
        }
        #endregion

        #region Get Book Details
        static void GetBookDetails(List<Book> books)
        {
            PrintBookDetailsMenu();
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    RecommendedBooksByGenre(books);
                    break;
                case "2":
                    ApproximateBookLength(books);
                    break;
                case "3":
                    CheaperBooks(books);
                    break;
                default:
                    Console.WriteLine("Invalid Option.");
                    break;
            }
        }

        static void RecommendedBooksByGenre(List<Book> books)
        {
            Console.WriteLine("Available Genres:");
            var genres = GetGenres(books);
            foreach (var g in genres)
                Console.WriteLine($"- {g}");

            Console.Write("\nSelect a genre: ");
            string genre = Console.ReadLine();
            FindRecommendedBooksByGenre(books, genre);
        }

        static void ApproximateBookLength(List<Book> books)
        {
            Console.WriteLine("Book Sizes:");
            FindApproximateSizeOfBooks(books);
        }

        static void CheaperBooks(List<Book> books)
        {
            Console.WriteLine("Cheapest Books:");
            FindCheapestbooks(books);
        }
        #endregion

        #region Get Inventory Details
        static void GetInventoryDetails(List<Book> books)
        {
            PrintStoreInventoryMenu();
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    NumberOfBooksByGenre(books);
                    break;
                case "2":
                    TotalPriceOfInventory(books);
                    break;
                case "3":
                    CheapestBooks(books);
                    break;
                case "4":
                    MostExpensiveBooks(books);
                    break;
                default:
                    Console.WriteLine("Invalid Option.");
                    break;
            }

        }

        static void NumberOfBooksByGenre(List<Book> books)
        {
            Console.WriteLine("Available Genres:");
            var genres = GetGenres(books);
            foreach (var g in genres)
                Console.WriteLine($"- {g}");

            Console.Write("\nSelect a genre: ");
            string genre = Console.ReadLine();
            int numBooksByGenre = GetNumberOfBooksByGenre(books, genre);

            Console.WriteLine($"There are {numBooksByGenre} {genre} books.");

        }

        static void TotalPriceOfInventory(List<Book> books)
        {
            double totalValue = GetTotalValueOfBooks(books);
            Console.WriteLine($"The total value of the books in inventory is {totalValue:C}.");
        }

        static void CheapestBooks(List<Book> books)
        {
            var results = GetCheapestBooks(books);
            Console.WriteLine("The cheapest books are:");
            PrintTitleAuthorPublishDate(results);
        }

        static void MostExpensiveBooks(List<Book> books)
        {
            var results = GetMostExpensiveBooks(books);
            Console.WriteLine("The most expensive books are:");
            PrintTitleAuthorPublishDate(results);
        }
        #endregion

        #region Printing Methods
        static public void PrintTitleAuthorPublishDate(IEnumerable<Book> books)
        {
            Console.WriteLine($"{"Title",-40} {"Author",-20} Published");
            foreach (Book book in books)
            {
                Console.WriteLine($"{book.Title,-40} {book.Author,-20} {book.PublishDate.ToString("yyyy-MM-dd")}");
            }
        }
        static void PrintMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Filter Books.");
            Console.WriteLine("2. Get Book Details.");
            Console.WriteLine("3. Get Inventory Details.");
            Console.WriteLine("4. Clear Screen.");
            Console.WriteLine("5. Quit.");
            Console.Write("Enter your choice: ");
        }
        static void PrintFilterBooksMenu()
        {
            Console.WriteLine("How would you like to filter the books?");
            Console.WriteLine("1. By Price.");
            Console.WriteLine("2. By Genre.");
            Console.WriteLine("3. By Publish Date.");
            Console.WriteLine("4. By Rating.");
            Console.Write("Enter your choice: ");
        }
        static void PrintBookDetailsMenu()
        {
            Console.WriteLine("Which book details would you like?");
            Console.WriteLine("1. Recommended Books By Genre.");
            Console.WriteLine("2. Approximate Book Length.");
            Console.WriteLine("3. Cheap books.");
            Console.Write("Enter your choice: ");
        }
        static void PrintStoreInventoryMenu()
        {
            Console.WriteLine("Which inventory details would you like?");
            Console.WriteLine("1. Total books by genre.");
            Console.WriteLine("2. Total value of all books in the store.");
            Console.WriteLine("3. Cheapest Book.");
            Console.WriteLine("4. Most Expensive Book.");
            Console.Write("Enter your choice: ");
        }
        #endregion
        static public List<Book> PopulateData()
        {
            return new List<Book>
            {
                new Book("The Hobbit", "J. R. R.", "Tolkien",
                         new DateTime(1937, 9, 21), 6, 6.99, 310, "Fantasy"), 
                new Book("Nineteen Eighty-Four", "George", "Orwell",
                         new DateTime(1949, 6, 8), 7, 6.99, 328, "Dystopian"), 
                new Book("Pride and Prejudice", "Jane", "Austen",
                         new DateTime(1813, 1, 28), 6, 12.99, 345, "Classic"), 
                new Book("To Kill a Mockingbird", "Harper", "Lee",
                         new DateTime(1960, 7, 11), 4, 9.99, 281, "Classic"), 
                new Book("The Great Gatsby", "F. Scott", "Fitzgerald",
                         new DateTime(1925, 4, 10), 1, 4.99, 180, "Classic"), 
                new Book("The Catcher in the Rye", "J. D.", "Salinger",
                         new DateTime(1951, 7, 16), 1, 4.99, 234, "Classic"),
                new Book("Moby-Dick", "Herman", "Melville",
                         new DateTime(1851, 11, 14), 6, 12.99, 635, "Classic"),
                new Book("The Fellowship of the Ring", "J. R. R.", "Tolkien",
                         new DateTime(1954, 7, 29), 8, 10.99, 423, "Fantasy"),
                new Book("Harry Potter and the Philosopher's Stone", "J. K.", "Rowling",
                         new DateTime(1997, 6, 26), 10, 9.99, 223, "Fantasy"),
                new Book("The Da Vinci Code", "Dan", "Brown",
                         new DateTime(2003, 3, 18), 0, 0.99, 689, "Mystery"),
                new Book("Dune", "Frank", "Herbert",
                         new DateTime(1965, 10, 1), 8, 12.99, 412, "Science Fiction"),
                new Book("The Name of the Wind", "Patrick", "Rothfuss",
                         new DateTime(2007, 3, 27), 4, 10.99, 662, "Fantasy"),
                new Book("Brave New World", "Aldous", "Huxley",
                         new DateTime(1932, 2, 4), 5, 4.99, 311, "Dystopian"),
                new Book("Fahrenheit 451", "Ray", "Bradbury",
                         new DateTime(1953, 10, 19), 7, 6.99, 156, "Dystopian"),
                new Book("The Handmaid's Tale", "Margaret", "Atwood",
                         new DateTime(1985, 4, 17), 6, 8.99, 311, "Dystopian"),
                new Book("The Road", "Cormac", "McCarthy",
                         new DateTime(2006, 9, 26), 4, 9.49, 287, "Post‑Apocalyptic"),
                new Book("The Book Thief", "Markus", "Zusak",
                         new DateTime(2005, 9, 1), 9, 10.99, 584, "Historical Fiction"),
                new Book("The Alchemist", "Paulo", "Coelho",
                         new DateTime(1988, 1, 1), 8, 4.49, 208, "Fable"),
                new Book("The Hitchhiker's Guide to the Galaxy", "Douglas", "Adams",
                         new DateTime(1979, 10, 12), 3, 6.49, 180, "Science Fiction"),
                new Book("Do Androids Dream of Electric Sheep?", "Philip K.", "Dick",
                         new DateTime(1968, 1, 1), 2, 6.99, 210, "Science Fiction"),
                new Book("The Lion, the Witch and the Wardrobe", "C. S.", "Lewis",
                         new DateTime(1950, 10, 16), 7, 4.99, 172, "Fantasy"),
                new Book("A Game of Thrones", "George R. R.", "Martin",
                         new DateTime(1996, 8, 6), 5, 12.99, 694, "Fantasy"),

            };
        }
    }
}
