using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NevermoreSchoolTakeTwo
{
    // Represents a student house at Nevermore School
    public class House
    {
        // Example static house properties (add as needed)
        public static readonly House Claws = new House("Claws");
        public static readonly House Fangs = new House("Fangs");
        public static readonly House Shadows = new House("Shadows");
        public static readonly House Spirits = new House("Spirits");

        // Name of the house
        public string Name { get; }

        // Constructor sets the house name
        public House(string name)
        {
            Name = name;
        }

        // Returns the house name as a string
        public override string ToString() => Name;
    }
}
