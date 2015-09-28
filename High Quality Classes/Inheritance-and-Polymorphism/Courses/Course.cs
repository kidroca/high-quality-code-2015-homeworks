namespace InheritanceAndPolymorphism.Courses
{
    using System.Collections.Generic;
    using System.Text;

    public abstract class Course
    {
        private string name;

        private string teacher;

        private IList<string> students = new List<string>();

        public Course(string courseName)
        {
            this.Name = courseName;
            this.Teacher = null;
        }

        public Course(string courseName, string teacher)
            : this(courseName)
        {
            this.Teacher = teacher;
        }

        public Course(string courseName, string teacher, IList<string> students)
            : this(courseName, teacher)
        {
            this.AddStudents(students);
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                CourseValidations.ValidateCourseName(value);
                this.name = value;
            }
        }

        public string Teacher
        {
            get
            {
                return this.teacher;
            }

            set
            {
                if (value != null)
                {
                    CourseValidations.ValidateHumanName(value);
                }
                
                this.teacher = value;
            }
        }

        public IList<string> Students
        {
            get
            {
                return new List<string>(this.students);
            }
        }

        public void AddStudents(params string[] list)
        {
            foreach (string name in list)
            {
                this.AddStudent(name);
            }
        }

        public void AddStudents(IList<string> students)
        {
            foreach (string name in students)
            {
                this.AddStudent(name);
            }
        }

        public void RemoveAllStudents()
        {
            this.Students.Clear();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("LocalCourse { Name = ");
            result.Append(this.Name);

            if (this.Teacher != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.Teacher);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());

            result.Append(" }");

            return result.ToString();
        }

        private void AddStudent(string name)
        {
            CourseValidations.ValidateHumanName(name);
            this.students.Add(name);
        }

        private string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }
    }
}
