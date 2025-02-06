using System;
using System.Linq;

namespace Collections_in_C___List_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaring a list and initializing
            List<string> colors = new List<string>();

            // adding items to the list
            colors.Add("blue");
            colors.Add("orange");
            colors.Add("green");
            colors.Add("red");
            colors.Add("pink");
            colors.Add("orange");
            colors.Add("yellow");
            Console.WriteLine("Current added items: ");
            foreach (string color in colors) 
            {
                Console.WriteLine(color);
            }

            // other version to create list and add itmes (it is used, when we know, how many and what items we want)
            List<string> colors2 =
            [
                "red",
                "blue",
                "green",
            ];
            Console.WriteLine("Other version of list and added itmes: ");
            foreach (string color in colors2)
            {
                Console.WriteLine(color);
            }


            // remove items from the list
            colors.Remove("pink"); // it delete the first pink item, not all pink items
            Console.WriteLine("Current added items, without pink: ");
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            // remove all orange items
            bool isDeletingSuccessful = colors.Remove("orange");
            while (isDeletingSuccessful) 
            {
                isDeletingSuccessful = colors.Remove("orange");
            }
            Console.WriteLine("Current added items, without orange and pink: ");
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            // declare and initialize the nummbers list
            List<int> numbers = new List<int> { 11, 3, 52, 32, 64, 5, 18, 42, 8 };

            // sort list
            numbers.Sort();

            // loop through the list and print each number followed by a space
            Console.WriteLine("Sorted numbers: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            // this will return a list of numbers that are 30 and smaller
            List<int> smallerEqual30 = numbers.FindAll(x => x <= 30);
            Console.WriteLine("\nSorted numbers, that are smaller or equal 30: ");
            foreach (int number in smallerEqual30)
            {
                Console.Write(number + " ");
            }

            /*
            lambda expression consists of 2 Parts
             1.parameters
             2.expression or statement block

             parameters are written on the left side of =>
             (this symbol is read as "goes to" or "becomes").
             the expression or action to perform is on the right side.

             this reads as:
             "take an input x and turn it into x multiplied by x"
             x => x * x;
            
            it will be looking like this, if this lambda expression(x => x* x) was a method:
            static int Squaring(int x)
            {
                return x * x;
            }
            */

            // define the predicate to check if a number is greater than 10
            Predicate<int> isGreaterThanTen = x => x > 10;
            List<int> higherTen= numbers.FindAll(isGreaterThanTen);
            Console.WriteLine("\nSorted numbers, that are greater than 10: ");
            foreach (int number in higherTen)
            {
                Console.Write(number + " ");
            }

            /*
            In C#, a delegate is like a pointer or a reference to a method. 
            It allows you to pass methods as arguments to other methods, 
            store them in variables, and call them later. 
            This is useful when you want your code to be flexible and 
            able to handle different behaviors that aren't predetermined. 
            A predicate is a delegate.
            */

            // this will return true if there are numbers greater than 20 and false if not
            bool largerThan20 = numbers.Any(x => x > 20);
            if(largerThan20)
            {
                Console.WriteLine("\nThere are numbers larger than 20.");
            } else
            {
                Console.WriteLine("\nThere are no numbers larger than 20.");
            }

            // declare a list of complex objects with initial values, using class Product
            List<Product> products = new List<Product>{
                new Product { Name = "Apple", Price = 0.80 },
                new Product { Name = "Banana", Price = 0.30 },
                new Product { Name = "Cherry", Price = 3.80 },
            };

            // add items to the list
            products.Add(new Product { Name = "Berries", Price = 2.99 });

            Console.WriteLine("Available Products: ");

            // itterate through the list
            foreach (Product product in products)
            {
                Console.WriteLine($"Product name: {product.Name} for {product.Price}");
            }

            // "Where" returns IEnumerable (to make it a List we use ToList()), it is a part of Linq
            List<Product> cheapProducts = products.Where(product => product.Price < 1.0).ToList();
            Console.WriteLine("Available Products for less than $1: ");
            foreach (Product product in cheapProducts)
            {
                Console.WriteLine($"Product name: {product.Name} for {product.Price}");
            }

            int? age = null; // int? is a nullable int

            Console.ReadKey();
        }
    }
}
