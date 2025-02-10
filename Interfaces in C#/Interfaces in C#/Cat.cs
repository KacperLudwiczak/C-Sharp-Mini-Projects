using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_in_C_
{
    internal class Cat : IAnimal
    {
        public void Eat(string food)
        {
            Console.WriteLine($"Cat ate {food}.");
        }

        public void MakeSound()
        {
            Console.WriteLine("Moew...");
        }
    }
}
