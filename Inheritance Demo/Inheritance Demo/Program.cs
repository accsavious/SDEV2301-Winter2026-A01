namespace Inheritance_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Circle circle = new Circle(10, "Red");
            //Console.WriteLine($"This is a {circle.Color} circle " +
            //    $"with an area {circle.GetArea()}.");
            //circle.Describe();

            //Rectangle rectangle = new Rectangle(10, 5, "Blue");
            //Console.WriteLine($"This is a {rectangle.Color}" +
            //    $" rectangle with an area {rectangle.GetArea()}.");
            //rectangle.Describe();

            //Circle[] circles = new Circle[3];
            //circles[0] = new Circle(3, "green");
            //circles[1] = new Circle(7, "maroon");

            //Console.WriteLine("---------");
            //foreach (Circle c in circles)
            //{
            //    if (c == null)
                    
            //        continue;
            //    c.Describe();
            //}

            //Rectangle[] rectanges =
            //{
            //    new Rectangle(4,10, "blue"),
            //    new Rectangle(7,12, "red"),
            //    new Rectangle(12, 2, "purple"),
            //};

            List<Shape> shapes = new List<Shape>();
                string color = "Red";
                AddCircle(shapes, ref color);
                //new Circle(4, "Slime Green"),
                //new Rectangle(3, 8, "Red"),
                //new Circle(7, "Blurple")
            Console.WriteLine("----");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{shape.Color} shape. Area is" +
                    $" {shape.GetArea()}");
                shape.Describe();
                if (shape is Circle)
                {
                    Circle c = (Circle)shape;
                    Console.WriteLine($"Radius: {c.Radius}");
                }

                if (shape is IPolygon)
                {
                    IPolygon p = (IPolygon)shape;
                    Console.WriteLine($"Sides = {p.NumberOfSides}" +
                        $", Angles = {p.GetAngleOfCorners()}");
                }

            }
        }
        static void AddCircle(List<Shape> shapes, ref string color)
        {
            color = "Orange";
            shapes.Add(new Circle(5, color));
        }
    }
}
