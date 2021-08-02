using System;
using System.Collections.Generic;

///<summary>Shape class</summary>
class Shape
{
    ///<summary>Throws exception</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}