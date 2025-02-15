using System.Text;

namespace Generics_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<int> intBox = new Box<int>();
            intBox.Content = 1;
            Console.WriteLine(intBox.Log());

            Box<string> stringBox = new Box<string>();
            stringBox.Content = "string";
            Console.WriteLine(stringBox.Log());

            TwoGenerics<int, string> twoGenerics = new TwoGenerics<int, string>(100, "string");
            twoGenerics.Display();

            // Task
            var emailTask = new EmailTask()
            {
                Message = "Hello, this is a test email",
                Recipient = "example@exanple.com"
            };
            var reportTask = new ReportTask()
            {
                ReportName = "Annual Report",
            };
            var emailProcessor = new TaskProcessor<EmailTask, string>(emailTask);
            var reportProcessor = new TaskProcessor<ReportTask, string>(reportTask);
            Console.WriteLine(emailProcessor.Execute());
            Console.WriteLine(reportProcessor.Execute());                     

            // Generic Class Example
            GenericClass<int> intObj = new GenericClass<int>(100);
            Console.WriteLine($"Generic Class Value: {intObj.GetValue()}");

            // Generic Method Example
            GenericMethodExample example = new GenericMethodExample();
            example.ShowType("Hello Generics");
            example.ShowType(12345);

            // Generic Interface Implementation
            IGenericInterface<string> strInterface = new GenericInterfaceImpl<string>("Generic Interface Example");
            Console.WriteLine($"Generic Interface Value: {strInterface.GetData()}");

            // Constrained Generic Example
            ConstrainedGeneric<StringBuilder> constrained = new ConstrainedGeneric<StringBuilder>();
            Console.WriteLine($"Created Instance: {constrained.CreateInstance().GetType()}");

            // Generic Delegate Example
            GenericDelegate<int> square = x => x * x;
            Console.WriteLine($"Square of 5: {square(5)}");

            // 6. Generic Collections
            // The use of generic List<T> for type safety and flexibility.
            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            Console.WriteLine("Generic Collection (List<string>): " + string.Join(", ", names));

            // Action<T> Delegate
            // Action<T> is a built -in delegate that represents a method that takes one or more input parameters but does not return a value.
            // It is commonly used when you need to perform an operation without returning a result.
            Action<string> printMessage = message => Console.WriteLine($"Message: {message}");
            printMessage("Hello from Action!");

            // Func<T, TResult> Delegate
            // Func<T, TResult> is a delegate that takes one or more input parameters and returns a value.
            // The last generic type parameter in Func<> represents the return type.
            Func<int, int, int> addNumbers = (a, b) => a + b;
            Console.WriteLine($"Sum: {addNumbers(10, 20)}");

            // Predicate<T> Delegate
            // Predicate<T> is a delegate that takes a single input parameter and returns a bool.
            // It is used to test a condition, often in filtering operations.
            Predicate<int> isEven = number => number % 2 == 0;
            Console.WriteLine($"Is 10 even? {isEven(10)}");
            Console.WriteLine($"Is 15 even? {isEven(15)}");

            Console.ReadKey();
        }
    }

    // 1. Generic Class
    // A class that can store a value of any type.
    public class GenericClass<T>
    {
        private T _value;

        public GenericClass(T value)
        {
            _value = value;
        }

        public T GetValue()
        {
            return _value;
        }
    }

    // 2. Generic Method
    // A method that works with any data type.
    public class GenericMethodExample
    {
        public void ShowType<T>(T input)
        {
            Console.WriteLine($"Type: {typeof(T)}, Value: {input}");
        }
    }

    // 3. Generic Interface
    // Interfaces that use generics to define contract flexibility.
    public interface IGenericInterface<T>
    {
        T GetData();
    }

    public class GenericInterfaceImpl<T> : IGenericInterface<T>
    {
        private T _data;

        public GenericInterfaceImpl(T data)
        {
            _data = data;
        }

        public T GetData()
        {
            return _data;
        }
    }

    // 4. Generic Constraint
    // Ensuring generic types meet specific requirements.
    // (where T must be a class and have a parameterless constructor)
    public class ConstrainedGeneric<T> where T : class, new()
    {
        public T CreateInstance()
        {
            return new T();
        }
    }

    // 5. Generic Delegate
    // Allowing type-safe, generic function pointers.
    public delegate T GenericDelegate<T>(T param);
}
