using System;
using System.Xml.Linq;

namespace Lesson2Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare an integer variable called age and assign it the value 21
            //int age = ???
            int age = 21;
            // TODO: Declare a string variable called name and assign it your name
            // string name = ???
            string name = "Gary";
            // TODO: Declare a double variable called gpa and assign it the value 3.5
            // double gpa = ???
            double gpa = 3.5;
            // TODO: Declare a boolean variable called isFullTime and assign it true
            // bool isFullTime = ???
            bool isFullTime = true;
            // Output the variables
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("GPA: " + gpa);
            Console.WriteLine("Full-Time: " + isFullTime);

            // TODO: Predict the output before running
            // Student Name: Gary
            // Age: 21
            // GPA: 3.5
            // Full-Time: true ** this showed as True, the system capitolized it

        }
    }
}