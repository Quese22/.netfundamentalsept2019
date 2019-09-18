using System;
using _05_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_ClassesTests //file name
{
    [TestClass]
    public class ClassExamples
    {
        [TestMethod]
        public void CookieClassInstantiation()
        {
            Cookie cookie = new Cookie();

            cookie.Name = "SnickerDoodle";
            cookie.BatchSize = 122;
            cookie.Direction = "Put together and throw in over";
            cookie.Ingredient = "secret: sour cream";
            cookie.Shape = "Eiffel Tower";
            cookie.Size = "365 feet";

            Cookie cookieTwo = new Cookie();
            cookie.Name = "Rasin and Oatmeal";
            cookie.BatchSize = 24;
            cookie.Direction = "raisins and oats";
            cookie.Ingredient = "real oats and honey instead of sugar";
            cookie.Shape = "football";
            cookie.Size = "pan fit";


            Cookie cookieThree = new Cookie("Chocolate Chip", "Chocolates and butter", "450 feet", "mix it all up", "oval", 25);
        }

        [TestMethod]
        public void MyTestMethod()

        {
            Vehicle vehicle = new Vehicle("Range Rover", "Discovery", "50000", "Black", "1234VJMJK",2018,9,true );
        }
    }
}
