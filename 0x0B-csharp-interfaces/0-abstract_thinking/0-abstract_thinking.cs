using System;

///<summary>Abstract base class</summary>

abstract class Base
{
    public string name = "";

    ///<summary>Override of ToString() that returns name and type</summary>
    public override string ToString()
    {
        return (this.name +" is a " + this.GetType().ToString());
    }
}
