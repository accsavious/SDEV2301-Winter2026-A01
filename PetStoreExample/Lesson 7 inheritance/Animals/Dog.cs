using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Lesson_7_inheritance.Animals
{
    public class Dog : Pet
    {
        public override int minAge => 1;
        public override int maxAge => 20;
        public override string noise => "barks loudly";
        public Dog(string name, int age, string species)
        {
            Age = age;
            Name = name;
            BreedOrSpecies = species;
        }
        public Dog(){}
    }
}
