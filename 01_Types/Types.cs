using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class Types
    {
        [TestMethod]
        public void TestMethod1()
        {
            //int number = 1234;
            //bool on = true;
            //bool of = true;
            //decimal hiddy = 12233434432.00m;
            //float anotherdecimalBabyee= 1234.5f;
            //double anotherbadboy = 16162773626161.00;

            char character = '?';
            byte byteExample = 255; //0-255
            sbyte sByteMAx = -128;
            short ShortExample = 32767;
            Int16 anotherShortexample = 32000;
            Int32 intmax = 2147483468;
            long longExample = 922367784875783;
            Int64 longin = 4738493929020049483;
        }

        [TestMethod]
        public void Operators()
        {
            // + - / % *

            int numberOne = 3;
            int numberTwo = 5;

            int sum = numberOne + numberTwo;
            int subtraction = numberTwo - numberOne;
            float division = numberTwo / numberOne; //will not always come back as a whole number
            int multiply = numberOne * numberTwo;
            int remainder = numberTwo % numberOne;

            Console.WriteLine(sum);
            Console.WriteLine(subtraction);
            Console.WriteLine(division);
            Console.WriteLine(multiply);
            Console.WriteLine(remainder);

        }
        [TestMethod]
        public void ReferenceTypes()
        {

            string firstName = "Marquese";
            string lastName = "Martin-Hayes";

            //concatanation

            string concatanation = firstName + " " + lastName;
            Console.WriteLine(concatanation);

            //Composite Formatting
            string composite = string.Format("Hello my name is {0} {1}", firstName,
            lastName);
            Console.WriteLine(composite);

            // String Interpolation
            string interpolation = $"{firstName} {lastName}";
            Console.WriteLine(interpolation);

            //Classes

            // Structs

            // Collections

            List<string> myList = new List<string>();
            myList.Add("Hellow World!");

            List<int> myNumberList = new List<int>();
            myNumberList.Add(2);


            Queue<string> myQueue = new Queue<string>(); //first in and first out
            myQueue.Enqueue("Hello World?");

            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            Stack<int> newStack = new Stack<int>(); //opposite of queue last in first out


            string banana = "fruit";
            string[] stringArray = { "Hello", "Character", "Food", "Water" };




        }
    }
}
