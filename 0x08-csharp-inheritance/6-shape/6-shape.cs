﻿using System;
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

///<summary>Class that inherits from shape</summary>
class Rectangle : Shape
{
    private int width;
    private int height;

    ///<summary>Public property that gets/sets width</summary>
    public int Width
    {
        get {return (width);}

        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            
            width = value;
        }
    }

    ///<summary>Public property that gets/sets height</summary>
    public int Height
    {
        get {return (height);}

        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            
            height = value;
        }
    }

}