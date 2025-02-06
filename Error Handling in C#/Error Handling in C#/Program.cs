using System;
using System.Diagnostics;
using System.Threading.Channels;

namespace Error_Handling_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            try
            {
                Console.WriteLine("Please enter a number");
                int num1 = int.Parse(Console.ReadLine()); 
                int num2 = 2;
                result = num2 / num1;
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine("DONT DIVIDE BY ZERO!!! " + exception.Message);
                result = 10;
            }
            catch (FormatException exception)
            {
                Console.WriteLine("I TOLD YOU TO ENTER A NUMBER!" + exception.Message);
            }
            catch (OverflowException exception)
            {
                Console.WriteLine("NUMBER TOO HIGH!" + exception.Message);
            }
            // This a parent exception of all exception versions. It catch all errors which we did not take into account earlier while creating catch blocks.
            catch (Exception exception)
            {
                Console.WriteLine("Error: " + exception.Message);
                // This next line is only executed during "Debugging".
                Debug.WriteLine(exception.ToString());
            }
            finally
            {
                // Code to cleanup or finalize. Ideal for cleaning up resources, like closing file streams or database connections.
                Console.WriteLine("This always executes");
            }
            Console.WriteLine("Result: " + result);

            Console.WriteLine("Enter your age");
            GetUserAge(Console.ReadLine());

            Console.ReadKey();
        }

        static int GetUserAge(string input)
        {
            int age;
            if (!int.TryParse(input, out age))
            {
                throw new Exception("You didn't enter a valid age.");
            }
            if (age < 0 || age > 120)
            {
                throw new Exception("Your age must be between 0 and 120.");
            }
            return age;
        }

         /*
         What Does throw Do?
         The throw keyword in C# is used to indicate that a problem has occurred in your program.
         When you use throw, you're essentially saying "Hey, something went wrong here, and I can't handle it by myself." 
         You're creating an error on purpose, which is called an exception.

         Why use throw?       
         1. To Stop Bad Things from Happening: 
         If something in your program isn't right, like if a necessary file is missing or a number,
         that should never be zero is zero, using throw stops the program before any more damage can happen.         
         2. To Tell Other Parts of Your Program about the Problem: 
         Sometimes, one part of your program might not know how to fix a problem, but another part does. 
         By using throw, the first part can let the second part handle the issue.
         */
    }
}

/*
How to Handle Exceptions Properly

1. Use Specific Exceptions: 
Catch more specific exceptions rather than general ones to handle errors more precisely.

2. Use Finally for Cleanup: 
Always use a finally block if you need to clean up resources (like files or database connections), regardless of whether an exception occurred.

3. Log Exceptions: 
Always log exception details for debugging and operational purposes.

4. Avoid Exception Handling for Control Flow: 
Use exceptions for exceptional cases, not regular control flows.
*/