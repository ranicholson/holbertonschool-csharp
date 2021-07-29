using System;
using System.Collections.Generic;
using System.Linq;

namespace MyMath
{
    ///<summary>Class that contains a method to return max integer</summary>
    public class Operations
    {
        ///<summary>Returns the max integer in a list of integers</summary>
        ///<param name="nums">List with integers to find max of</param>
        public static int Max(List<int> nums)
        {
            if (nums.Count == 0)
            return (0);
            return (nums.Max());
        }
    }
}
