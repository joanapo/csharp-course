using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    internal class Customer
    {
        private static int nextId = 0;

        private readonly int _id;

        private string _password;

        // Write only property
        public string Password { set
            {
                _password = value;
            }
        }

        // Read only property
        public int Id
        {
            get { return _id; } 
        }
        
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }


        // Custom Constructor (ctor shortcut)
        public Customer(string name, string address = "NA", string contactNumber = "NA")
        {
            _id = nextId++;
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        // Default constructor
        public Customer()
        {
            _id = nextId++;
            Name = "Unknown";
            Address = "Unknown";
            ContactNumber = "Unknown";
        }

        public void SetDetails(string name, string address, string contactNumber = "NA")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Details anpit the customer: Name is {Name} and Id is {_id}");
        }
    }
}
