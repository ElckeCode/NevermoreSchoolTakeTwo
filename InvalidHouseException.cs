using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NevermoreSchoolTakeTwo
{
    // Exception thrown when an invalid house is specified
    internal class InvalidHouseException : Exception
    {
        // Constructor passes the error message to the base Exception class
        public InvalidHouseException(string message) : base(message) { }
    }
}
