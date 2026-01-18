using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NevermoreSchoolTakeTwo
{
    // Abstract base class for all students
    public abstract class Student
    {
        public string Name { get; }
        public int Age { get; }
        public House House { get; }

        // Constructor sets name, age, and house
        protected Student(string name, int age, House house)
        {
            Name = name;
            Age = age;
            House = house;
        }

        // Each student type must implement their own ability
        public abstract void UseAbility();
    }
}
