using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Lesson_7_inheritance.Animals
{
    public class Cat : Pet
    {
        public override int minAge => 1;
        public override int maxAge => 30;
        public override string noise => "purrs quietly";
        public Cat(string name, int age, string species)
        {
            Age = age;
            Name = name;
            BreedOrSpecies = species;
        }
        public Cat(){}
    }
}
