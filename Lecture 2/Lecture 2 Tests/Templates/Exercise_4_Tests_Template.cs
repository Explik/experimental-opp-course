﻿using Explik.StructuralTestTools.MSTest;
using Lecture_2_Solutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lecture_2_Tests
{
    [TemplatedTestClass]
    public class Exercise_4_Tests_Template
    {
        #region Exercise 4B

        [TemplatedTestMethod("a. Number.Equals does not equate 4 and 5"), TestCategory("Exercise 4B")]
        public void EqualsDoesNotEquateFourAndFive()
        {
            Number number1 = new Number(4);
            Number number2 = new Number(5);

            Assert.IsFalse(number1.Equals(number2));
        }

        [TemplatedTestMethod("b. Number.Equals equates 5 and 5"), TestCategory("Exercise 4B")]
        public void EqualsEquatesFiveAndFive()
        {
            Number number1 = new Number(5);
            Number number2 = new Number(5);

            Assert.IsTrue(number1.Equals(number2));
        }

        #endregion Exercise 4B

        #region Exercise 4C

        [TemplatedTestMethod("a. Number.GetHashCode does not equate 4 and 5"), TestCategory("Exercise 4C")]
        public void GetHashCodeDoesNotEquateFourAndFive()
        {
            Number number1 = new Number(4);
            Number number2 = new Number(5);

            Assert.IsFalse(number1.GetHashCode() == number2.GetHashCode());
        }

        [TemplatedTestMethod("b. Number.GetHashCode equates 5 and 5"), TestCategory("Exercise 4C")]
        public void GetHashCodeEquatesFiveAndFice()
        {
            Number number1 = new Number(5);
            Number number2 = new Number(5);

            Assert.IsTrue(number1.GetHashCode() == number2.GetHashCode());
        }

        #endregion Exercise 4C
    }
}