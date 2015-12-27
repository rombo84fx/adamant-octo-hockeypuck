using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleEight
{
    class Degree
    {
        // Degree fields
        private string degreeName;
        private int creditsRequired;
        private Course degreeCourse;

        public string DegreeName
        {
            get
            {
                return degreeName;
            }

            set
            {
                degreeName = value;
            }
        }

        public int CreditsRequired
        {
            get
            {
                return creditsRequired;
            }

            set
            {
                creditsRequired = value;
            }
        }

        internal Course DegreeCourse
        {
            get
            {
                return degreeCourse;
            }

            set
            {
                degreeCourse = value;
            }
        }

        public Degree(string DegreeName, int CreditsRequired, Course DegreeCourse)
        {
            this.DegreeName = DegreeName;
            this.CreditsRequired = CreditsRequired;
            this.DegreeCourse = DegreeCourse;
        }
    }
}
