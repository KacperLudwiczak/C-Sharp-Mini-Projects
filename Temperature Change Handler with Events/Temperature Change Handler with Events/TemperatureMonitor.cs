using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Change_Handler_with_Events
{
    // Define the TemperatureMonitor class which includes the event system.
    internal class TemperatureMonitor
    {
        // Declare the EventHandler.
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

        // Declare the event using the delegate.
        // public event TemperatureChangeHandler OnTemperatureChanged;

        // Private field to store the temperature.
        private int _temperature;

        // Property to get and set the temperature.
        public int Temperature
        {
            get { return _temperature; }
            set
            {
                if (_temperature != value)
                {
                    _temperature = value;           
                    OnTemperatureChanged(new TemperatureChangedEventArgs(_temperature)); // RAISE EVENT!!!
                }
            }
        }
        // Method to raise the temperature changed event.
        protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
        {
            // Invoke the event.
            // Letting every subscriber know.
            TemperatureChanged?.Invoke(this, e);
        }
    }
}
