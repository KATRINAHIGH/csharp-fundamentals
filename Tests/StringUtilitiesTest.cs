using NUnit.Framework;
using System;
namespace Csharp.Fundamentals
{
    [TestFixture()]
    public class StringUtilitiesTest
    {

        [Test()]
         public void GetHelloWorldTest()
        {
            // : Given
            string expected = "Hello World";

            // : When
            string actual = StringUtilities.GetHelloWorld();

            // : Then
            Assert.AreEqual(expected, actual);

        }

        [Test()]
         public void ConcatenationStringTest()
        {
            // : Given
            string one = "Hello";
            string two = " Java";
            string expected = "Hello Java";

            // : When
            string actual = StringUtilities.Concatenation(one, two);


            // : Then
            Assert.AreEqual(expected, actual);
        }


        [Test()]
         public void ConcatenationStringAndIntegerTest()
        {
            // : Given
            int one = 1;
            string two = " Java";
            string expected = "1 Java";

            // : When
            string actual = StringUtilities.Concatenation(one, two);


            // : Then
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void SubstringBeginTest()
        {
            // : Given
            string input = "Hello";
            string expected = "Hel";

            // : When
            string actual = StringUtilities.GetPrefix(input);

            // : Then
            Assert.AreEqual(expected, actual);
        }

        [Test()]
         public void SubstringEndTest()
        {
            // : Given
            string input = "Hello";
            string expected = "llo";

            // : When
            string actual = StringUtilities.GetSuffix(input);

            // : Then
            Assert.AreEqual(expected, actual);
        }

        [Test()]
         public void CompareToTestEquals()
        {
            // : Given
            string inputValue = "Zipcode";
            string comparableValue = "Zipcode";

            // : When
            bool actual = StringUtilities.CompareTwoStrings(inputValue, comparableValue);

            // : Then
            Assert.IsTrue(actual);
        }


        [Test()]
         public void CompareToTestNotEquals()
        {
            // : Given
            string inputValue = "Zipcode";
            string comparableValue = "Zipcodee";

            // : When
            bool actual = StringUtilities.CompareTwoStrings(inputValue, comparableValue);

            // : Then
            Assert.IsFalse(actual);
        }

        [Test()]
         public void GetTheMiddleChar1()
        {
            // : Given
            string input = "Zipcode";
            char expected = 'c';

            // : When
            char actual = StringUtilities.GetMiddleCharacter(input);

            // : Then
            Assert.AreEqual(expected, actual);
        }


        [Test()]
        public void GetTheMiddleChar2()
        {
            // : Given
            string input = "Zipcoder";
            char expected = 'c';

            // : When
            char actual = StringUtilities.GetMiddleCharacter(input);

            // : Then
            Assert.AreEqual(expected, actual);
        }


        [Test()]
         public void GetTheFirstWord()
        {
            // : Given
            string input = "Zipcode Wilmington";
            string expected = "Zipcode";

            // : When
            string actual = StringUtilities.GetFirstWord(input);

            // : Then
            Assert.AreEqual(expected, actual);
        }


        [Test()]
        public void GetTheSecondWord()
        {
            // : Given
            string input = "Zipcode Wilmington";
            string expected = "Wilmington";

            // : When
            string actual = StringUtilities.GetSecondWord(input);

            // : Then
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void ReverseThem()
        {
            // : Given
            string input = "Zipcode Wilmington";
            string expected = "notgnimliW edocpiZ";


            // : When
            string actual = StringUtilities.ReverseTheTwo(input);

            // : Then
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void ReverseUseSwap()
        {
            // : Given
            string input = "Zipcode Wilmington";
            string expected = "notgnimliW edocpiZ";


            // : When
            string actual = StringUtilities.ReverseStringSwapChar(input);

            // : Then
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void ReverseUseSwapNoCopy()
        {
            // : Given
            string input = "Zipcode Wilmington";
            string expected = "notgnimliW edocpiZ";


            // : When
            string actual = StringUtilities.ReverseStringSwapCharNoCopy(input);

            // : Then
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void ReverseUseStack()
        {
            // : Given
            string input = "Zipcode Wilmington";
            string expected = "notgnimliW edocpiZ";


            // : When
            string actual = StringUtilities.ReverseStringStack(input);

            // : Then
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void ReverseUseRecursion()
        {
            // : Given
            string input = "Zipcode Wilmington";
            string expected = "notgnimliW edocpiZ";


            // : When
            string actual = StringUtilities.ReverseStringRecursion(input);

            // : Then
            Assert.AreEqual(expected, actual);
        }
    }
}

