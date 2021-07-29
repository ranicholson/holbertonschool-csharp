using System;
using System.Collections.Generic;

namespace Text
{
    ///<summary>Class containing method to check if string is a palindrome.</summary>
    public class Str
    {
        ///<summary>Returns true if string is a palindrome or false if not</summary>
        ///<param name="s">String to check palindrominess of</param>
        public static bool IsPalindrome(string s)
        {
            string newString = "";
            string reverseString = "";
            foreach (char character in s)
            {
                if (Char.IsPunctuation(character) == true || Char.IsWhiteSpace(character) == true)
                    continue;
                newString += Char.ToLower(character);
            }
            for (int x = newString.Length - 1;x >= 0; x--)
                reverseString += newString[x];
            if (newString == reverseString)
                return (true);
            return (false);    
        }
    }
}
