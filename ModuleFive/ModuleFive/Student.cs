using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleEight
{
    class Student : Person
    {
        // Static class variable to track the number of students currently enrolled in a school
        private static int studentCount = 0;

        // Stack to hold student grades
        private Stack<int> grades;

        public static int StudentCount
        {
            get
            {
                return studentCount;
            }
        }

        public Stack<int> Grades
        {
            get
            {
                return grades;
            }

            set
            {
                grades = value;
            }
        }

        // Student constructor
        public Student(string FirstName, string LastName, DateTime Birthdate)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.BirthDate = BirthDate;
            this.Grades = new Stack<int>();
            studentCount++;
        }

        public void TakeTest()
        {
            Console.WriteLine("{0} {1} is taking the test.", this.FirstName, this, LastName);
        }
    }
}