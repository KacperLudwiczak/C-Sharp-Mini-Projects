using System.IO;

namespace Dictionaries_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // key - value
            // declaring and initializing a Dictionary
            Dictionary<int, string> employees = new Dictionary<int, string>();

            // adding Items to a Dictionary
            employees.Add(101, "John Doe");
            employees.Add(102, "Bob Smith");
            employees.Add(103, "Rob Smith");
            employees.Add(104, "Flob Smith");
            employees.Add(105, "Dob Smith");

            // access items in a dictionary
            string name = employees[101];
            Console.WriteLine(name);

            // update data in a dictionary
            employees[102] = "Tom Lee";

            // remove an item from a dictionary
            employees.Remove(101);

            // Iterating over a dictionary
            foreach (KeyValuePair<int, string> employee in employees)
            {
                Console.WriteLine($"ID: {employee.Key}, Name: {employee.Value}");
            }

            // check if there is a specific key, if not ad a value to it
            if (!employees.ContainsKey(104))
            {
                employees.Add(104, "Mike Jike");
            }
            /*
           int counter = 101;
           while (employees.ContainsKey(counter))
           {
               counter++;
           }
           employees.Add(counter, "Jay Christ");
           */

            bool added = employees.TryAdd(102, "Michal Brims");
            if (!added)
            {
                Console.WriteLine("Employee with the id of 102 already exists.");
            }

            // dictionary using class Employee
            Dictionary<int, Employee> employees2 = new Dictionary<int, Employee>();

            employees2.Add(1, new Employee("Joey Does", 35, 100000));
            employees2.Add(2, new Employee("Tom Doesnt", 25, 200000));
            employees2.Add(3, new Employee("John Wasnt", 45, 80000));
            employees2.Add(4, new Employee("Ted Will", 15, 50000));

            foreach (var item in employees2)
            {
                Console.WriteLine($"ID: {item.Key} named: {item.Value.Name}" +
                    $" earns {item.Value.Salary}" +
                    $" and is {item.Value.Age} years old!");
            }

            // declare and initialize the dictionary with keys as string
            var codes = new Dictionary<string, string>
            {
                ["NY"] = "New York",
                ["CA"] = "California",
                ["TX"] = "Texas"
            };

            if (codes.TryGetValue("NY", out string state))
            {
                Console.WriteLine(state);
            }

            foreach (var item in codes)
            {
                Console.WriteLine($"The statecode is {item.Key}" +
                    $" and the state name is {item.Value}");
            }

            // declare and initialize the dictionary with list
            Dictionary<string, List<int>> myList = new Dictionary<string, List<int>>();

            // adding a key-value pair
            myList["key"] = new List<int> { 1, 2, 3 };

            // retrieve and print the values
            if (myList.ContainsKey("key"))
            {
                Console.WriteLine("Numbers from the list: ");
                foreach (int number in myList["key"])
                {
                    Console.Write(number + " ");
                }
            }

            // dictionary using class Student
            Dictionary<string, Student> students = new Dictionary<string, Student>();
            students.Add("1", new Student(1, "John", 85));
            students.Add("2", new Student(2, "Alice", 90));
            students.Add("3", new Student(3, "Bob", 78));
            foreach (var student in students.Values)
            {
                Console.WriteLine($"\nName: {student.Name}, Id: {student.Id}, Grade: {student.Grade}");
            }

            Console.ReadKey();
        }
    }
}

/*
Why use this Dictionary instead of an array
Using a `Dictionary<int, Employee>` over a simple array of `Employee` objects offers several key advantages, 
particularly in scenarios requiring efficient data access, unique identifiers, and non-sequential operations. 
Here's why you might prefer a dictionary in the context provided by your example:

1. Key-based Access
A dictionary allows you to access elements using a key, which in this case is an integer representing an employee ID. 
This provides an efficient way to directly access specific employees without iterating over the entire collection. 
For example, fetching an employee by their ID is an O(1) operation in a dictionary, which is much faster than searching an array.
Employee emp = employees[2];  // Instantly get the employee with ID 2

2. Handling Non-Sequential and Sparse Data
Dictionaries do not require contiguous or sequential keys. You can have employee IDs like 100, 500, 1000 
without needing to store empty spaces between them, which would be the case in an array. 
This makes dictionaries more memory efficient for sparse data.

3. Flexibility in Modifying the Collection
Adding or removing entries in a dictionary is efficient and does not require shifting elements, 
as would be necessary in an array if you're adding or removing elements in positions other than the end. 
This can be particularly useful in dynamic scenarios where the employee data is frequently updated or reorganized.
employees.Add(5, new Employee("John Comes", 30, 110000));
employees.Remove(4);  // Remove employee with ID 4

4. Uniqueness of Keys
The dictionary ensures that each key is unique. This automatically enforces that no two employees can have the same ID, 
which can help prevent data integrity issues that might occur with arrays if not manually handled.

5. Descriptive Code and Maintenance
Using dictionaries can make the code more descriptive and easier to understand, as keys can provide meaningful identifiers for accessing data. 
This can simplify maintenance and enhance readability, making the codebase easier to manage.

6. Performance
For large datasets, dictionaries offer significant performance advantages in terms of lookup, add, and delete operations compared to arrays, 
especially when the dataset grows, as they do not degrade in performance based on the size of the data set.

Example Use Case
Imagine an HR system where you need to frequently access, update, or remove employee records based on their ID, and where employee IDs are not sequential. 
A dictionary provides a more efficient, flexible, and robust solution compared to an array.

In summary, while arrays are suitable for simple, ordered collections that are accessed sequentially, 
dictionaries provide superior performance and flexibility for accessing data via unique keys, 
handling sparse data, and performing efficient insertions and deletions. 
This makes dictionaries especially suited for applications like databases, caching solutions, 
and any context where quick lookup and data integrity are crucial.
*/
