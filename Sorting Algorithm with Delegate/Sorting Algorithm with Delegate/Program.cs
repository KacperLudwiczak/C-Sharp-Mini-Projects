namespace Sorting_Algorithm_with_Delegate
{
    public delegate int Comparison<T> (T x, T y);
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = {
            new Person { Name = "Alice", Age = 30 },
            new Person { Name = "Bob", Age = 25 },
            new Person { Name = "Denis", Age = 36},
            new Person { Name = "Charlie", Age = 35 }
            };

            PersonSorter sorter = new PersonSorter();

            Console.WriteLine("Compare by age: ");
            sorter.Sort(people, CompareByAge);
            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name}, {person.Age}");
            }

            Console.WriteLine("Compare by name: ");
            sorter.Sort(people, CompareByName);
            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name}, {person.Age}");
            }

            Console.ReadKey();
        }

        static int CompareByAge(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }

        static int CompareByName(Person x, Person y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
