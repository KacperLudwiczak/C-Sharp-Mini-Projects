namespace Old_Style
{
    internal class Program
    {
        // This is a Filed (or instance variable)
        static int myResult;

        // Main method
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            // Validate user input
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                myResult = AddTwoValues(num, 10);
                Console.WriteLine($"The result is {myResult}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            Console.ReadKey();
        }

        static int AddTwoValues(int value1, int value2)
        {
           myResult = value1 + value2;
           return myResult;
        }

    }
}
