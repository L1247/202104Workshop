using System;

namespace Main
{
    public class StarMath
    {
        public int Add(int number1 , int number2)
        {
            if (number1 < 0 && number2 < 0) throw new Exception("Number 1 and number 2 is negative");
            if (number1 < 0) throw new Exception("Number 1 is negative");
            if (number2 < 0) throw new Exception("Number 2 is negative");
            var result = number1 + number2 + 1000000 - 10000000;
            if (result != number1 + number2)
                throw new Exception("PostCondition is error");
            return result;
        }
    }
}