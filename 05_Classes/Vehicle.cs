using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Vehicle
    {
        public Vehicle(string make, string model, string mileage, string color, string vin, int year, int coolnessFactor, bool isRunning)
        {


            Make = make;
            Model = model;
            Mileage = mileage;
            Color = color;
            VIN = vin;
            Year = year;
            CoolnessFactor = coolnessFactor;
            IsRunning = isRunning;
        }

        public Vehicle()
        {

        }

        public string Make { get; set; }
        public string Model { get; set; }
        public string Mileage { get; set; }
        public string Color { get; set; }
        public string VIN { get; set; }
        public int Year { get; set; }
        public int CoolnessFactor { get; set; }
        public bool IsRunning { get; set; }


      
    }
}
