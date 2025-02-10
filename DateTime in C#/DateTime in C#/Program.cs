namespace DateTime_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime birthday = new DateTime(2001, 5, 2);
            Console.WriteLine($"My birthday is {birthday}.");

            Console.WriteLine("=== CREATING DateTime INSTANCES ===");
            DateTime dt1 = new DateTime(); // Default
            DateTime dt2 = default(DateTime); // Default
            Console.WriteLine($"Default DateTime: {dt1}");
            Console.WriteLine($"Default DateTime (Using default): {dt2}");

            DateTime dt3 = new DateTime(2024, 2, 10);
            DateTime dt4 = new DateTime(2024, 2, 10, 14, 30, 0);
            DateTime dt5 = new DateTime(2024, 2, 10, 14, 30, 45, 500);
            Console.WriteLine($"Specific DateTime: {dt3}");
            Console.WriteLine($"Specific DateTime with Time: {dt4}");
            Console.WriteLine($"Specific DateTime with Milliseconds: {dt5}");

            DateTime now = DateTime.Now;
            DateTime utcNow = DateTime.UtcNow;
            DateTime today = DateTime.Today;
            Console.WriteLine($"Current DateTime: {now}");
            Console.WriteLine($"Current UTC DateTime: {utcNow}");
            Console.WriteLine($"Current Date without Time: {today}");

            Console.WriteLine("\n=== PARSING DateTime FROM STRING ===");
            DateTime dt6 = DateTime.Parse("2024-02-10 14:30:00");
            DateTime dt7 = DateTime.ParseExact("10/02/2024", "dd/MM/yyyy", null);
            Console.WriteLine($"Parsed DateTime: {dt6}");
            Console.WriteLine($"Parsed with Exact Format: {dt7}");

            Console.WriteLine("\n=== MANIPULATING DateTime ===");
            DateTime futureDate = now.AddDays(5);
            DateTime pastDate = now.AddYears(-2);
            Console.WriteLine($"5 Days Later: {futureDate}");
            Console.WriteLine($"2 Years Ago: {pastDate}");

            TimeSpan difference = futureDate - pastDate;
            Console.WriteLine($"Difference in Days: {difference.TotalDays}");

            Console.WriteLine("\n=== GETTING DateTime COMPONENTS ===");
            Console.WriteLine($"Year: {now.Year}");
            Console.WriteLine($"Month: {now.Month}");
            Console.WriteLine($"Day: {now.Day}");
            Console.WriteLine($"Hour: {now.Hour}");
            Console.WriteLine($"Minute: {now.Minute}");
            Console.WriteLine($"Second: {now.Second}");
            Console.WriteLine($"Millisecond: {now.Millisecond}");
            Console.WriteLine($"Day of the Week: {now.DayOfWeek}");
            Console.WriteLine($"Day of the Year: {now.DayOfYear}");

            Console.WriteLine("\n=== FORMATTING DateTime ===");
            Console.WriteLine($"Long Date: {now.ToLongDateString()}");
            Console.WriteLine($"Short Date: {now.ToShortDateString()}");
            Console.WriteLine($"Long Time: {now.ToLongTimeString()}");
            Console.WriteLine($"Short Time: {now.ToShortTimeString()}");
            Console.WriteLine($"Custom Format: {now.ToString("yyyy-MM-dd HH:mm:ss")}");
            Console.WriteLine($"Another Custom Format: {now.ToString("dddd, MMMM dd yyyy")}");

            Console.WriteLine("\n=== COMPARING DateTime ===");
            bool isEqual = dt3 == dt4;
            bool isBefore = dt3 < dt4;
            bool isAfter = dt3 > dt4;
            Console.WriteLine($"Is Equal: {isEqual}");
            Console.WriteLine($"Is Before: {isBefore}");
            Console.WriteLine($"Is After: {isAfter}");
            Console.WriteLine($"Comparison Result: {dt3.CompareTo(dt4)}");

            Console.WriteLine("\n=== MIN & MAX DateTime ===");
            Console.WriteLine($"Min DateTime: {DateTime.MinValue}");
            Console.WriteLine($"Max DateTime: {DateTime.MaxValue}");

            Console.WriteLine("\n=== WORKING WITH TIME ZONES ===");
            TimeZoneInfo localZone = TimeZoneInfo.Local;
            TimeZoneInfo utcZone = TimeZoneInfo.Utc;
            TimeZoneInfo specificZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            DateTime estTime = TimeZoneInfo.ConvertTime(now, specificZone);
            Console.WriteLine($"Local Time Zone: {localZone}");
            Console.WriteLine($"UTC Time Zone: {utcZone}");
            Console.WriteLine($"Eastern Time: {estTime}");

            Console.WriteLine("\n=== DateTimeOffset (Handles Time Zones) ===");
            DateTimeOffset dto = DateTimeOffset.Now;
            DateTimeOffset utcDto = DateTimeOffset.UtcNow;
            Console.WriteLine($"DateTimeOffset Now: {dto}");
            Console.WriteLine($"DateTimeOffset UTC: {utcDto}");
            Console.WriteLine($"Offset: {dto.Offset}");
            Console.WriteLine($"UTC DateTime from Offset: {dto.UtcDateTime}");

            Console.WriteLine("\n=== PROGRAM END ===");

            Console.ReadKey();
        }
    }
}
