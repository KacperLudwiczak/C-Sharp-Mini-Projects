using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_in_C_
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int UniversityId { get; set; } // Foreign Key
        public void Print()
        {
            Console.WriteLine($"Student {Name} with Id {Id}, Gender {Gender} and Age {Age} from University with the Id {UniversityId}.");
        }
    }
}
