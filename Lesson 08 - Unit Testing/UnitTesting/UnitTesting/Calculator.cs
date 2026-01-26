using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting
{
    // static classes can never have an instance of them created
    // All methods, properties, and fields must be set to static as well
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public double Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            return (double)a / b;
        }
    }
}

