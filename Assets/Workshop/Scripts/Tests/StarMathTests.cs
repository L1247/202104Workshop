using Main;
using NUnit.Framework;


namespace MainTest
{
    public class StarMathTests
    {
        [Test]
        [TestCase(1 , 2 , 3)]
        [TestCase(789 , 123 , 912)]
        public void Should_Return_Positive_Number_Of_Add_Result(int number1 , int number2 , int expected)
        {
            // Arrange
            var starMath = new StarMath();
            // Act
            var addResult = starMath.Add(number1 , number2);
            // Assert
            Assert.AreEqual(expected , addResult);
        }
    }
}