using System;
using Main;
using NUnit.Framework;
using UnityEngine;


namespace MainTest
{
    public class StarMathTests
    {
        private StarMath _starMath;

        [SetUp]
        public void Setup()
        {
            _starMath = new StarMath();
        }

        [Test]
        [TestCase(1 , 2 , 3)]
        [TestCase(789 , 123 , 912)]
        [TestCase(0 , 0 , 0)]
        public void Should_Return_Positive_Number_Of_Add_Result(int number1 , int number2 , int expected)
        {
            // Act
            var addResult = _starMath.Add(number1 , number2);
            // Assert
            Assert.AreEqual(expected , addResult);
        }

        [Test]
        [TestCase(-1 , 0 , "number1 is negative number")]
        [TestCase(0 , -1 , "number2 is negative number")]
        [TestCase(-1 , -1 , "number1 and number2 are negative number")]
        public void Should_Throw_Exception(int number1 , int number2 , string errorMessage)
        {
            var exception = Assert.Throws<Exception>(() => { _starMath.Add(number1 , number2); });
            Assert.AreEqual(errorMessage , exception.Message);
        }
    }
}