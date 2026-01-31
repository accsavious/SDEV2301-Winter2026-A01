using Lesson_7_inheritance.Animals;

namespace PetTests
{
    public class DogTests
    {
        [Fact]
        public void DogInstanceReturnsNameAgeBreed()
        {
            string name = "dog";
            int age = 1;
            string breed = "mutt";
            Dog dog = new Dog(name, age, breed);
            string test = $"{name}{age}{breed}";
            string dogStats = $"{dog.Name}{dog.Age}{dog.BreedOrSpecies}";
            Assert.Equal(dogStats, test);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(800)]
        public void DogAgeOutsideRangeThrowsOutOfRangeException(int a)
        {
            Dog dog = new Dog();
            Assert.Throws<ArgumentOutOfRangeException>(() => dog.Age = a);
        }
    }
    public class CatTests
    {
        [Fact]
        public void CatInstanceReturnsNameAgeBreed()
        {
            string name = "cat";
            int age = 1;
            string breed = "moggie";
            Cat cat = new Cat(name, age, breed);
            string test = $"{name}{age}{breed}";
            string dogStats = $"{cat.Name}{cat.Age}{cat.BreedOrSpecies}";
            Assert.Equal(dogStats, test);
        }
        [Theory]
        [InlineData(-1)]
        [InlineData(800)]
        public void CatAgeOutsideRangeThrowsOutOfRangeException(int a)
        {
            Cat cat = new Cat();
            Assert.Throws<ArgumentOutOfRangeException>(() => cat.Age = a);
        }
    }
    public class BirdTests
    {
        [Fact]
        public void BirdInstanceReturnsNameAgeBreed()
        {
            string name = "bird";
            int age = 1;
            string species = "parrot";
            Bird bird = new Bird(name, age, species);
            string test = $"{name}{age}{species}";
            string dogStats = $"{bird.Name}{bird.Age}{bird.BreedOrSpecies}";
            Assert.Equal(dogStats, test);
        }
        [Theory]
        [InlineData(-1)]
        [InlineData(800)]
        public void BirdAgeOutsideRangeThrowsOutOfRangeException(int a)
        {
            Bird bird = new Bird();
            Assert.Throws<ArgumentOutOfRangeException>(() => bird.Age = a);
        }
    }
}
