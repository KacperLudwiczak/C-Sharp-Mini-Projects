using System.Globalization;

Console.WriteLine("Enter first number: ");
string input1 = Console.ReadLine();
double userNumber1 = double.Parse(input1, CultureInfo.InvariantCulture);

Console.WriteLine("Enter second number: ");
string input2 = Console.ReadLine();
double userNumber2 = double.Parse(input2, CultureInfo.InvariantCulture);

Console.WriteLine("Choose operation (+, -, *, /): ");
char operation = Console.ReadLine()[0];

if (operation == '+')
{
    double sum = userNumber1 + userNumber2;
    sum = Math.Round(sum, 2);
    Console.WriteLine($"Sum of {userNumber1} and {userNumber2} is {sum}");
}
else if (operation == '-')
{
    double subtraction = userNumber1 - userNumber2;
    subtraction = Math.Round(subtraction, 2);
    Console.WriteLine($"Subtraction of {userNumber1} and {userNumber2} is {subtraction}");
}
else if (operation == '*')
{
    double multiplication = userNumber1 * userNumber2;
    multiplication = Math.Round(multiplication, 2);
    Console.WriteLine($"Multiplication of {userNumber1} and {userNumber2} is {multiplication}");
}
else if (operation == '/')
{
    if (userNumber2 != 0)
    {
        double division = (double)userNumber1 / userNumber2;
        division = Math.Round(division, 2);
        Console.WriteLine($"Division of {userNumber1} and {userNumber2} is {division}");
    }
    else
    {
        Console.WriteLine("Cannot divide by zero.");
    }
}
else
{
    Console.WriteLine("Invalid operation.");
}

Console.ReadKey();