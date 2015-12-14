using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleSix
{
    class Course
    {
        // Constants to hold the number of students and teachers
        private const int NumStudents = 3;
        private const int NumTeachers = 3;

        // Course fields
        private string courseName;
        private int credits;
        private int duration;
        private Student[] students;
        private Teacher[] teachers;

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

        internal Student[] Students
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

        internal Teacher[] Teachers
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
            this.Students = new Student[NumStudents];
            this.Teachers = new Teacher[NumTeachers];
        }
    }
}
