using System;
using System.Collections.Generic;

namespace Text
{
    ///<summary>Class containing a method that returns indexCount offirst non-repeating character</summary>
    public class Str
    {
        ///<summary>Returns the first non-repeating character of a string</summary>
        public static int UniqueChar(string s)
        {
            if (s == "")
                return (-1);

            char amIUnique = s[0];
            int indexCount = 0;

            if (amIUnique != s[1])
                return (indexCount);
            
            for (; indexCount < s.Length; indexCount++)
            {
                if (amIUnique == s[indexCount] && indexCount + 1 == s.Length)
                {
                    indexCount = -1;
                    break;
                }
                if (amIUnique == s[indexCount])
                    continue;

                amIUnique = s[indexCount];
                if (indexCount + 1 == s.Length)
                    break;
                if (amIUnique != s[indexCount+1])
                    break;
            }
            return (indexCount);
        }
    }
}