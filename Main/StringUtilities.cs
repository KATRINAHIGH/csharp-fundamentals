using System;
using System.Collections.Generic;
namespace Csharp.Fundamentals
{
    public class StringUtilities
    {
        /*
         * @return `Hello World` as a string
         */
        public static string GetHelloWorld()
        {
            return "Hello World";
        }

        /*
         * @param firstSegment a string to be added to
         * @param secondSegment a string to add
         * @return the concatenation of two strings, `firstSegment`, and `secondSegment`
         */
        public static string Concatenation(string firstSegment, string secondSegment)
        {
            return firstSegment + secondSegment;
        }

        /*
         * @param firstSegment a string to be added to
         * @param secondSegment a string to add
         * @return the concatenation of an integer, `firstSegment`, and a String, `secondSegment`
         */
        public static string Concatenation(int firstSegment, string secondSegment)
        {
            return firstSegment + secondSegment;
        }

        /**
         * @param input a string to be manipulated
         * @return the first 3 characters of `input`
         */
        public static string GetPrefix(string input)
        {
            return input.Substring(0, 3);
        }

        /**
         * @param input a string to be manipulated
         * @return the last 3 characters of `input`
         */
        public static string GetSuffix(string input)
        {
            return input.Substring(input.Length - 3);
        }

        /**
         * @param inputValue the value to be compared
         * @param comparableValue the value to be compared against
         * @return the equivalence of two strings, `inputValue` and `comparableValue`
         */
        public static Boolean CompareTwoStrings(string inputValue, string comparableValue)
        {
            return inputValue.Equals(comparableValue);
        }

        /**
         * @param inputValue the value input from user
         * @return the middle character of `inputValue`
         */
        public static char GetMiddleCharacter(string inputValue)
        {
            if (inputValue.Length % 2 == 0)
            {
                return inputValue[(inputValue.Length / 2) - 1];
            }
            else
            {
                return inputValue[inputValue.Length / 2];
            }

        }
        
        /**
         * @param spaceDelimitedString a string, representative of a sentence, containing spaces
         * @return the first sequence of characters
         */
        public static string GetFirstWord(string spaceDelimitedString)
        {
            int indexFirstSpace = spaceDelimitedString.IndexOf(' ');
            return spaceDelimitedString.Substring(0, indexFirstSpace);
        }

        /**
         * @param spaceDelimitedString a string delimited by spaces
         * @return the second word of a string delimited by spaces.
         */
        public static string GetSecondWord(string spaceDelimitedString)
        {
            string[] splitString = spaceDelimitedString.Split(' ');
            return splitString[1];
        }

        /*
         * string is reversed by traversing the string backwards and changing the postion of the characters 
         * from right to left one by one
         * @param stringToReverse
         * @return an identical string with characters in reverse order.
         */
        public static string ReverseTheTwo(string stringToReverse)
        {
            string result = "";
            for (int i = stringToReverse.Length-1; i >= 0; i-- ){
                result = result + stringToReverse[i];
            }
           return result;
        }

        /*
         * string is reversed by converting to char array and swapping front and back positions, 
         * only traverse half the array 
         * @param stringToReverse
         * @return an identical string with characters in reverse order.
         */
        public static string ReverseStringSwapChar(string stringToReverse)
        {
            char[] charArray = stringToReverse.ToCharArray();
            for (int i = 0, j = stringToReverse.Length - 1; i<j; i++, j--){
                char temp = charArray[i];
                charArray[i] = charArray[j];
                charArray[j] = temp;
            }
            return new String(charArray);
        }

        /*
        * String reversal w/out copy to char array it's i<=j as we need to get the
        * middle char in case of odd char in the string
        * @param stringToReverse
        * @return an identical string with characters in reverse order.
        */
        public static string ReverseStringSwapCharNoCopy(string stringToReverse)
        {
            char[] charArray = new char[stringToReverse.Length];
            for (int i = 0, j = stringToReverse.Length - 1; i <= j; i++, j--)
            {
                charArray[i] = stringToReverse[j];
                charArray[j] = stringToReverse[i];
            }
            return new String(charArray);
        }

        /*
        * Recursion method; simple and regular performance for small strings
        * @param stringToReverse
        * @return an identical string with characters in reverse order.
        */
        public static string ReverseStringRecursion(string stringToReverse)
        {
            if (stringToReverse.Length <= 1)

                return stringToReverse;
            else
                return ReverseStringRecursion(stringToReverse.Substring(1)) + stringToReverse[0];
        }

        /*
        * reverses a string uses a stack, FILO
        * @param stringToReverse
        * @return an identical string with characters in reverse order.
        */
        public static string ReverseStringStack(string stringToReverse)
        {
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < stringToReverse.Length; i++){
                stack.Push(stringToReverse.Substring(i, 1));
            }

            string result = string.Empty;
            for (int i = 0; i < stringToReverse.Length; i++){
                result += stack.Pop();
            }
            return result;
        }
    }
}






