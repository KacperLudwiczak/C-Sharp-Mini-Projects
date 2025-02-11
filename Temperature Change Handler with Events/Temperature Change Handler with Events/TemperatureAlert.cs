using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Change_Handler_with_Events
{
    // Define the subscriber class which reacts to the event.
    internal class TemperatureAlert
    {
        // Method that handles the event and prints a message to the console.
        public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"Alert: temperature is {e.Temperature} sender is {sender}");
        }
    }
}
