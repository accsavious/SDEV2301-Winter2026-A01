using TupleGuardRails;
namespace FruitTests
{
    public class FruitTest
    {
        [Fact]
        public void GetFruitNames_ListOfFruits_ReturnsCorrectNames()
        {
            // Arrange
            List<Fruit> fruits = new List<Fruit>()
            {
                new Fruit() { Name = "Apple", Price = 0.99, Description = "Crunchy"},
                new Fruit() { Name = "Orange", Price = 1.99, Description = "Juicy" },
                new Fruit() { Name = "Banana", Price = 2.99, Description = "Sweet" }
            };

            // Act
            var names = fruits.Select(f => f.Name).ToList();

            // Assert
            Assert.Equal(new[] { "Apple", "Orange", "Banana" }, names);

        }
        [Fact]
        public void GetFruitNameAndPrice_UsingProjection_ReturnsCorrectResults()
        {
            List<Fruit> fruits = new List<Fruit>()
            {
                new Fruit() { Name = "Apple", Price = 0.99, Description = "Crunchy"},
                new Fruit() { Name = "Orange", Price = 1.99, Description = "Juicy" },
                new Fruit() { Name = "Banana", Price = 2.99, Description = "Sweet" }
            };
            FruitService service = new FruitService();
            var result = service.ProjectForListView(fruits);
            Assert.Equal(
                [
                    ("Apple", 0.99),
                    ("Orange", 1.99),
                    ("Banana", 2.99)
                ],
                result
            );

        }
        [Fact]
        public void GetFruitNameAndPrice_NullCollection_ThrowsNullException()
        {
            FruitService service = new FruitService();
            Assert.Throws<ArgumentNullException>(() => service.ProjectForListView(null));
        }
    }
}
