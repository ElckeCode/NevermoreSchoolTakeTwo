using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NevermoreSchoolTakeTwo
{
    // Event arguments for school events, holds a message
    public class SchoolEventArgs: EventArgs
    {
        public string Message { get; }
        public SchoolEventArgs(string message)
        {
            Message = message;
        }
    }
}
