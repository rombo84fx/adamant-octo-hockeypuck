using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFive
{
    class Student
    {
        // Static class variable to track the number of students currently enrolled in a school
        private static int studentCount = 0;

        // Student fields
        private string firstName;
        private string lastName;
        private DateTime birthDate;
        private string addressLine1;
        private string addressLine2;
        private string city;
        private string stateProvince;
        private string zipPostal;
        private string country;

        // Student properties
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }

            set
            {
                birthDate = value;
            }
        }

        public string AddressLine1
        {
            get
            {
                return addressLine1;
            }

            set
            {
                addressLine1 = value;
            }
        }

        public string AddressLine2
        {
            get
            {
                return addressLine2;
            }

            set
            {
                addressLine2 = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string StateProvince
        {
            get
            {
                return stateProvince;
            }

            set
            {
                stateProvince = value;
            }
        }

        public string ZipPostal
        {
            get
            {
                return zipPostal;
            }

            set
            {
                zipPostal = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

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
    }
}