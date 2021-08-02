using System;

    ///<summary>Class containg method to check an object type</summary>
    class Obj
    {
        ///<summary>Returns true if the object is an int</summary>
        ///<param name="obj">Object to check intness of</param>
        public static bool IsOfTypeInt(object obj)
        {
            return (obj is int);
        }
    }
