using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Conditionals
{
    [TestClass]
    public class ConditionalExamples
    {
        [TestMethod]
        public void IfElseStatements()
        {
            // if else if else
            int age = 14;

            // if () //skeleton for if statement true goes in the parantheses

            if (age >= 21)
            {

                Console.WriteLine("You can drink");
            }
            else if (age < 21)
            {

                Console.WriteLine("sorry");
                age += 4;
            }
            else
            {
                Console.WriteLine("This is default");

            }

            if (age == 18)
            {
                Console.WriteLine("You wrote me out. YAY");
            }

            decimal bankAccount = 1.01m;

            if (bankAccount < 5)
            {
                Console.WriteLine("You need more money.");
            }
            else if (bankAccount >= 5 && bankAccount < 100)
            {
                Console.WriteLine("Moving up in the world!");
            }
            else if (bankAccount == 100 || bankAccount == 4)
            {
                Console.WriteLine("woah");
            }
            else
            {
                Console.WriteLine("Cool");
            }

            // && == AND || == OR > < >= <= != (is not equal to. bang operator)

        }

        [TestMethod]
        public void SwitchCases() //method
            //looks to see that the value pressed in is matching//

        {
            int age = 25;
            switch (age)
            {
                case 1:
                    //the code we want to execute is above the break but after case:
                    //the code we want to execute 
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Happy Birthday"); //needs to hit number 123or4 in order for it to write

                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Too bad. it will be soon");
                    break;
            }
        }
        [TestMethod]
        public void Ternaries()
        {
            int age = 55;

            // 1 condition // 2 if true // 3 if false 
            //1 //2 //3
            //() ? true : false; skelaton for a ternarie

            bool isAdult = age > 18 ? true : false;

        }
    }
}
