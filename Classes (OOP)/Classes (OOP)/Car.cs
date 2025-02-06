using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes__OOP_
{
    // internal, means that it can only be accessed from within the same assembly (same program)
    internal class Car
    {
        // member variable (backing field), private hides the variable from other classes
        private string _brand = ""; 
        private string _model = "";
        private bool _isLuxury;

        // static field
        public static int NumberOfCars = 0;

        // property, it is for protected the member variable against changes, when is only get is for read only, when is only set is for write only
        public string Brand { 
            get
            {
                if (_isLuxury)
                {
                    return $"{_brand} - Luxury Edtion";
                }
                else
                {
                    return _brand;
                }
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered nothing.");
                    _brand = "default brand";
                }
                else
                {
                    _brand = value;
                }

            }
        }
        public string Model { get => _model; set => _model = value; }
        public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        // constructor, has the same name as class, it don't have a return type, it is called every time when a new object of "Car" is created
        public Car(string brand, string model, bool isLuxury) {
            NumberOfCars++;
            Brand = brand;
            Model = model;
            IsLuxury = isLuxury;
            
            Console.WriteLine($"The {Brand} of the model {Model} has been created.");
        }

        // constructor without parameters
        public Car()
        {
            NumberOfCars++;
            Console.WriteLine($"No information here.");
        }

        // method (a method outside a class is a funtion), public - we can access from other class (private - we can't), void - no return value,
        // method Drive, no static method, so outside its own class it can only be called on an object (Drive method can only be called on an object of class Car), 
        // and be called in its class (in class Car)
        public void Drive()
        {
            Console.WriteLine($"I'm driving {Brand}.");
        }

        // static method, a method that we can called even when we didn't create an object of class Car
        public static void MyStaticMethod()
        {
            Console.WriteLine("Static method.");
        }
    }
}
