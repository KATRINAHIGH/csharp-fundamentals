using NUnit.Framework;
using System;
namespace Csharp.Fundamentals
{
    [TestFixture()]
    public class PredicateUtilitiesTest
    {
        private PredicateUtilities math = new PredicateUtilities();

        [Test()]
        public void TestGreaterThanTrue()
        {
            // : Given
            int greaterValue = 450;
            int lesserValue = 350;


            // : When
            bool outcome = math.IsGreaterThan(greaterValue, lesserValue);

            // : Then
            Assert.IsTrue(outcome);
        }


        [Test()]
        public void TestGreaterThanFalse()
        {
            // : Given
            int greaterValue = 350;
            int lesserValue = 350;

            // : When
            bool outcome = math.IsGreaterThan(greaterValue, lesserValue);

            // : Then
            Assert.IsFalse(outcome);
        }


        [Test()]
        public void TestLessThanTrue()
        {
            // : Given
            int greaterValue = 450;
            int lesserValue = 350;

            // : When
            bool outcome = math.IsLessThan(greaterValue, lesserValue);

            // : Then
            Assert.IsFalse(outcome);
        }



        [Test()]
        public void TestLessThan1()
        {
            // : Given
            int greaterValue = 450;
            int lesserValue = 350;

            // : When
            bool outcome = math.IsLessThan(greaterValue, lesserValue);

            // : Then
            Assert.IsFalse(outcome);
        }


        [Test()]
        public void TestLessOrEqual1()
        {
            // : Given
            int greaterValue = 3;
            int lesserValue = 3;

            // : When
            bool outcome = math.IsLessThanOrEqualTo(greaterValue, lesserValue);

            // : Then
            Assert.IsTrue(outcome);
        }

        [Test()]
        public void TestLessOrEqual2()
        {
            // : Given
            int greaterValue = 3;
            int lesserValue = 6;

            // : When
            bool outcome = math.IsLessThanOrEqualTo(greaterValue, lesserValue);

            // : Then
            Assert.IsTrue(outcome);
        }

        [Test()]
        public void TestGreaterOrEqual1()
        {
            // : Given
            int greaterValue = 4;
            int lesserValue = 4;

            // : When
            bool outcome = math.IsGreaterThanOrEqualTo(greaterValue, lesserValue);

            // : ThenP
            Assert.IsTrue(outcome);
        }


        [Test()]
        public void TestGreaterOrEqual2()
        {
            // : Given
            int greaterValue = 8;
            int lesserValue = 15;

            // : When
            bool outcome = math.IsGreaterThanOrEqualTo(greaterValue, lesserValue);

            // : Then
            Assert.IsFalse(outcome);
        }
    }
}
