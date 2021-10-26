using System;

///<summary>Abstract base class</summary>

abstract class Base
{
    public string name { get; set; }

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

class Door : Base, IInteractive
{
    public Door(string dName="Door")
    {
        this.name = dName;
    }

    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}
