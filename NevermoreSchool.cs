using System;
using System.Collections.Generic;
using System.Linq;

namespace NevermoreSchoolTakeTwo
{
    // Manages students, admissions, and events at Nevermore School
    public class NevermoreSchool
    {
        private readonly List<Student> students = new List<Student>();

        public event EventHandler<SchoolEventArgs> StudentAdded;
        public event EventHandler<SchoolEventArgs> AbilityUsed;

        // Admit a new student, checking for duplicates and age
        public void AdmitStudent(Student student)
        {
            if (students.Any(s => s.Name.Equals(student.Name, StringComparison.OrdinalIgnoreCase)))
                throw new DuplicateNameException($"Duplicate student: {student.Name}");

            if (student.Age < 10)
                throw new InvalidAgeException($"{student.Name} is too young!");

            students.Add(student);
            StudentAdded?.Invoke(this, new SchoolEventArgs($"New student admitted: {student.Name} of {student.House}"));
        }

        // Trigger a student's special ability by name
        public void TriggerAbility(string name)
        {
            var student = students.FirstOrDefault(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (student == null)
            {
                Console.WriteLine($"No student found with the name {name}.");
                return;
            }

            student.UseAbility();
            AbilityUsed?.Invoke(this, new SchoolEventArgs($"{student.Name} used their ability."));
        }

        // Display all students grouped by house
        public void DisplayStudents()
        {
            foreach (var group in students.GroupBy(s => s.House))
            {
                Console.WriteLine($"\nHouse of {group.Key}:");
                foreach (var s in group)
                    Console.WriteLine($" - {s.Name}, {s.Age} years old");
            }
        }
    }
}
