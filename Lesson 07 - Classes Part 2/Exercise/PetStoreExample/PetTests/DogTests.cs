using PetStore.Animals;
namespace PetTests
{
    public class DogTests
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(40)]
        public void Age_OutOfRangeArgumentOutOfRangeException(int age)
        {
            // Arrange

            Dog dog = new Dog();

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => dog.Age = age);
        }
    }
}
