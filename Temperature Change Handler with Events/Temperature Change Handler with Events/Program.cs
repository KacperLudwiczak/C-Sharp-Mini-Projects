namespace Temperature_Change_Handler_with_Events
{
    // Define the delegate that will be used for the event
    public delegate void TemperatureChangeHandler(string message);
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instances of TemperatureMonitor and TemperatureAlert.
            TemperatureMonitor monitor = new TemperatureMonitor();
            TemperatureAlert alert = new TemperatureAlert();

            // Subscribe to the temperature changed event.
            monitor.TemperatureChanged += alert.OnTemperatureChanged;

            // Set the alert temperature
            monitor.Temperature = 20;
            Console.WriteLine("Please enter the temperature");
            monitor.Temperature = int.Parse(Console.ReadLine());

            Console.ReadKey();
        }
    }
}

// Other example
/*
namespace Coding.Exercise
{
    // Define the delegate for the event
    public delegate void StockPriceChangedHandler(string message);

    // Define the Stock class which includes the event system
    public class Stock
    {
        // Declare the event using the delegate
        public event StockPriceChangedHandler OnStockPriceChanged;

        // Private field to store the stock price
        private decimal _price;

        // Private field to store the threshold
        private decimal _threshold;

        // Property to get and set the stock price
        public decimal Price
        {
            get { return _price; }
            set
            {
                _price = value;
                Console.WriteLine($"Current Stock Price: {_price}");
                
                // Raise the event if the price drops below the threshold
                if (_price < _threshold)
                {
                    RaiseStockPriceChangedEvent("Stock Alert: Stock price is below threshold!");
                }
            }
        }

        // Property to get and set the alert threshold
        public decimal Threshold
        {
            get { return _threshold; }
            set
            {
                _threshold = value;
                Console.WriteLine($"Alert Threshold Set: {_threshold}");
            }
        }

        // Method to raise the stock price changed event
        protected virtual void RaiseStockPriceChangedEvent(string message)
        {
            // Invoke the event
            OnStockPriceChanged?.Invoke(message);
        }
    }

    // Define the subscriber class which reacts to the event
    public class StockAlert
    {
        // Method that handles the event and prints a message to the console
        public void OnStockPriceChanged(string message)
        {
            Console.WriteLine(message);
        }
    }

    // Program class to simulate the stock price changes and test the event system
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Stock and StockAlert
            Stock stock = new Stock();
            StockAlert alert = new StockAlert();

            // Subscribe to the stock price changed event
            stock.OnStockPriceChanged += alert.OnStockPriceChanged;

            // Set the alert threshold
            stock.Threshold = 120;

            // Simulate stock price changes
            stock.Price = 150; // No alert
            stock.Price = 130; // No alert
            stock.Price = 110; // Alert triggered

            // Wait for user input to close the console
            Console.ReadLine();
        }
    }
}
*/