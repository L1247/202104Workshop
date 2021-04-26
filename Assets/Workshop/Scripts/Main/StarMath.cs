using System;

namespace Main
{
    public class StarMath
    {
        public int Add(int number1 , int number2)
        {
            // ReSharper disable once InconsistentNaming
            var number1_Is_Negative = number1 < 0;
            // ReSharper disable once InconsistentNaming
            var number2_Is_Negative = number2 < 0;
            // ReSharper disable once InconsistentNaming
            var number1_And_Number2_Is_Negative = number1_Is_Negative & number2_Is_Negative;
            if (number1_And_Number2_Is_Negative)
                throw new Exception("number1 and number2 are negative number");
            if (number1_Is_Negative) throw new Exception("number1 is negative number");
            if (number2_Is_Negative) throw new Exception("number2 is negative number");
            var result = number1 + number2;
            return result;
        }
    }
}