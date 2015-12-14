using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleSix
{
    class UProgram
    {
        // UProgram fields
        private string programName;
        private string departmentHead;
        private Degree programDegree;

        // UProgram properties
        public string ProgramName
        {
            get
            {
                return programName;
            }

            set
            {
                programName = value;
            }
        }

        public string DepartmentHead
        {
            get
            {
                return departmentHead;
            }

            set
            {
                departmentHead = value;
            }
        }

        internal Degree ProgramDegree
        {
            get
            {
                return programDegree;
            }

            set
            {
                programDegree = value;
            }
        }

        // UProgram constructor
        public UProgram(string ProgramName, string DepartmentHead, Degree ProgramDegree)
        {
            this.ProgramName = ProgramName;
            this.DepartmentHead = DepartmentHead;
            this.ProgramDegree = ProgramDegree;        
        }
    }
}