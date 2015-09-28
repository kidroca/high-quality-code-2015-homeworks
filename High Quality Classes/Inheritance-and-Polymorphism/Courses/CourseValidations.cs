namespace InheritanceAndPolymorphism.Courses
{
    using System;
    using System.Text.RegularExpressions;

    public static class CourseValidations
    {
        public static void ValidateCourseName(string name)
        {
            string invalidCharacters = @"[^\w\s]";
            ValidateString(name, invalidCharacters);       
        }

        public static void ValidateHumanName(string name)
        {
            string invalidCharacters = @"[^A-Za-z\s]";
            ValidateString(name, invalidCharacters);
        }

        public static void ValidateLabName(string name)
        {
            string invalidCharacters = @"[^\w\d]";
            ValidateString(name, invalidCharacters);
        }

        private static void ValidateString(string str, string invalidCharacters)
        {
            if (Regex.IsMatch(str, invalidCharacters))
            {
                throw new NotSupportedException("Invalid Characters Used");
            }
        }
    }
}
