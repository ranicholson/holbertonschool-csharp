﻿using System;


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
            this.hp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;
            this.hp = maxHp;
        }

        this.name = name;
    }

    ///<summary>Prints hp infdormation</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    ///<summary>CalculateHealth delegate</summary>
    delegate void CalculateHealth(float damage);

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
