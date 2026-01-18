using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NevermoreSchoolTakeTwo
{
    // Exception thrown when a duplicate student name is detected
    public class DuplicateNameException : Exception
    {
        // Constructor passes the error message to the base Exception class
        public DuplicateNameException(string message) : base(message) { }
    }
}
