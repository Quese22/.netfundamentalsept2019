using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Methods
{
    [TestClass]
    public class Methods
    {
        [TestMethod]
        public void MethodExamples()
        {
            // + = -/ * %
            int sum = 2 + 2;
            int subtraction = 2 - 2;
            int multiply = 2 * 2;
            int divide = 2 / 2;
            int remainder = 5 % 2;

            int expected = 8;
            int actual = AddTwoNumbers(sum, multiply);


            Assert.AreEqual(expected, actual);

            int expectedTwo = 0;
            int actualTwo = SubstractTwoNumbers(divide, remainder);
            Assert.AreEqual(expectedTwo, actualTwo);

            int expectedThree = 4;
            int actualThree = MultiplyTwoNumbers(sum, divide);
            Assert.AreEqual(expectedThree, actualThree);
        }   


        //1.access modifier private/protected/public
        //2. return type (int)(string)
        //3. name
        //4. (parameters or what the method needs in order to run)//
        // type must return type/ void is the exception

        public int AddTwoNumbers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;

            // all to return sum without having any fixed values//
        }


        public int SubstractTwoNumbers(int numOne, int numTwo)
        {
            int subtract = numTwo - numOne;
            return subtract;
        }

        public int MultiplyTwoNumbers(int numOne, int numTwo)
        {
            int multiplied = numOne * numTwo;
            return multiplied;
        }
    }
}
