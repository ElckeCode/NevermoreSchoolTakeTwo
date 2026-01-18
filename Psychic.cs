using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NevermoreSchoolTakeTwo
{
    // Represents a Psychic student in the Shadows house
    public class Psychic : Student
    {
        // Constructor sets name, age, and assigns to Shadows house
        public Psychic(string name, int age) : base(name, age, House.Shadows) { }

        // Psychic's special ability
        public override void UseAbility()
        {
            Console.WriteLine($"{Name} reads minds and reveals hidden secrets!");
        }
    }
}
