string question1 = "What is the capital of Poland?";
string answer1 = "Warsaw";

string question2 = "What is the 3+3?";
string answer2 = "6";

string question3 = "What color do you get by mixing blue and yellow?";
string answer3 = "green";

int score = 0;

Console.WriteLine(question1);
string userAnswer1 = Console.ReadLine();
if (userAnswer1.Trim().ToLower() == answer1.ToLower())
{
    Console.WriteLine("Correct!");
    score++;
}
else
{
    Console.WriteLine($"Wrong. Correct answer is {answer1}");
}

Console.WriteLine(question2);
string userAnswer2 = Console.ReadLine();
if (userAnswer2.Trim() == answer2)
{
    Console.WriteLine("Correct!");
    score++;
}
else
{
    Console.WriteLine($"Wrong. Correct answer is {answer2}");
}

Console.WriteLine(question3);
string userAnswer3 = Console.ReadLine();
if (userAnswer3.Trim().ToLower() == answer3.ToLower())
{
    Console.WriteLine("Correct!");
    score++;
}
else
{
    Console.WriteLine($"Wrong. Correct answer is {answer3}");
}

Console.WriteLine($"Quiz comleted! Your score is {score}/3.");
if (score == 3)
{
    Console.WriteLine("Excellent! You got all the answers right!");
}
else if (score > 0)
{
    Console.WriteLine("Good job! Keep learning!");
}
else
{
    Console.WriteLine("Try again.");
}

Console.ReadKey();
