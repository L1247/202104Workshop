#region

using System;
using Main;
using NUnit.Framework;

#endregion

namespace MainTests
{
    public class StarMathTest
    {
    #region Private Variables

        private StarMath starMath;

    #endregion

    #region Setup/Teardown Methods

        [SetUp]
        public void SetUp()
        {
            starMath = new StarMath();
        }

    #endregion

    #region Test Methods

        [Test]
        [TestCase(1 , 2 , 3)]
        [TestCase(123 , 789 , 912)]
        public void Should_Return_Result_With_Two_Positive_Number(int number1 , int number2 , int expectedResult)
        {
            // Act
            var result = starMath.Add(number1 , number2);
            // Assert
            Assert.AreEqual(expectedResult , result);
        }

        [Test]
        [TestCase(-1 , 2 , "Number 1 is negative")]
        [TestCase(1 , -2,"Number 2 is negative")]
        [TestCase(-3 , -2,"Number 1 and number 2 is negative")]
        public void Should_Throw_Exception_With_NotInRange_Input_Number(int number1 , int number2 , string message)
        {
            var exception = Assert.Throws<Exception>(() => starMath.Add(number1 , number2));
            Assert.AreEqual(message , exception.Message);
        }

    #endregion
    }
}