using System;

namespace Lecture_4_Solutions
{
    public class NotOldEnoughException : Exception
    {
        public NotOldEnoughException()
            : base("Person is too young")
        {
        }

        public NotOldEnoughException(string activity)
            : base($"Person is too young to {activity}")
        {
        }
    }
}