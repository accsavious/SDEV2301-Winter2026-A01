# Exercise Advanced LINQ
# Book Store Interactive Menu

Use LINQ to design an interactive menu for a book store inventory. The system will allow a user to interact with an the books in the store and use LINQ to sort, filter, and get details about the books and inventory.

Do not worry about repeating until a user enters a valid value. Focus on the queries.

You will need to read about the DateTime object to get the Year, Month, and Day properties for the publish date.

DateTime link: https://www.c-sharpcorner.com/article/datetime-in-c-sharp/

All of the methods to implement are in the "Methods To Implement" region under the Main method.

Create a new xUnit Test project.

## Requirements

Implement the following methods in the `Program.cs`

### Filtering
1. `GetBooksByPrice(List<Book> books, double price)`
    - Filters the books where the Price of the books is greater than or equal to the price parameter and orders the books by Author's Last name.
    - Use Method Syntax
    - Returns an `IEnumerable<Book>`
    - Write a unit test for this using a test value of 9.99 to ensure the correct number of records are returned.

    Sample Output

    ```
    Title                                    Author               Published
    Pride and Prejudice                      Jane Austen          1813-01-28
    Dune                                     Frank Herbert        1965-10-01
    To Kill a Mockingbird                    Harper Lee           1960-07-11
    ...
    ```
    
2. `GetGenres(List<Book> books)`
    - Select all genres from the List<Book>. 
    - Use the Distinct() method to remove duplicates.
    - Return a new List<string> containing the Genres using the ToList() method.
    - Write a unit test for this method to confirm number of values returned matches the number of distinct generes in the data set.

    Sample Output
    ```
    Available Genres:
    - Fantasy
    - Dystopian
    - Classic
    - Mystery
    - Science Fiction
    - Post-Apocalyptic
    - Historical Fiction
    - Fable
    ```
3. `GetBooksByGenre(List<Book> books, string genre)`
    - Select all Book objects from the books parameter where the Genre matches the `genre` parameter.
    - Order the books by Author last name and then by the title of the book.
    - Write a unit test for this method that will confirm if the first item for the "Classic" genre is the book "Pride and Prejudice".
    - NOTE: In the test, you will have to convert the return value of `GetBooksByGenre` to a List<Book> first. Use the ToList() method for that.

    Sample Output
    ```
    Select a genre: Classic
    Title                                    Author               Published
    Pride and Prejudice                      Jane Austen          1813-01-28
    The Great Gatsby                         F. Scott Fitzgerald  1925-04-10
    To Kill a Mockingbird                    Harper Lee           1960-07-11
    Moby-Dick                                Herman Melville      1851-11-14
    The Catcher in the Rye                   J. D. Salinger       1951-07-16
    ```
4. `GetBooksByPublishDate(List<Book> books, DateTime date)`
    - Select all Book objects from the books parameter where the PublishDate is greater than or equal to the provided date.
    - Order the books by PublishDate in descdencing order
    - NOTE: You can compare DateTime objects using the standard comparison operators
    - Write a unit test for this method with the date 2000-01-01 as the date. Use the DateTime.TryParse() method to convert the string to a DateTime object (Use any Assert that seems appropriate).

    Sample Output
    ```
    Enter the date (yyyy-MM-dd): 1990-01-01
    Title                                    Author               Published
    The Name of the Wind                     Patrick Rothfuss     2007-03-27
    The Road                                 Cormac McCarthy      2006-09-26
    The Book Thief                           Markus Zusak         2005-09-01
    The Da Vinci Code                        Dan Brown            2003-03-18
    Harry Potter and the Philosopher's Stone J. K. Rowling        1997-06-26
    A Game of Thrones                        George R. R. Martin  1996-08-06
    ```
5. `GetBooksByRating(List<Book> books, int rating)`
    - Select all books that matches the value in the `rating` parameter.
    - Order the books alphabetically by Title.
    - Write a unit test for this method that uses a rating value of 8. (Use any Assert that seems appropriate)

    Sample Output
    ```
    Enter the rating: 6
    Title                                    Author               Published
    Moby-Dick                                Herman Melville      1851-11-14
    Pride and Prejudice                      Jane Austen          1813-01-28
    The Handmaid's Tale                      Margaret Atwood      1985-04-17
    The Hobbit                               J. R. R. Tolkien     1937-09-21
    ```
6. `FindRecommendedBooksByGenre(List<Book> books, string genre)`
    - Select all the books that match the value of the `genre` parameter
    - Order the results alphabetically by Title
    - Use the Select() method to create a new anonymous object that contains the book's name and if the book is Recommended (a value of "yes" or "no"). A book is recommended if its Rating is at least 8
    - Print the results from the query.
    - This is a void method, no unit test is required.

    Sample Output
    ```
    Select a genre: Fantasy
    Title                                    Recommended
    A Game of Thrones                        No
    Harry Potter and the Philosopher's Stone Yes
    The Fellowship of the Ring               Yes
    The Hobbit                               No
    The Lion, the Witch and the Wardrobe     No
    The Name of the Wind                     No
    ```
7. `FindApproximateSizeOfBooks(List<Book> books)`
    - Select all of the books
    - Order books by number of pages in descending order then by Author Last Name
    - Use the Select() statement to create a new anonymous object that contains the Title, Author First name and Last name (as a single property), and a new BookSize property.
    - The BookSize property will be "Short", "Medium", or "Long".
        - "Short": Book has less than 200 pages
        - "Medium": Book has 200-400 pages
        - "Long": Book has greater than 400 pages
    - Print the results from the query.
    - This is a void method, no unit test is required.

    Sample Output:
    ```
    Book Sizes:
    Title                                    Author               Size
    A Game of Thrones                        George R. R. Martin  Long
    The Da Vinci Code                        Dan Brown            Long
    The Name of the Wind                     Patrick Rothfuss     Long
    Moby-Dick                                Herman Melville      Long
    The Book Thief                           Markus Zusak         Long
    The Fellowship of the Ring               J. R. R. Tolkien     Long
    Dune                                     Frank Herbert        Long
    Pride and Prejudice                      Jane Austen          Medium
    Nineteen Eighty-Four                     George Orwell        Medium
    .... (rest removed for brevity)
    ```
8. `FindCheapestbooks(List<Book> books)`
    - Select books that have a price less than 7.
    - Order the books alphabetically by Title
    - Use the Select() statement to create a new anonymous object that contains the Title, Author First name and Last name (as a single property), and a new Cheapness property
    - The Cheapness property will be either "Dirt Cheap" or "Pretty Cheap"
        - "Dirt Cheap": price is less than 5
        - "Pretty Cheap": price is less than 7
    - Print the results from the query.
    - This is a void method, no unit test is required.

    Sample Output
    ```
    Cheapest Books:
    Title                                    Author               Cheapness
    Brave New World                          Aldous Huxley        Dirt Cheap
    Do Androids Dream of Electric Sheep?     Philip K. Dick       Pretty Cheap
    Fahrenheit 451                           Ray Bradbury         Pretty Cheap
    Nineteen Eighty-Four                     George Orwell        Pretty Cheap
    The Alchemist                            Paulo Coelho         Dirt Cheap
    The Catcher in the Rye                   J. D. Salinger       Dirt Cheap
    The Da Vinci Code                        Dan Brown            Dirt Cheap
    The Great Gatsby                         F. Scott Fitzgerald  Dirt Cheap
    The Hitchhiker's Guide to the Galaxy     Douglas Adams        Pretty Cheap
    The Hobbit                               J. R. R. Tolkien     Pretty Cheap
    The Lion, the Witch and the Wardrobe     C. S. Lewis          Dirt Cheap
    ```
9. `GetNumberOfBooksByGenre(List<Book> books, string genre)`
    - Get the number of books of the genre based on the `genre` parameter.
    - Returns an int.
    - Write a unit tests for this method to test the "Fantasy" and "Mystery" genres.

    Sample Output
    ```
    Select a genre: Classic
    There are 5 Classic books.
    ```
10. `GetTotalValueOfBooks(List<Book> books)`
    - Get the total value of all books in the book store
    - Returns a double rounded to 2 decimal places
    - Write a unit test for this method.

    Sample Output
    ```
    The total value of the books in inventory is $183.28.
    ```
11. `GetCheapestBooks(List<Book> books)`
    - Get the books with the lowest price.
    - Returns an IEnumerable<Book>
    - Write a unit test for this method.
    
    Sample Output
    ```
    The cheapest books are:
    Title                                    Author               Published
    The Da Vinci Code                        Dan Brown            2003-03-18
    ```
12. `GetMostExpensiveBooks(List<Book> books)`
    - Get the books with the highest price.
    - Returns an IEnumerable<Book>
    - Write a unit test for this method.

    Sample Output
    ```
    Title                                    Author               Published
    Pride and Prejudice                      Jane Austen          1813-01-28
    Moby-Dick                                Herman Melville      1851-11-14
    Dune                                     Frank Herbert        1965-10-01
    A Game of Thrones                        George R. R. Martin  1996-08-06
    ```