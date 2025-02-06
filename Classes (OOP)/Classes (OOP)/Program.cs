using Classes__OOP_;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Classes__OOP_
{   
    // Access Modifier internal
    internal class Program
    {
        static void Main(string[] args)
        {
            //// creating an object of the class Car (creating an instance of the class Car)
            // Car audi = new Car("Audi", "A6", false);
            // Car bmw = new Car("BMW", "X3", true);
            // Console.WriteLine($"Brand is {audi.Brand}.");
            // Console.WriteLine($"Brand is {bmw.Brand}.");

            // Console.WriteLine("Please enter the brand name");
            //// setting brand
            // audi.Brand = Console.ReadLine();
            //// getting brand
            // Console.WriteLine($"Brand is {audi.Brand}.");

            //// method Drive, no static method, so outside its own class it can only be called on an object (Drive method can only be called on an object of class Car), 
            //// and be called in its class (in class Car)
            // Car myAudi = new Car("Audi", "A6", false);
            // myAudi.Drive();
            // Car myBmw = new Car("BMW", "X3", true);
            // myBmw.Drive();

            //// static method, a method that we can called even when we didn't create an object of class Car (we don't need: new Car())
            // Car.MyStaticMethod();

            //// static field
            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car("BMW", "X3", true);
            //// accessing the public static variable NumberOfCars of the class Car
            Console.WriteLine($"Number of cars produced is {Car.NumberOfCars}.");

            //// constructor with only name
            // Customer tom = new Customer("Tom");
            //// constructor with all parameters
            // Customer ken = new Customer("Ken", "Baker Street 25", "+48 521 741 068");
            //// constructor with no parameters
            // Customer customer = new Customer();
            // Console.WriteLine($"Customer name is {tom.Name}.");
            // Console.WriteLine($"Customer name is {ken.Name}.");
            // Console.WriteLine($"Customer name is {customer.Name}.");

            // Console.WriteLine("Please enter the customer name");
            // customer.Name = Console.ReadLine();
            // Console.WriteLine($"Customer name is {customer.Name}.");

            //// method SetDetails
            // Customer myCustomer = new Customer();
            // myCustomer.SetDetails(name: "Ben", address: "Baker Street 35", contactNumber: "+48 621 951 318");
            // Console.WriteLine($"Customer name is {myCustomer.Name}. He lives at {myCustomer.Address}. And his contact is {myCustomer.ContactNumber}.");
            // Customer myCustomer2 = new Customer();
            // myCustomer2.SetDetails("Ted", "Baker Street 5");
            // Console.WriteLine($"Customer name is {myCustomer2.Name}. He lives at {myCustomer2.Address}. And his contact is {myCustomer2.ContactNumber}.");

            Console.ReadKey();
        }
    }
}

// In C#, the static keyword is used to declare members of a class that belong to the class itself rather than to any specific instance of the class.
// When you apply static to a class member, that member is shared among all instances of the class, and it can also be accessed without creating an instance of the class.
// This is a fundamental concept in many programming languages, including C#, and it helps in managing data and behavior that is common to the class, rather than to individual objects.

// Types of Static Members:

// 1. Static Fields: Used to store data that is shared among all instances of the class.
// For example, you might use a static field to count how many instances of a class have been created or to hold configuration information that applies to all objects of that type.

// 2. Static Methods: Methods that do not operate on instance data. These methods belong to the class itself and can only access other static members of the class.
// They are typically used for utility functions that do not require any object state from the class to perform their tasks.

// 3. Static Properties: Like static methods, these properties are related to the class, not to any instance.
// They can be used to control access to static data or to provide properties that apply globally to the class.

// 4.Static Constructors: A special type of constructor that initializes static members of the class.
// This constructor is called automatically and exactly once, before any static members are accessed or an instance of the class is created.

// 5.Static Classes: You can also declare an entire class as static.
// This is often done for utility classes where you want to group related static methods (like a mathematical utility class) without allowing instantiation of the class.

// Examples:

// Static Field and Method
// public class Car
// {
//    public static int NumberOfCars = 0;
//    public Car()
//    {
//        // Increment the static field value by one each time a new Car object is created.
//        NumberOfCars++;
//    }
//    public static void DisplayNumberOfCars()
//    {
//        Console.WriteLine($"Total cars: {NumberOfCars}");
//    }
// }
// In this example, NumberOfCars is a static field that tracks the number of Car instances created.
// DisplayNumberOfCars is a static method that displays this number.

// Both are accessed via the class name:

// Car car1 = new Car();
// Car car2 = new Car();
// Car.DisplayNumberOfCars(); // Output: Total cars: 2

//Static Class

// public static class Utilities
// {
//    public static int Add(int a, int b)
//    {
//        return a + b;
//    }
// }
// Here, Utilities is a static class that contains a static method Add.
// This method can be called without creating an instance of the class:
// int result = Utilities.Add(5, 10); // Output: 15

// Usage Considerations:

// 1. Memory Usage: Static members are allocated once and live for the duration of the application, which can be more memory-efficient for shared data.

// 2. Global State: Static members maintain a global state which can lead to issues with data consistency, especially in multithreaded scenarios.
// Care should be taken to manage access to static members, possibly using synchronisation mechanisms if needed.

// 3. Testing Challenges: Classes that use static members can be harder to test due to their persistent state across tests.
// This can be mitigated by using patterns such as dependency injection to abstract away static dependencies.

// Overall, static is a powerful keyword in C# that enables class-level functionality,
// making it suitable for scenarios where you need consistent behavior or data management that is common across all instances of a class.
