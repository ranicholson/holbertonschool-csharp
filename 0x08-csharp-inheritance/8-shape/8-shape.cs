using System;
using System.Collections.Generic;

///<summary>Shape class.</summary>
class Shape
{
    ///<summary>Throws exception.</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

///<summary>Class that inherits from shape.</summary>
class Rectangle : Shape
{
    private int width;
    private int height;

    ///<summary>Public property that gets/sets width.</summary>
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

    ///<summary>Public property that gets/sets height.</summary>
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

    ///<summary>Returns area of Rectangle.</summary>
    public new int Area()
    {
        return (height * width);
    }

    ///<summary>Returns string format of rectangle width and height.</summary>
    public override string ToString()
    {
        return (string.Format("[Rectangle] {0} / {1}", width, height));
    }
}

///<summary>Square class that inherits from rectangle</summary>
class Square : Rectangle
{
    private int size;

    ///<summary>Public poperty that sets/gets size</summary>
    public int Size
    {
        get {return (size);}

        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");

            size = value;
        }
    }
}