using System;

namespace NevermoreSchoolTakeTwo
{
    // Represents a Vampire student in the Fangs house
    public class Vampire : Student
    {
        // Constructor sets name, age, and assigns to Fangs house
        public Vampire(string name, int age) : base(name, age, House.Fangs) { }

        // Vampire's special ability
        public override void UseAbility()
        {
            Console.WriteLine($"{Name} shows sharp teeth and bites into the night!");
        }
    }
}
