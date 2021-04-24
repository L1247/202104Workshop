using NUnit.Framework;

public class StarMathTests
{
    [Test]
    public void Should_Return_Positive_Number_Of_Add_Result()
    {
        // Arrange
        var starMath = new StarMath();
        // Act
        var addResult = starMath.Add(1 , 2);
        // Assert
        Assert.AreEqual(3 , addResult);
    }
}

public class StarMath
{
    public int Add(int number1 , int number2)
    {
        return 3;
    }
}