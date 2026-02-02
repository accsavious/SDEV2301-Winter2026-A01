namespace AdvancedLinq
{
    public class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }   // 0–100
        public string Section { get; set; } // e.g., "A01", "E01", "OE01"
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student { Name = "Alice",   Grade = 85, Section = "A01" },
                new Student { Name = "Bob",     Grade = 72, Section = "A01" },
                new Student { Name = "Charlie", Grade = 90, Section = "OE01"},
                new Student { Name = "Diana",   Grade = 60, Section = "E01" },
                new Student { Name = "David",   Grade = 90, Section = "E01" },
                new Student { Name = "Steve",   Grade = 75, Section = "A01" },
                new Student { Name = "Sukhpreet",   Grade = 67, Section = "OE01" },
                new Student { Name = "Brijesh",   Grade = 80, Section = "E01" },
                new Student { Name = "Lin",     Grade = 95, Section = "OE01"},
                new Student { Name = "Farah",   Grade = 72, Section = "E01" },
                new Student { Name = "Gavin",   Grade = 88, Section = "A01" },
                new Student { Name = "Noah",    Grade = 78, Section = "A01" },
                new Student { Name = "Emma",    Grade = 83, Section = "E01" },
                new Student { Name = "Olivia",  Grade = 91, Section = "OE01" },
                new Student { Name = "Liam",    Grade = 66, Section = "A01" },
                new Student { Name = "Mason",   Grade = 74, Section = "E01" },
                new Student { Name = "Sophia",  Grade = 88, Section = "OE01" },
                new Student { Name = "Isabella", Grade = 59, Section = "A01" },
                new Student { Name = "Ethan", Grade = 97, Section = "E01" },
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
                new Student { Name = "Charlotte", Grade = 69, Section = "A01" },
                new Student { Name = "Henry", Grade = 89, Section = "E01" },
                new Student { Name = "Abigail", Grade = 63, Section = "OE01" },
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

            // FILTERING
            var passing = students.Where(s => s.Grade >= 70);

            Console.WriteLine("\n[Filtering] Passing students (Grade >= 70):");

            // With string interpolation we can pass in an integer to give ourselves
            // a bit of a buffer of white space. If it is a positive number then our
            // text will be right-aligned, if it is a negative number the text will
            // be left-aligned.
            foreach (var s in passing)
                Console.WriteLine($"{s.Name,-7}  {s.Grade}");

            // SORTING
            // We can sort collections using the OrderBy, OrderByDescending, and ThenBy methods

            // OrderBy() orders in ASCENDING order
            // ThenBy() is a secondary sort in ASCENDING order
            var ascSorted = students.OrderBy(s => s.Grade).ThenBy(s => s.Name);
            Console.WriteLine("\n[Sorting] By grade (asc), then name (asc):");
            foreach (var s in ascSorted)
                Console.WriteLine($"{s.Grade,3}  {s.Name}");

            // OrderByDescending() orders in DESCENDING order.
            // ThenByDescending() is a secondary sort in DESCENDING order
            // Sort in descendin order by Grade, then alphabetically by Name
            var descSorted = students
                .OrderByDescending(s => s.Grade)
                .ThenByDescending(s => s.Name);

            Console.WriteLine("\n[Sorting] By grade (desc), then name (desc):");
            foreach (var s in descSorted)
                Console.WriteLine($"{s.Grade,3}  {s.Name}");

            // PROJECTION
            var namesOnly = students.Select(s => s.Name);

            Console.WriteLine("\n[Projection] Names only:");
            foreach (var name in namesOnly)
                Console.WriteLine(name);

            // We can create anonymous type objects that only exist in the context
            // of the query to collect data in unique ways

            // Here we create an anonymous object using the "new" keyword followed
            // by the properties we want.
            var nameAndStatus = students.Select(s => new
            {
                s.Name,
                IsPass = s.Grade >= 70
            });

            Console.WriteLine("\n[Projection] Name + status (IsPass):");
            foreach (var row in nameAndStatus)
                Console.WriteLine($"{row.Name,-7}  Pass? {row.IsPass}");

            // AGGREGATION
            Console.WriteLine("\n[Aggregation] Summary stats:");
            // Count() returns an integer with the number of items in the collection
            int countAll = students.Count();
            Console.WriteLine($"Count = {countAll}");

            // Average() returns the average of a particular numerical value
            double avgGrade = students.Average(s => s.Grade);
            Console.WriteLine($"Average = {avgGrade:F1}");

            // Min() and Max() return the minimum and maximum numerical value
            int minGrade = students.Min(s => s.Grade);
            int maxGrade = students.Max(s => s.Grade);
            Console.WriteLine($"Min = {minGrade}, Max = {maxGrade}");

            // Sum() returns the sum of a group of numerical values
            int sumOfGrades = students.Sum(s => s.Grade);
            Console.WriteLine($"Sum = {sumOfGrades}");

            // We can also add logic to our lambdas so that we can return specific
            // values.
            // If we add some logic to the Count() method we can count how many
            // students got an above average grade.
            int aboveAverage = students.Count(s => s.Grade > avgGrade);
            Console.WriteLine($"Students above average = {aboveAverage}");

            // COMBINED QUERY: Filter -> Sort -> Project

            var report = students
                .Where(s => s.Section == "OE01" && s.Grade >= 70)
                .OrderByDescending(s => s.Grade)
                .Select(s => new { s.Name, s.Grade });

            Console.WriteLine("\n[Combined] Passing in OE01 (desc by grade):");
            foreach (var row in report)
                Console.WriteLine($"{row.Name,-7}  {row.Grade}");

            //Same result using Query Syntax
            var reportQuery =
                from s in students
                where s.Section == "OE01" && s.Grade >= 70
                orderby s.Grade descending
                select new { s.Name, s.Grade };

            Console.WriteLine("\n[Combined - Query Syntax] Passing in OE01:");
            foreach (var row in reportQuery)
                Console.WriteLine($"{row.Name,-7}  {row.Grade}");
        }
    }
}
