using System;

///<summary>Class to check if object is an instance of or inherits from Array</summary>
class Obj
    {
        ///<summary>Returns true if object is an instance of/inherits from Array</summary>
        ///<param name="obj">Object to check type.</param>
        ///<return>True/False.</return>
        public static bool IsInstanceOfArray(object obj)
        {
            return (typeof(Array).IsInstanceOfType(obj));
        }
    }
