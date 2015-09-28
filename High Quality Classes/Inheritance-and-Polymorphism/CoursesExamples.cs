namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using InheritanceAndPolymorphism.Courses;

    public class CoursesExamples
    {
        private static void Main()
        {
            LocalCourse localCourse = new LocalCourse("Databases");
            Console.WriteLine(localCourse);

            localCourse.Lab = "Enterprise";
            Console.WriteLine(localCourse);

            localCourse.AddStudents("Peter", "Maria");  
            Console.WriteLine(localCourse);

            localCourse.Teacher = "Svetlin Nakov";
            localCourse.AddStudents("Milena");
            localCourse.AddStudents("Todor");
            Console.WriteLine(localCourse);

            OffsiteCourse offsiteCourse = new OffsiteCourse(
                "PHP and WordPress Development",
                "Mario Peshev",
                new List<string>() { "Thomas", "Ani", "Steve" });
            Console.WriteLine(offsiteCourse);
        }
    }
}
