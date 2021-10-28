using System;


///<summary>Creates public Player class</summary>

class Player
{
    private string name;
    private float maxHp;
    private float hp;

    ///<summary>Constructor for class</summary>
    public Player(string name="Player", float maxHp=100f)
    {
        if (maxHp <= 0f)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }

        else
            this.maxHp = maxHp;

        this.name = name;
        this.hp = maxHp;
    }

    ///<summary>Prints hp infdormation</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}