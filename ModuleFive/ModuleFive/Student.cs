using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleSix
{
    class Student : Person
    {
        // Static class variable to track the number of students currently enrolled in a school
        private static int studentCount = 0;

        public static int StudentCount
        {
            get
            {
                return studentCount;
            }
        }

        // Student constructor
        public Student(string FirstName, string LastName, DateTime Birthdate)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.BirthDate = BirthDate;
            studentCount++;
        }

        public void TakeTest()
        {
            Console.WriteLine("{0} {1} is taking the test.", this.FirstName, this, LastName);
        }
    }
}