using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NevermoreSchoolTakeTwo
{
    // Represents a Spirit student in the Spirits house
    internal class Spirit : Student
    {
        // Constructor sets name, age, and assigns to Spirits house
        public Spirit(string name, int age) : base(name, age, House.Spirits) {}

        // Spirit's special ability
        public override void UseAbility()
        {
            Console.WriteLine($"{Name} wispers to the forgotten and the dead stir!");
        }
    }
}
