namespace LinqDemo
{
    public class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== LINQ Solution ===");

            // Sample collection
            var students = new List<Student>
            {
                new Student { Name = "Alice", Grade = 85 },
                new Student { Name = "Andrew", Grade = 80 },
                new Student { Name = "Bob", Grade = 72 },
                new Student { Name = "Brijesh", Grade = 61 },
                new Student { Name = "Charlie", Grade = 90 },
                new Student { Name = "Diana", Grade = 60 },
                new Student { Name = "David", Grade = 78 },
                new Student { Name = "Evan", Grade = 95 }
            };

            var passingQuery =
                from s in students
                where s.Grade >= 70
                orderby s.Grade descending
                select s;

            Console.WriteLine("\nQuery Syntax: Passing Students (Grade >= 70, sorted desc):");
            foreach (var s in passingQuery)
            {
                Console.WriteLine($"{s.Name} - {s.Grade}");
            }

            // 2. Method syntax: passing students (Grade >= 70, sorted desc)
            var passingMethod = students
                .Where(s => s.Grade >= 70)
                .OrderByDescending(s => s.Grade);

            Console.WriteLine("\nMethod Syntax: Passing Students (Grade >= 70, sorted desc):");
            foreach (var s in passingMethod)
            {
                Console.WriteLine($"{s.Name} - {s.Grade}");
            }
            // 3.A. Projection: Select only student names
            var names = students.Select(s => s.Name);

            Console.WriteLine("\nProjection: Student Names:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            // 3.B. Projection: Select only student names that contain a lower case 'i'
            var filteredNames = students.Where(s => s.Name.Contains("i")).Select(s => s.Name);

            Console.WriteLine("\nProjection: Student Names that contain an 'i':");
            foreach (var name in filteredNames)
            {
                Console.WriteLine(name);
            }

            // 4.A. Grouping: Group by first letter of Name
            var groupByName = from s in students
                              group s by s.Name[0] into g
                              select g;

            Console.WriteLine("\nGrouping: Students by Pass/Fail:");
            foreach (var group in groupByName)
            {
                Console.WriteLine($"{group.Key}");
                foreach (var s in group)
                {
                    Console.WriteLine($"  {s.Name} - {s.Grade}");
                }
            }

            // 4.B. Grouping: Group by Pass/Fail
            var groupByPassFail = from s in students
                         group s by (s.Grade >= 70 ? "Pass" : "Fail") into g
                         select g;

            Console.WriteLine("\nGrouping: Students by Pass/Fail:");
            foreach (var group in groupByPassFail)
            {
                Console.WriteLine($"{group.Key}:");
                foreach (var s in group)
                {
                    Console.WriteLine($"  {s.Name} - {s.Grade}");
                }
            }
        }
    }
}
