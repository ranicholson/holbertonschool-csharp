using System;


///<summary>Creates public Player class</summary>

class Player
{
    private float hp;
    private float maxHp;
    private string name;
    private string status;

    ///<summary>Constructor for class</summary>
    public Player(string name="Player", float maxHp=100f)
    {
        if (maxHp <= 0f)
        {
            this.maxHp = 100f;
            this.hp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;
            this.hp = maxHp;
        }

        this.name = name;
        this.status = $"{this.name} is ready to go!";
        HPCheck += CheckStatus;
    }

    ///<summary>Prints hp infdormation</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    ///<summary>CalculateHealth delegate</summary>
    delegate void CalculateHealth(float damage);

    ///<summary>CheckStatus method to change status based off of currentHp</summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHP == this.maxHp)
            this.status = $"{this.name} is in perfect health!";

        else if (e.currentHP >= (this.maxHp / 2f))
            this.status = $"{this.name} is doing well!";

        else if (e.currentHP >= (this.maxHp / 4f))
            this.status = $"{this.name} isn't doing too great...";

        else if (e.currentHP > 0)
            this.status = $"{this.name} needs help!";

        else
            this.status = $"{this.name} is knocked out!";

        Console.WriteLine(this.status);
    }

    ///<summary>Method to handle damage</summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
            Console.WriteLine($"{name} takes 0 damage!");

        else
        {
            Console.WriteLine($"{name} takes {damage} damage!");
            this.hp -= damage;
        }

        ValidateHP(this.hp);
    }

    ///<summary>Method to handle healing</summary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
            Console.WriteLine($"{name} heals 0 HP!");

        else
        {
            this.hp += heal;
            Console.WriteLine($"{name} heals {heal} HP!");
        }

        ValidateHP(this.hp);
    }

    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            this.hp = 0;
        
        else if (newHp > this.maxHp)
            this.hp = this.maxHp;

        else
            this.hp = newHp;
        
        HPCheck(this, new CurrentHPArgs(this.hp));
    }

    ///<summary>Applies the calculated modifvier</summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
            return (baseValue * 0.5f);

        if (modifier == Modifier.Base)
            return (baseValue);

        return (baseValue * 1.5f);
    }

    ///<summary>Event handler for HPCheck</summary>
    public event EventHandler<CurrentHPArgs> HPCheck;
}

///<summary>Value modifiers</summary>
public enum Modifier
{
    ///<summary>Weak is half of base value</summary>
    Weak,
    ///<summary>Base is the base value</summary>
    Base,
    ///<summary>Strong is 1.5 times the base value</summary>
    Strong
}

///<summary>Delegate to calculate modifiers</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

///<summary>Class for CurrentHPArgs</summary>
class CurrentHPArgs : EventArgs
{
    public readonly float currentHP;

    ///<summary>Constructor for CurrentHPArgs class</summary>
    public CurrentHPArgs(float newHp)
    {
        this.currentHP = newHp;
    }
}
