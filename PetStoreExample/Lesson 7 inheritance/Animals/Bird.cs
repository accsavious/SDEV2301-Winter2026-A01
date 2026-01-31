using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_7_inheritance.Animals
{
    public class Bird : Pet
    {
        public override int minAge => 1;
        public override int maxAge => 80;
        public override string noise => "chirps excitedly";
        public Bird(string name, int age, string species)
        {
            Age = age;
            Name = name;
            BreedOrSpecies = species;
        }
        public Bird(){}
    }
}
