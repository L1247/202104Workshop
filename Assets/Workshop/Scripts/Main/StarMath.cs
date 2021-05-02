using System;
using Utilities.Contract;

namespace Main
{
    public class StarMath
    {
        /// <exception cref="T:Contract.PreconditionViolationException">
        ///   <paramref name="s" /> 代表小於 <see cref="F:System.Int32.MinValue" /> 或大於 <see cref="F:System.Int32.MaxValue" /> 的數字。
        /// </exception>
        public int Add(int number1 , int number2)
        {
            // Pre - Condition
            Contract.Require(number1 >= 0 || number2 >= 0 , "Number 1 and number 2 is negative");
            Contract.Require(number1 >= 0 , "Number 1 is negative");
            Contract.Require(number2 >= 0 , "Number 2 is negative");
            // Method Body
            var result = number1 + number2;
            // Post - Condition
            Contract.Ensure(result == number1 + number2 , "add function not work");
            // Overflow Check
            result = CheckOverflow(number1 , number2 , result);
            // Class invariant
            Contract.Ensure(result >= 0 , $"result should be positive number , result is{result}");
            return result;
        }

        private int CheckOverflow(int number1 , int number2 , int result)
        {
            long bigNumber = (long)number1 + (long)number2;
            if (bigNumber > int.MaxValue)
                result = int.MaxValue;
            return result;
        }
    }
}