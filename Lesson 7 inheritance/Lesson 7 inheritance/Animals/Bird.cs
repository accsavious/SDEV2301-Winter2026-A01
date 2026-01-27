using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_7_inheritance.Animals
{
    public class Bird
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
                if (value < 1 | value > 80)
                    throw new ArgumentOutOfRangeException($"Input needs be between 1 and 80");
                Age = value;
            }
        }

        private string _species;

        public string Species
        {
            get => _species;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Cannot leave entry blank");
                _species = value;
            }
        }

        public Bird(string name, int age, string species)
        {
            Age = age;
            Name = name;
            Species = species;
        }

        private void MakeNoise()
        {
            Console.WriteLine($"{Name} chirps excitedly");
        }

        public override string ToString()
        {
            return $"{Name}, the {Species}, is {Age} years old";
        }
    }
}
