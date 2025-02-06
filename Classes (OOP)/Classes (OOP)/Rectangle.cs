using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassesApp
{
    internal class Rectangle
    {
        // In C#, const and readonly are two keywords used to define non-modifiable fields,
        // but they differ in terms of when they are initialized and their usage contexts.
        // Understanding the differences between these two can help in deciding which one
        // to use based on specific requirements.

        // declaration of field with const, it is the same for every new object
        public const int NumberOfCorners = 4;
        // declaration of field
        public readonly string Color = "Blue";

        // Readonly field: A unique identifier for each rectangle instance.
        private readonly string _id;

        public Rectangle(string color)
        {
            Color = color;
        }

        // Method to display the details of the rectangle
        public void DisplayDetails()
        {
            Console.WriteLine($"Color: {Color}, Width: {Width}, " +
                $"Height: {Height}, Area: {Area}, Number of Corners: {NumberOfCorners}");
        }


        public double Width { get; set; }
        public double Height { get; set; }

        // Computed property

        // Read Only Prop
        public double Area
        {
            get { return Width * Height; }
        }



    }
}
