using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Change_Handler_with_Events
{
    internal class TemperatureChangedEventArgs: EventArgs
    {
        // Property holding the temperature.
        public int Temperature { get; }

        // Constructor.
        public TemperatureChangedEventArgs(int temperature)
        {
            Temperature = temperature;
        }
    }
}
