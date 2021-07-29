using System;

namespace Text
{
    ///<summary>Class that contains method to determine how many words in a string</summary>
    public class Str
    {
        ///<summary>Determines how many words are in a string based by capital letter of each word</summary>
        ///<param name = "s">String to count number of word in</param>
        public static int CamelCase(string s)
        {
            if (s == "")
                return (0);
            int wordCount = 1;
            foreach (char character in s)
            {
                if (Char.IsUpper(character) == true)
                    wordCount += 1;
            }
            return (wordCount);
        }
    }
}
