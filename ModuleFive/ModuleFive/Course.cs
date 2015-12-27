using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleEight
{
    class Course
    {
        // Course fields
        private string courseName;
        private int credits;
        private int duration;
        private List<Student> students; 
        private List<Teacher> teachers;

        // Course properties
        public string CourseName
        {
            get
            {
                return courseName;
            }

            set
            {
                courseName = value;
            }
        }

        public int Credits
        {
            get
            {
                return credits;
            }

            set
            {
                credits = value;
            }
        }

        public int Duration
        {
            get
            {
                return duration;
            }

            set
            {
                duration = value;
            }
        }

        internal List<Student> Students
        {
            get
            {
                return students;
            }

            set
            {
                students = value;
            }
        }

        internal List<Teacher> Teachers
        {
            get
            {
                return teachers;
            }

            set
            {
                teachers = value;
            }
        }

        public Course(string CourseName, int Credits, int Duration)
        {
            this.CourseName = CourseName;
            this.Credits = Credits;
            this.Duration = Duration;
            this.Students = new List<Student>();
            this.Teachers = new List<Teacher>();
        }

        public void ListStudents()
        {
            foreach (Student student in this.students)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
