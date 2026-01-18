using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NevermoreSchoolTakeTwo
{
    // Entry point for the Nevermore School application
    internal class Program
    {
        static void Main(string[] args)
        {
            var school = new NevermoreSchool();

            // Subscribe to school events
            school.StudentAdded += (s, e) => Console.WriteLine(e.Message);
            school.AbilityUsed += (s, e) => Console.WriteLine($"[LOG] {e.Message}");

            try
            {
                // Admit students of different types
                school.AdmitStudent(new Vampire("Valerie", 16));
                school.AdmitStudent(new Werewolf("Wyatt", 17));
                school.AdmitStudent(new Psychic("Poppy", 15));
                school.AdmitStudent(new Spirit("Seraphina", 14));

                // Uncomment to test duplicate exception
                // school.AdmitStudent(new Vampire("Valerie", 17));

                // Trigger special abilities
                school.TriggerAbility("Wyatt");
                school.TriggerAbility("Poppy");

                // Show all students grouped by house
                school.DisplayStudents();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
