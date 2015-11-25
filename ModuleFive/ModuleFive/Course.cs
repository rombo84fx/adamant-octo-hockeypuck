using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFive
{
    class Course
    {
        // Constants to hold the number of students and teachers
        private const int NumStudents = 3;
        private const int NumTeachers = 3;

        // Course fields
        public string CourseName { get; set; }
        public int Credits { get; set; }
        public int Duration { get; set; }
        public Student[] Students { get; set; }
        public Teacher[] Teachers { get; set; }

        public Course()
        {
            this.Students = new Student[NumStudents];
            this.Teachers = new Teacher[NumTeachers];
        }
    }
}
