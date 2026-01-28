using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Demo
{
    public abstract class Shape
    {
        public string Color { get; set; }

        public Shape(string color)
        { Color  = color; }

        public abstract double GetArea();

        public virtual void Describe()
        {
            Console.WriteLine($"This is a {Color} shape");
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }


        public Circle(double radius, string color) : base(color)
        {
            Radius = radius; 
        }
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override void Describe()
        {
            Console.WriteLine($"This is a {Color} circle");
        }
    }
    public class Rectangle : Shape, IPolygon
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public int NumberOfSides { get; }

        public Rectangle(double width, double height, string color) : base(color)
        {
            Length = width; Width = height; NumberOfSides = 4;
        }

        public override double GetArea()
        {
            return Length * Width;
        }
        public override void Describe()
        {
            Console.WriteLine($"This is a {Color} rectangle");
        }

        public double GetAngleOfCorners()
        {
            return 360 / 4;
        }
    }
    public class Triangle : Shape, IPolygon
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public int NumberOfSides { get; }

        public Triangle(double l, double w, string color) : base (color)
        {
            Length = l;
            Width = w;
            NumberOfSides = 3;
        }

        public override double GetArea()
        {
            return Length * Width /2.0;
        }
        public override void Describe()
        {
            Console.WriteLine($"This is a {Color} triangle");
        }

        public double GetAngleOfCorners()
        {
            return 180 / 3;
        }
    }

}
