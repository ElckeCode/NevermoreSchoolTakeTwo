using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NevermoreSchoolTakeTwo
{
    // Represents a Werewolf student in the Claws house
    public class Werewolf : Student
    {
        // Constructor sets name, age, and assigns to Claws house
        public Werewolf(string name, int age) : base(name, age, House.Claws) { }
        
        // Werewolf's special ability
        public override void UseAbility()
        {
            Console.WriteLine($"{Name} lets out a fearsome howl!");
        }
    }
}
