using System.Text.RegularExpressions;

namespace Regular_Expressions_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Defining a regular expression with a pattern
            Regex regex = new Regex(@"\d");

            // Test string
            string text1 = "Hi there 123";

            // Find hits
            MatchCollection hits = regex.Matches(text1);

            // Number of hits
            Console.WriteLine("{0} hits found:\n   {1}",
                              hits.Count,
                              text1);

            // Amount of hits
            foreach (Match aHit in hits)
            {
                GroupCollection groups = aHit.Groups;
                Console.WriteLine("'{0}' found at {1}",
                                  groups["word"].Value,
                                  groups[0].Index
                                 );
            }

            Console.WriteLine("Regular Expressions in C# Examples");

            // Example 1: Validating an Email Address
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            string email = "example@email.com";
            Console.WriteLine($"Is '{email}' a valid email? {Regex.IsMatch(email, emailPattern)}");

            // Example 2: Checking if a string contains a number
            string text = "This text contains the number 42.";
            string numberPattern = "\\d+";
            Console.WriteLine($"Does the text contain a number? {Regex.IsMatch(text, numberPattern)}");

            // Example 3: Extracting all numbers from a string
            Console.WriteLine("Extracted numbers:");
            foreach (Match match in Regex.Matches(text, numberPattern))
            {
                Console.WriteLine(match.Value);
            }

            // Example 4: Replacing multiple spaces with a single space
            string spacedText = "This   sentence   has    extra spaces.";
            string replacedText = Regex.Replace(spacedText, "\\s+", " ");
            Console.WriteLine("Before: " + spacedText);
            Console.WriteLine("After: " + replacedText);

            // Example 5: Validating a phone number (US Format: (123) 456-7890 or 123-456-7890)
            string phonePattern = @"^(\(\d{3}\)\s?|\d{3}-)\d{3}-\d{4}$";
            string phoneNumber = "(123) 456-7890";
            Console.WriteLine($"Is '{phoneNumber}' a valid phone number? {Regex.IsMatch(phoneNumber, phonePattern)}");

            // Example 6: Finding words that start with a specific letter (e.g., 'T')
            string wordPattern = "\bT\\w*";
            Console.WriteLine("Words starting with 'T':");
            foreach (Match match in Regex.Matches(text, wordPattern))
            {
                Console.WriteLine(match.Value);
            }

            // Character Escapes
            Console.WriteLine("Character Escapes:");
            Console.WriteLine("Bell character: " + Regex.IsMatch("Error!\u0007", "\a"));
            Console.WriteLine("Backspace: " + Regex.IsMatch("\b\b\b\b", "[\b]{3,}"));
            Console.WriteLine("Tab: " + Regex.IsMatch("item1\titem2\t", "(\\w+)\t"));
            Console.WriteLine("Carriage Return: " + Regex.IsMatch("\r\nThese are\ntwo lines.", "\r\n(\\w+)"));
            Console.WriteLine("Vertical Tab: " + Regex.IsMatch("\v\v\v", "[\v]{2,}"));
            Console.WriteLine("Form Feed: " + Regex.IsMatch("\f\f\f", "[\f]{2,}"));
            Console.WriteLine("New Line: " + Regex.IsMatch("\r\nThese are\ntwo lines.", "\r\n(\\w+)"));
            Console.WriteLine("Escape: " + Regex.IsMatch("\x001B", "\\e"));
            Console.WriteLine("Octal: " + Regex.IsMatch("a bc d", "\\w\040\\w"));
            Console.WriteLine("Hexadecimal: " + Regex.IsMatch("a bc d", "\\w\x20\\w"));
            Console.WriteLine("Control Character: " + Regex.IsMatch("\x0003", "\\cC"));
            Console.WriteLine("Unicode: " + Regex.IsMatch("a bc d", "\\w\u0020\\w"));

            // Character Classes
            Console.WriteLine("Character Classes:");
            Console.WriteLine("Single Character: " + Regex.IsMatch("gray", "[ae]"));
            Console.WriteLine("Negation: " + Regex.IsMatch("reign", "[^aei]"));
            Console.WriteLine("Character Range: " + Regex.IsMatch("AB123", "[A-Z]"));
            Console.WriteLine("Wildcard: " + Regex.IsMatch("nave", "a.e"));
            Console.WriteLine("Unicode Category: " + Regex.IsMatch("City Lights", "\\p{Lu}"));
            Console.WriteLine("Non-Unicode Category: " + Regex.IsMatch("City", "\\P{Lu}"));
            Console.WriteLine("Word Character: " + Regex.IsMatch("ID A1.3", "\\w"));
            Console.WriteLine("Non-Word Character: " + Regex.IsMatch("ID A1.3", "\\W"));
            Console.WriteLine("White Space: " + Regex.IsMatch("ID A1.3", "\\w\\s"));
            Console.WriteLine("Non-White Space: " + Regex.IsMatch("int __ctr", "\\s\\S"));
            Console.WriteLine("Digit: " + Regex.IsMatch("4 = IV", "\\d"));
            Console.WriteLine("Non-Digit: " + Regex.IsMatch("4 = IV", "\\D"));

            // Anchors
            Console.WriteLine("Anchors:");
            Console.WriteLine("Start of String: " + Regex.IsMatch("901-333-", "^\\d{3}"));
            Console.WriteLine("End of String: " + Regex.IsMatch("-901-333", "-\\d{3}$"));
            Console.WriteLine("Word Boundary: " + Regex.IsMatch("them theme", "\b\\w+\\s\\w+\b"));
            Console.WriteLine("Non-Word Boundary: " + Regex.IsMatch("end sends endure lender", "\\Bend\\w*\b"));

            // Quantifiers
            Console.WriteLine("Quantifiers:");
            Console.WriteLine("Zero or More: " + Regex.IsMatch("abcbc", "a.*c"));
            Console.WriteLine("One or More: " + Regex.IsMatch("been", "be+"));
            Console.WriteLine("Zero or One: " + Regex.IsMatch("rain", "rai?"));
            Console.WriteLine("Exact Matches: " + Regex.IsMatch("1,043.6", ",\\d{3}"));

            // Alternation
            Console.WriteLine("Alternation:");
            Console.WriteLine("Either/Or Matching: " + Regex.IsMatch("this is the day.", "th(e|is|at)"));

            Console.ReadKey();
        }
    }
}
