namespace introLinq
{
    public class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new() { Name = "Alice", Grade = 85 },
                new Student { Name = "Andrew", Grade = 80 },
                new Student { Name = "Bob", Grade = 72 },
                new Student { Name = "Brijesh", Grade = 61 },
                new Student { Name = "Charlie", Grade = 90 },
                new Student { Name = "Diana", Grade = 60 },
                new Student { Name = "David", Grade = 78 },
                new Student { Name = "Evan", Grade = 95 }
            };
            // QUERY SYNTAX
            var queryQuery = from s in students
                             where s.Name.Contains("D")
                             orderby s.Grade ascending
                             select s;
            foreach (Student s in queryQuery)
            {
                Console.WriteLine($"{s.Name, -10}, {s.Grade}");
            };

            Console.WriteLine("-------");

            var methodSyntaxDemoQuery = students.Where(s => s.Grade >= 70)
                .OrderByDescending(s => s.Name);
            foreach (Student s in methodSyntaxDemoQuery)
            {
                Console.WriteLine($"{s.Name,-10}, {s.Grade}");
            }
            ;
            Console.WriteLine("-------");

            //PROJECTION - Transforms an object into a new form
            var names = students.Where(s => s.Name.Contains("e"))
                .Select(s => s.Name);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("-------");
            // GROUPS

            var groupByName = from s in students
                              group s by s.Name[0] into g
                              select g;
            foreach (var group in groupByName)
            {
                Console.WriteLine(group.Key);
                foreach (Student s in group)
                {
                    Console.WriteLine($"{s.Name,-10} {s.Grade}"); 
                }
            }

            Console.WriteLine("-------");
            var groupPassFail = from s in students
                          orderby s.Name descending
                          group s by (s.Grade >= 70 ? "Pass" : "Fail")
                          into g
                          select g;
            foreach (var group in groupPassFail)
            {
                Console.WriteLine(group.Key);
                foreach (Student s in group)
                {
                    Console.WriteLine($"{s.Name,-10} {s.Grade}");
                }
            }
        }
    }
}
