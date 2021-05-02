using System;

namespace Utilities.Contract
{
    public static class Contract
    {
        public static bool CHECK_PRE  = true;
        public static bool CHECK_POST = true;

        public static void Require(bool value , string annotation = "")
        {
            if (CHECK_PRE == false)
                return;
            if (value == false)
                throw new PreconditionViolationException(annotation);
        }

        public static void RequireNotNull(object obj , string annotation = "")
        {
            if (CHECK_PRE == false)
                return;
            Require(obj != null , $"{annotation} cannot be null");
        }

        public static bool Ensure(bool value , string annotation = "")
        {
            if (CHECK_POST == false)
                return true;
            if (value == false)
                throw new PostConditionViolationException(annotation);
            return true;
        }

        public static bool EnsureNotNull(object obj , string annotation = "")
        {
            if (CHECK_POST == false)
                return true;
            return Ensure(obj != null , $"{annotation} cannot be null");
        }
    }

    public class PreconditionViolationException : Exception
    {
        public PreconditionViolationException(string annotation) : base(annotation) { }
    }

    public class PostConditionViolationException : Exception
    {
        public PostConditionViolationException(string annotation) : base(annotation) { }
    }
}