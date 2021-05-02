using System;
using Utilities.Contract;

namespace Main
{
    public class StarMath
    {
        public int Add(int number1 , int number2)
        {
            Contract.Require(number1>=0 ||  number2>=0 , "Number 1 and number 2 is negative");
            Contract.Require(number1>=0 , "Number 1 is negative");
            Contract.Require(number2>=0 , "Number 2 is negative");
            var result = number1 + number2 ;
            if (result != number1 + number2)
                throw new Exception("PostCondition is error");
            long bigNumber = (long)number1 + (long)number2;
            if (bigNumber>int.MaxValue)
                return int.MaxValue;
            if (result<0)
                throw new Exception($"result should be positive number , result is {result}");
            return result;
        }
    }
}