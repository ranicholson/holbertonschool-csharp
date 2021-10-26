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

interface IInteractive
{
    void Interact();
}

interface IBreakable
{
    int durability { get; set; }
    void Break();
}

interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }

    public void Interact()
	{
        
	}

    public void Break()
	{

	}

    public void Collect()
	{

	}
}
