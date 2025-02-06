// Pobranie pierwszej liczby
Console.WriteLine("Enter the first number:");
if (!double.TryParse(Console.ReadLine(), out double userNumber1))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
    return;
}

// Pobranie drugiej liczby
Console.WriteLine("Enter the second number:");
if (!double.TryParse(Console.ReadLine(), out double userNumber2))
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
    return;
}

// Pobranie operacji
Console.WriteLine("Choose an operation: +, -, *, /");
string input = Console.ReadLine();
if (string.IsNullOrEmpty(input) || input.Length != 1)
{
    Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
    return;
}
char operation = input[0];

// Wykonanie operacji
double result;
switch (operation)
{
    case '+':
        result = userNumber1 + userNumber2;
        break;
    case '-':
        result = userNumber1 - userNumber2;
        break;
    case '*':
        result = userNumber1 * userNumber2;
        break;
    case '/':
        if (userNumber2 == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return;
        }
        result = userNumber1 / userNumber2;
        break;
    default:
        Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
        return;
}

// Zaokrąglanie wyniku
result = Math.Round(result, 2);

// Wyświetlenie wyniku
Console.WriteLine($"Result: {result}");

Console.ReadKey();