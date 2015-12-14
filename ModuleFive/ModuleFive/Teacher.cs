using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleSix
{
    class Teacher : Person
    {
        // Teacher constructor
        public Teacher(string FirstName, string LastName, DateTime BirthDate)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.BirthDate = BirthDate; 
        }

        public void GradeTest()
        {
            Console.WriteLine("{0} {1} is grading test.", this.FirstName, this.LastName);
        }

    }
}
