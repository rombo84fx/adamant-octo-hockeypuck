using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFive
{
    class Course
    {
        private const int NumStudents = 3;
        private const int NumTeachers = 3;
        public string CourseName { get; set; }
        public int Credits { get; set; }
        public int Duration { get; set; }
        public Student[] Students { get; set; }
        public Teacher[] Teachers { get; set; }
    }
}
