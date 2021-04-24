using System;

namespace Main
{
    public class StarMath
    {
        public int Add(int number1 , int number2)
        {
            if (number1 < 0 & number2 < 0) throw new Exception("number1 and number2 are negative number");
            if (number1 < 0) throw new Exception("number1 is negative number");
            if (number2 < 0) throw new Exception("number2 is negative number");
            var result = number1 + number2;
            return result;
        }
    }
}