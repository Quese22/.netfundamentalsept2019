using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Cookie
    { 
        public Cookie(string name, string ingredient, string size, string direction, string shape, int batchSize)
        {
            Name = name;
            Ingredient = ingredient;
            Size = size;
            Direction = direction;
            Shape = shape;
            BatchSize = batchSize;

        }

        public Cookie()
        {

        }

        //properties must have a class and are pascal case// skeleton for classes and properties
        //setting the value for us and getting the value and returning it --creating more functionaliy for us
        public string Name { get; set; }
        public string Ingredient { get; set; }
        public string Size { get; set; }
        public string Direction { get; set; }
        public string Shape { get; set; }
        // List<string> Ingredients { get; set; }
        public int BatchSize { get; set; }
    }
}
