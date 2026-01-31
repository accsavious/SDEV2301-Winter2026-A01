using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_7_inheritance.Animals
{
    public abstract class Pet
    {
        public abstract int minAge { get; }
        public abstract int maxAge { get; }
        public abstract string noise { get; }
        private string _name;
        private int _age;
        private string _breedOrSpecies;
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Age
        {
            get => _age;
            set
            {
                if (value < minAge | value > maxAge)
                    throw new ArgumentOutOfRangeException($"Input needs be between {minAge} and {maxAge}");
                _age = value;
            }
        }
        public string BreedOrSpecies
        {
            get => _breedOrSpecies;
            set => _breedOrSpecies = value;
        }
        public void MakeNoise()
        {
            Console.WriteLine($"{Name} {noise}");
        }

        public override string ToString()
        {
            return $"{Name}, the {BreedOrSpecies}, is {Age} years old";
        }
    }
}
