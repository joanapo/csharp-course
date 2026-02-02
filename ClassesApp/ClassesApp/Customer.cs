using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }


        // Custom Constructor (ctor shortcut)
        public Customer(string name, string address = "NA", string contactNumber = "NA")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        // Default constructor
        public Customer()
        {
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
    }
}
