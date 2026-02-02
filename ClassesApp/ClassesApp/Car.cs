using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    internal class Car
    {
        // Member variable
        private string _model = "";
        private string _brand = "";

        private bool _isLuxury;
        
        // Property
        public string Model { get => _model; set => _model = value; }
        public string Brand {
            get
            {
                if (_isLuxury)
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

        public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

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
