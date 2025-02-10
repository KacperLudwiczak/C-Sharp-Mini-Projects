namespace Math_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== MATH CLASS EXAMPLES ===");

            // Mathematical Constants
            Console.WriteLine("\n=== MATHEMATICAL CONSTANTS ===");
            Console.WriteLine($"PI: {Math.PI}"); // Value of π (3.14159...)
            Console.WriteLine($"E: {Math.E}");   // Euler's number (2.71828...)

            // Absolute Value
            Console.WriteLine("\n=== ABSOLUTE VALUE ===");
            Console.WriteLine($"Math.Abs(-10): {Math.Abs(-10)}"); // Returns 10 (absolute value)

            // Maximum and Minimum
            Console.WriteLine("\n=== MAX & MIN ===");
            Console.WriteLine($"Math.Max(10, 20): {Math.Max(10, 20)}"); // Returns the maximum value
            Console.WriteLine($"Math.Min(10, 20): {Math.Min(10, 20)}"); // Returns the minimum value

            // Rounding Functions
            Console.WriteLine("\n=== ROUNDING FUNCTIONS ===");
            Console.WriteLine($"Math.Round(4.7): {Math.Round(4.7)}"); // Rounds to the nearest integer (5)
            Console.WriteLine($"Math.Round(4.3): {Math.Round(4.3)}"); // Rounds to the nearest integer (4)
            Console.WriteLine($"Math.Round(4.75, 1): {Math.Round(4.75, 1)}"); // Rounds to 1 decimal place (4.8)
            Console.WriteLine($"Math.Floor(4.9): {Math.Floor(4.9)}"); // Rounds down to the nearest whole number (4)
            Console.WriteLine($"Math.Ceiling(4.1): {Math.Ceiling(4.1)}"); // Rounds up to the nearest whole number (5)
            Console.WriteLine($"Math.Truncate(4.9): {Math.Truncate(4.9)}"); // Removes decimal part, keeps integer (4)

            // Exponents and Logarithms
            Console.WriteLine("\n=== EXPONENTS & LOGARITHMS ===");
            Console.WriteLine($"Math.Pow(2, 3) (2^3): {Math.Pow(2, 3)}"); // Calculates 2^3 (8)
            Console.WriteLine($"Math.Sqrt(25): {Math.Sqrt(25)}"); // Square root of 25 (5)
            Console.WriteLine($"Math.Exp(1) (e^1): {Math.Exp(1)}"); // e^1 (2.718)
            Console.WriteLine($"Math.Log(100) (Natural log): {Math.Log(100)}"); // Natural log (ln 100)
            Console.WriteLine($"Math.Log10(100) (Base 10 log): {Math.Log10(100)}"); // Log base 10 of 100 (2)

            // Trigonometric Functions (Radians)
            Console.WriteLine("\n=== TRIGONOMETRIC FUNCTIONS (RADIANS) ===");
            Console.WriteLine($"Math.Sin(Math.PI / 2): {Math.Sin(Math.PI / 2)}"); // Sine of 90 degrees (1)
            Console.WriteLine($"Math.Cos(Math.PI): {Math.Cos(Math.PI)}"); // Cosine of 180 degrees (-1)
            Console.WriteLine($"Math.Tan(Math.PI / 4): {Math.Tan(Math.PI / 4)}"); // Tangent of 45 degrees (1)

            // Trigonometric Functions (Degrees)
            Console.WriteLine("\n=== TRIGONOMETRIC FUNCTIONS (DEGREES) ===");
            double angle = 45; // Define angle in degrees
            double radians = angle * (Math.PI / 180); // Convert degrees to radians
            Console.WriteLine($"Sin(45°): {Math.Sin(radians)}"); // Compute sine of 45 degrees
            Console.WriteLine($"Cos(45°): {Math.Cos(radians)}"); // Compute cosine of 45 degrees
            Console.WriteLine($"Tan(45°): {Math.Tan(radians)}"); // Compute tangent of 45 degrees

            // Inverse Trigonometric Functions
            Console.WriteLine("\n=== INVERSE TRIGONOMETRIC FUNCTIONS ===");
            Console.WriteLine($"Math.Asin(0.5): {Math.Asin(0.5)}"); // Arcsine of 0.5 (returns radians)
            Console.WriteLine($"Math.Acos(0.5): {Math.Acos(0.5)}"); // Arccosine of 0.5 (returns radians)
            Console.WriteLine($"Math.Atan(1): {Math.Atan(1)}"); // Arctangent of 1 (returns radians)

            // Hyperbolic Functions
            Console.WriteLine("\n=== HYPERBOLIC FUNCTIONS ===");
            Console.WriteLine($"Math.Sinh(1): {Math.Sinh(1)}"); // Hyperbolic sine of 1
            Console.WriteLine($"Math.Cosh(1): {Math.Cosh(1)}"); // Hyperbolic cosine of 1
            Console.WriteLine($"Math.Tanh(1): {Math.Tanh(1)}"); // Hyperbolic tangent of 1

            // Random Number Generation
            Console.WriteLine("\n=== RANDOM NUMBER GENERATION ===");
            Random rand = new Random(); // Create Random object
            Console.WriteLine($"Random integer (0-100): {rand.Next(0, 100)}"); // Generates random number between 0 and 100
            Console.WriteLine($"Random double (0-1): {rand.NextDouble()}"); // Generates random double between 0 and 1

            // Sign Function
            Console.WriteLine("\n=== SIGN FUNCTION ===");
            Console.WriteLine($"Math.Sign(-50): {Math.Sign(-50)}"); // Returns -1 (negative)
            Console.WriteLine($"Math.Sign(50): {Math.Sign(50)}"); // Returns 1 (positive)
            Console.WriteLine($"Math.Sign(0): {Math.Sign(0)}"); // Returns 0 (zero)

            Console.WriteLine("\n=== PROGRAM END ===");
            Console.ReadKey(); // Wait for user input before closing
        }
    }
}
