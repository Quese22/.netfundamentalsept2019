using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_loops
{
    [TestClass]
    public class loops
    {
        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 13;

            for (int i = 0; i < studentCount; i++) //skeleton// 3 parts last part is what you want it to do to get to student count of 13
            {
                Console.WriteLine(i);
            }

            for (int i = studentCount; i >= 1; i--) //decramenting i to get to 0 as delcared in the loops
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < studentCount--; i++)// in this its actually effecting the student count and trying to raise the value of i in the end. this gets i equal and student count
            {
                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void WhileLoops() //infinite loop would happen if this number could never equal 6 like say we started with 7.
        {
            int number = 5; //starts out with 5 so while the number is not equal to 6 then add to number, until it is equal to 6
            while (number != 6)
            {
                Console.WriteLine(number);
                number++;
                //if you wanted it to go go up more than by one then +="x" how much you want it to go up by.//
            }
        }

        [TestMethod]
        public void Foreachloop()
        {
            List<string> students = new List<string>();


            //the .add is adding the names to the list//
            students.Add("Regan");
            students.Add("Max");
            students.Add("Marquese");
            students.Add("Andrew");
            students.Add("Trevor");
            //the list can only have strings as we specified in the beginning

            foreach (string studentName in students)
            {
                Console.WriteLine(studentName);
            }


            string mountainName = "Mauna Kea"; //naming mountain name Mauna Kea


            foreach (char letter in mountainName)
            {
                if (letter == 'a')
                {
                } 
                Console.WriteLine(letter);
                //prints out each letter on its own line


            }
}

            
    }
}
