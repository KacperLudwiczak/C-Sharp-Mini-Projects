using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Classes__OOP_
{
    internal class Customer
    {
        // static field to hold the next ID available
        private static int nextId = 0;
        // readonly instance field initizalized only once (so it can only assigned a value once)
        private readonly int _id;
        // writeonly instance field
        private string _password;


        // property
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        // readonly property, we only have get (we can look at a value but not create it)
        public int Id 
        { 
            get 
            {
                return _id;
            } 
        }
        // writeonly property, we only have set (we can create a value but not look at it)
        public string Password
        {
            set
            {
                _password = value;
            }
        }

        // default constructor
        public Customer()
        {
            _id = nextId++;
            Name = "name";
            Address = "address";
            ContactNumber = "contact number";
        }

        // customer constructor
        public Customer(string name, string address, string contactNumber)
        {
            _id = nextId++;
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        // customer constructor with only name
        public Customer(string name)
        {
            _id = nextId++;
            Name = name;
        }

        // method, with default contactNumber parameter
        public void SetDetails(string name, string address, string contactNumber = "NA")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }
    }
}
