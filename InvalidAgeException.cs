using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NevermoreSchoolTakeTwo
{
    // Exception thrown when a student's age is invalid
    public class InvalidAgeException : Exception
    {
        // Constructor passes the error message to the base Exception class
        public InvalidAgeException(string message) : base(message) { }
    }
}
