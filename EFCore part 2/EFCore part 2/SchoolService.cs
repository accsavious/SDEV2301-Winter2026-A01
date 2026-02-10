using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_part_2
{
    internal class SchoolService
    {
        public Course GetSafeCourse(SchoolContext context, string courseCode)
        {
            var loadedCourse = context.Courses
                .Include(c => c.Students)
                .Single(c => c.Code == "RING0000");
            return loadedCourse;
        }

        public void CreateExample(SchoolContext context)
        {
            if (!context.Courses.Any() && !context.Students.Any())
            {
                var course = new Course { Name = "Ringsmithing Fundamentals", Code = "RING0000", Credits = 3 };
                context.Courses.Add(course);

                context.Students.AddRange(
                    new Student { Name = "Sauron", Age = 3232, Course = course },
                    new Student { Name = "Saruman", Age = 400, Course = course },
                    new Student { Name = "Frodo", Age = 50, Course = course }
                    );
                context.SaveChanges();
            }
        }

        public void ReadExample(SchoolContext context)
        {
            var loadedCourse = context.Courses
                .Include(c => c.Students)
                .Single(c => c.Code == "RING0000");

            Console.WriteLine($"\nREAD: {loadedCourse.Code} - {loadedCourse.Name} ({loadedCourse.Credits} credits)");
            foreach (var s in loadedCourse.Students)
                Console.WriteLine($" - Student #{s.Id}: {s.Name} (Age {s.Age})");
        }

        public void UpdateExample(SchoolContext context)
        {
            var loadedCourse = context.Courses
                .Include(c => c.Students)
                .Single(c => c.Code == "RING0000");

            loadedCourse.Credits = 5;
            if (loadedCourse.Students.Where(s => s.Name == "Frodo").Count() > 0)
            {
                var frodo = loadedCourse.Students.Single(s => s.Name == "Frodo");
                frodo.Age = 200;
                context.SaveChanges();
            }
        }

        public void DeleteExample(SchoolContext context)
        {
            var loadedCourse = context.Courses
                .Include(c => c.Students)
                .Single(c => c.Code == "RING0000");
            if (loadedCourse.Students.Where(s => s.Name == "Frodo").Count() > 0)
            {
                var frodo = loadedCourse.Students.Single(s => s.Name == "Frodo");
                context.Students.Remove(frodo);
            }

            context.Courses.Remove(loadedCourse);
            context.SaveChanges();
        }


    }
}
