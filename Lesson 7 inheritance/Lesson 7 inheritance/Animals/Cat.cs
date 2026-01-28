using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_7_inheritance.Animals
{
    public class Cat
    {
        public string Name
        {
            get;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Cannot leave entry blank");
                Name = value;
            }
        }

        public int Age
        {
            get;
            set
            {
                if (value < 1 | value > 30)
                    throw new ArgumentOutOfRangeException($"Input needs be between 1 and 30");
                Age = value;
            }
        }

        private string _breed;

        public string Breed
        {
            get => _breed;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Cannot leave entry blank");
                _breed = value;
            }
        }
        private int _angerLevel;

        public int AngerLevel
        {
            get => _angerLevel;
            private set;
        }
        public Cat(string name, int age, string species)
        {
            Random rnd = new Random();
            Age = age;
            Name = name;
            Breed = species;
            AngerLevel = rnd.Next(1, 101);
        }

        private void MakeNoise()
        {
            Console.WriteLine($"{Name} purrs quietly.");
        }

        public override string ToString()
        {
            return $"{Name}, the {Breed}, is {Age} years old";
        }
    }
}
