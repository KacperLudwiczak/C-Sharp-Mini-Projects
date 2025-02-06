namespace Weather_Station_Simulator_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate: ");
            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-15, 45);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
            }

            // int maxTemperature = temperature.Max();
            // int minTemperature = temperature.Min();
            // int minTemperature = MyMinTemperatureMethod(temperature);
            // string mostCommonCondition = MostCommonCondition(weatherConditions);
            // double averageTemperature = CalculateAverage(temperature);

            Console.WriteLine($"Average temperature is {CalculateAverage(temperature)}.");
            Console.WriteLine($"Max temperature was {temperature.Max()}.");
            Console.WriteLine($"Min temperature was {MyMinTemperatureMethod(temperature)}.");
            Console.WriteLine($"Most common condition is {MostCommonCondition(weatherConditions)}.");

            Console.ReadKey();
        }

        static double CalculateAverage(int[] temperature)
        {
            double sum = 0;

            foreach (int i in temperature)
            {
                sum += i;
            }

            double average = sum / temperature.Length;

            return average;
        }

        static string MostCommonCondition(string[] conditions)
        {
            int count = 0;
            string mostCommon = conditions[0];

            for (int i = 0; i < conditions.Length; i++)
            {
                int temperatureConditions = 0;
                for (int j = 0; j < conditions.Length; j++)
                {
                    if (conditions[j] == conditions[i])
                    {
                        temperatureConditions++;
                    }
                }
                if (temperatureConditions > count)
                {
                    count = temperatureConditions;
                    mostCommon = conditions[i];
                }
            }
            return mostCommon;
        }

        static int MyMinTemperatureMethod(int[] temperature)
        {
            int minTemperature = temperature[0];

            foreach (int temp in temperature)
            {
                if (temp < minTemperature)
                {
                    minTemperature = temp;
                }
            }
            return minTemperature;
        }
    }
}
