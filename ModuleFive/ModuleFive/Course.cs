using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleSeven
{
    class Course
    {
        // Course fields
        private string courseName;
        private int credits;
        private int duration;
        private ArrayList students; 
        private ArrayList teachers;

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

        internal ArrayList Students
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

        internal ArrayList Teachers
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
            this.Students = new ArrayList();
            this.Teachers = new ArrayList();
        }

        public void ListStudents()
        {
            // foreach loop using implicit casting
            //foreach (Student student in this.students)
            //{
            //    Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            //}

            // foreach loop using explicit casting as assignment intructions indicated
            foreach (object _object in this.students)
            {
                Student student = (Student)_object;
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
