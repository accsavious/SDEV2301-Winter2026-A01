using Lesson_7_inheritance.Animals;
using System.Xml.Serialization;

namespace Lesson_7_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool playing = true;
            while (playing)
            {
                PrintMainMenu();
                int pick = GetInt("choice");
                if (pick == 1)
                {
                    int choice = 0;
                    PrintSelectMenu();
                    choice = GetInt("Choice");
                    if (choice == 1)
                    {
                        AddDog();
                    }
                    else if (choice == 2)
                    {
                        AddCat();
                    }
                    else if (choice == 3)
                    {
                        AddBird();
                    }
                }
                else if (pick == 2) 
                    { playing = false; }
                else { Console.WriteLine("please enter 1 or 2 only"); }
            }

            
            
        }
        static void PrintMainMenu()
        {
            Console.WriteLine("Pet Store.");
            Console.WriteLine("1. Add Animal");
            Console.WriteLine("2. Quit");
        }
        static void PrintSelectMenu()
        {
            Console.WriteLine("Select Animal");
            Console.WriteLine("1. Add dog.");
            Console.WriteLine("2. Add cat.");
            Console.WriteLine("3. Add bird");
        }
        static void AddDog()
        {
            string name = GetString("the name");
            int age = GetInt("the age");
            string breed = GetString("the breed");
            Dog dog = new Dog(name, age, breed);
            Console.WriteLine(dog);
            dog.MakeNoise();
        }
        static void AddCat()
        {
            string name = GetString("the name");
            int age = GetInt("the age");
            string breed = GetString("the breed");
            Cat cat = new Cat(name, age, breed);
            Console.WriteLine(cat);
            cat.MakeNoise();
        }
        static void AddBird()
        {
            string name = GetString("the name");
            int age = GetInt("the age");
            string species = GetString("the species");
            Bird bird = new Bird(name, age, species);
            Console.WriteLine(bird);
            bird.MakeNoise();
        }
        static string GetString(string prompt)
        {
            Console.Write($"Enter {prompt}:");
            string choice = "";
            while (choice == "")
            {
                choice = Console.ReadLine();
                if (choice == "")
                    Console.WriteLine("cannot leave empty");
            }

            return choice;
        }
        static int GetInt(string prompt)
        {
            Console.Write($"Enter {prompt}:");
            bool success = false;
            int choice = 0;
            while (!success)
            {
                success = int.TryParse(Console.ReadLine(), out choice);
                if (!success)
                    Console.WriteLine("enter a whole number only");
            }
            return choice;
        }
    }
}
