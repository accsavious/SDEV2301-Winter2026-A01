using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_7_inheritance.Animals
{
    public class Dog
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
                if (value < 1 | value > 20)
                    throw new ArgumentOutOfRangeException($"Input needs be between 1 and 20");
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
        public Dog(string name, int age, string species)
        {
            Age = age;
            Name = name;
            Breed = species;
        }

        private void MakeNoise()
        {
            Console.WriteLine($"{Name} barks loudly");
        }

        public override string ToString()
        {
            return $"{Name}, the {Breed}, is {Age} years old";
        }
    }
}
