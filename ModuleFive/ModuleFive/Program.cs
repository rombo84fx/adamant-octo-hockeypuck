using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("John", "Doe", new DateTime(1990, 3, 31));
            Student student2 = new Student("George", "Lucas", new DateTime(1990, 4, 8));
            Student student3 = new Student("Peter", "Parker", new DateTime(1990, 11, 20));

            Course course1 = new Course("Programming with C#", 40, 16);
            course1.Students[0] = student1;
            course1.Students[1] = student2;
            course1.Students[2] = student3;

            Teacher teacher1 = new Teacher("Gerardo", "Martinez", new DateTime(1984, 5, 7));
            course1.Teachers[0] = teacher1;

            Degree degree1 = new Degree("Bachelor of Science", 40, course1);

            UProgram uprogram1 = new UProgram("Information Technology", "Bruce Wayne", degree1);

            Console.WriteLine("The {0} program contains the {1} degree\n", uprogram1.ProgramName, degree1.DegreeName);
            Console.WriteLine("The {0} degree contains the course {1}\n", degree1.DegreeName, course1.CourseName);
            Console.WriteLine("The {0} course contains {1} student(s)", course1.CourseName, Student.StudentCount);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
