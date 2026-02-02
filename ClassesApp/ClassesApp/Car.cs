using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    internal class Car
    {
        // Member variable
        // Backing Field of the Model property
        private string _brand = "";
        
        // Property
        public string Model { get; set; }
        public bool IsLuxury { get; set; }
        public string Brand {
            get
            {
                if (IsLuxury)
                {
                    return _brand + " - Luxury Edition";
                }
                else
                {
                    return _brand;
                }
            }
            
            set {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered NOTHING!");
                    _brand = "DEFAULTVALUE";
                }
                else
                {
                    _brand = value;
                }
            }
        }

        // Constructor
        public Car(string brand, string model, bool isLuxury)
        {
            Brand = brand;
            Model = model;
            Console.WriteLine($"A car of the model {Brand} {Model} has been created.");
            IsLuxury = isLuxury;
        }
    }
}
