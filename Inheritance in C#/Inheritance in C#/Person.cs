using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_in_C_
{
    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        // Base class constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Person constructor called");
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        /// <summary>Makes our object older!</summary>
        /// <param name="years">The parameter that indicates the amount of years the object should age</param>
        /// <returns>Returns the new age after aging/becoming older</returns>
        public int BecomeOlder(int years)
        {
            Age = Age + years;

            return Age;
        }
    }

    public class Employee : Person
    {
        public string JobTitle { get; private set; }
        public int EmployeeID { get; private set; }

        // Derived class constructor
        public Employee(string name, int age, string jobTitle, int employeeID)
            : base(name, age) // Calling the base class constructor
        {
            JobTitle = jobTitle;
            EmployeeID = employeeID;
            Console.WriteLine("Employee constructor called");
        }

        public void DisplayEmployeeInfo()
        {
            DisplayPersonInfo(); // Call method from base class
            Console.WriteLine($"Job Title: {JobTitle}, Employee ID: {EmployeeID}");
        }
    }

    public class Manager : Employee
    {
        public int TeamSize { get; private set; }

        public Manager(string name, int age, string jobTitle,
            int employeeID, int teamSize)
            : base(name, age, jobTitle, employeeID)
        {
            TeamSize = teamSize;
        }

        public void DisplayManagerInfo()
        {
            DisplayEmployeeInfo(); // Call method from base class
            Console.WriteLine($"Team Size: {TeamSize}");
        }
    }
}
