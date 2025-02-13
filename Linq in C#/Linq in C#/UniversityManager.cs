using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_in_C_
{
    internal class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        // constructor
        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            //Let's add some Universities
            universities.Add(new University { Id = 1, Name = "Yale" });
            universities.Add(new University { Id = 2, Name = "Beijing Tech" });

            //Let's add some Students
            students.Add(new Student { Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Toni", Gender = "male", Age = 21, UniversityId = 1 });
            students.Add(new Student { Id = 3, Name = "Frank", Gender = "male", Age = 22, UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "Leyla", Gender = "female", Age = 19, UniversityId = 2 });
            students.Add(new Student { Id = 5, Name = "James", Gender = "trans-gender", Age = 25, UniversityId = 2 });
            students.Add(new Student { Id = 6, Name = "Linda", Gender = "female", Age = 22, UniversityId = 2 });
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;

            Console.WriteLine("Male - Students: ");
            foreach (Student student in maleStudents)
            {
                student.Print();
            }
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;

            Console.WriteLine("Female - Students: ");
            foreach (Student student in femaleStudents)
            {
                student.Print();
            }
        }

        public void SortStudentsByAge()
        {
            var sortedStudents = from student in students orderby student.Age select student;

            Console.WriteLine("Students sorted by Age: ");
            foreach (Student student in sortedStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromBeijingTech()
        {
            IEnumerable<Student> bjtStudents = from student in students
                                               join university in universities on student.UniversityId equals university.Id // Connect two classes
                                               where university.Name == "Beijing Tech"
                                               select student;

            Console.WriteLine("Students from Beijing Tech: ");
            foreach (Student student in bjtStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromThatUni(int Id)
        {
            IEnumerable<Student> myStudents = from student in students
                                              join university in universities on student.UniversityId equals university.Id
                                              where university.Id == Id
                                              select student;

            Console.WriteLine($"Students from that uni {Id}.");
            foreach (Student student in myStudents)
            {
                student.Print();
            }
        }

        public void StudentAndUniversityNameCollection()
        {
            var newCollection = from student in students
                                join university in universities on student.UniversityId equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, UniversityName = university.Name };

            Console.WriteLine("New Collection: ");
            foreach (var col in newCollection)
            {
                Console.WriteLine($"Student {col.StudentName} from University {col.UniversityName}.");
            }
        }
    }
}
