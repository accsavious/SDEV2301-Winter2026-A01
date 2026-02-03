namespace Lesson_12_LinQ_Advanced
{
    public class Student

    {

        public string Name { get; set; }

        public int Grade { get; set; }

        public string Section { get; set; } 

    }
    internal class Program
    {

        static void Main(string[] args)
        {
            var students = new List<Student>

        {

            new Student { Name = "Alice",   Grade = 85, Section = "A01" },

            new Student { Name = "Bob",     Grade = 72, Section = "A01" },

            new Student { Name = "Charlie", Grade = 40, Section = "OE01"},

            new Student { Name = "Diana",   Grade = 60, Section = "E01" },

            new Student { Name = "David",   Grade = 90, Section = "E01" },

            new Student { Name = "Steve",   Grade = 75, Section = "A01" },

            new Student { Name = "Sukhpreet",   Grade = 67, Section = "OE01" },

            new Student { Name = "Brijesh",   Grade = 72, Section = "E01" },

            new Student { Name = "Lin",     Grade = 95, Section = "OE01"},

            new Student { Name = "Farah",   Grade = 72, Section = "E01" },

            new Student { Name = "Gavin",   Grade = 88, Section = "A01" },

            new Student { Name = "Noah",    Grade = 72, Section = "A01" },

            new Student { Name = "Emma",    Grade = 83, Section = "E01" },

            new Student { Name = "Olivia",  Grade = 72, Section = "OE01" },

            new Student { Name = "Liam",    Grade = 66, Section = "A01" },

            new Student { Name = "Mason",   Grade = 74, Section = "E01" },

            new Student { Name = "Sophia",  Grade = 5, Section = "OE01" },

            new Student { Name = "Isabella", Grade = 59, Section = "A01" },

            new Student { Name = "Ethan", Grade = 72, Section = "E01" },

            new Student { Name = "Ava", Grade = 82, Section = "OE01" },

            new Student { Name = "Logan", Grade = 70, Section = "A01" },

            new Student { Name = "Mia", Grade = 92, Section = "E01" },

            new Student { Name = "Lucas", Grade = 64, Section = "OE01" },

            new Student { Name = "Amelia", Grade = 86, Section = "A01" },

            new Student { Name = "James", Grade = 55, Section = "E01" },

            new Student { Name = "Harper", Grade = 77, Section = "OE01" },

            new Student { Name = "Benjamin", Grade = 94, Section = "A01" },

            new Student { Name = "Evelyn", Grade = 73, Section = "E01" },

            new Student { Name = "Elijah", Grade = 81, Section = "OE01" },

            new Student { Name = "Charlotte", Grade = 72, Section = "A01" },

            new Student { Name = "Henry", Grade = 89, Section = "E01" },

            new Student { Name = "Abigail", Grade = 72, Section = "OE01" },

            new Student { Name = "Alexander", Grade = 76, Section = "A01" },

            new Student { Name = "Emily", Grade = 85, Section = "E01" },

            new Student { Name = "Daniel", Grade = 58, Section = "OE01" },

            new Student { Name = "Aiden", Grade = 93, Section = "A01" },

            new Student { Name = "Luna", Grade = 68, Section = "E01" },

            new Student { Name = "Jackson", Grade = 72, Section = "OE01" },

            new Student { Name = "Chloe", Grade = 87, Section = "A01" },

            new Student { Name = "Sebastian", Grade = 79, Section = "E01" },

            new Student { Name = "Zoe", Grade = 96, Section = "OE01" }

        };
            var passing = students.Where(s =>  s.Grade >= 70 && s.Grade <= 75)
                .OrderByDescending(s => s.Grade).ThenBy(s => s.Name);

            foreach (Student student in passing)
            {
                Console.WriteLine($"{student.Name,-10}: {student.Grade}");
            }

            Console.WriteLine("------");
            var namesOnly = students.Select(s => new
            {
                s.Name,
                IsPass = s.Grade >= 70? "Has passed": "Has failed"

            }).ToList();
            foreach (var record in namesOnly)
            {

                Console.WriteLine($"{record.Name,-15} {record.IsPass}");
            }
            Console.WriteLine("------");
            // AGGREGATION
            int numStudents = students.Count(s => s.Grade >= 70);
            Console.WriteLine($"number of students: {numStudents}");

            double avgGrade = students.Average(s => s.Grade);
            Console.WriteLine($"The average was {avgGrade:F2}");

            int min = students.Min(s =>  s.Grade);
            int max = students.Max(s => s.Grade);
            Console.WriteLine($"Higest mark is {max}, lowest is {min}");

            int minish = students.Where((s) => s.Grade >= 70)
                .Min(s => s.Grade);
            int maxish = students.Where((s) => s.Grade < 70)
                .Max(s => s.Grade);
            Console.WriteLine($"Lowest pass: {minish}, highest fail: {maxish}");

            Console.WriteLine("------");
            // passing students in section OE01

            var combinedQuery = students.Where(
                s => s.Section == "OE01" && s.Grade >= 70)
                .OrderByDescending(s => s.Grade).ThenBy(s => s.Name)
                .Select(s => new
                {
                    s.Name,
                    s.Grade
                });

            foreach (var student in combinedQuery)
                Console.WriteLine($"{student.Name,-10} : Grade {student.Grade}");

            Console.WriteLine("------");
            Console.WriteLine("------");
            Console.WriteLine("------");
            Console.WriteLine("------");


        }
    }
}
