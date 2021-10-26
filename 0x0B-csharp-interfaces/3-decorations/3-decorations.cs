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

///<summary>Decoration class that inherits from Base class</summary>
class Decoration: Base, IInteractive, IBreakable
{
    public bool isQuestItem { get; set; }
    public int durability { get; set; }

    public Decoration(string name="Decoration", int durability=1, bool isQuestItem=false)
    {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");

        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    public void Interact()
    {
        if (durability <= 0)
            Console.WriteLine($"The {name} has been broken.");

        else if(isQuestItem)
            Console.WriteLine($"You look at the {name}. There's a key inside.");

        else
            Console.WriteLine($"You look at the {name}. Not much to see here.");
    }

    public void Break()
    {
        durability--;
        
        if (durability > 0)
            Console.WriteLine($"You hit the {name}. It cracks.");

        if (durability == 0)
            Console.WriteLine($"You smash the {name}. What a mess.");

        if (durability < 0)
            Console.WriteLine($"The {name} is already broken.");
    }
}
