using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_7_inheritance.Animals
{
    public class Bird
    {
        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Cannot leave entry blank");
                _name = value;
            }
        }



        public int Age
        {
            get;
            set;
        }
    }
}
