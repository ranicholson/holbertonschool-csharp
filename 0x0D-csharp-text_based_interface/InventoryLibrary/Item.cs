using System;

///<summary>Item class that inherits from BaseClass</summary>
class Item : BaseClass
{
    public string name { get; set; }
    public string description { get; set; }
    public float price { get; set; }
    List<string> tags { get; set; }

    ///<summary>Constructor for Item class</summary>
    public Item(string name, string description=null, float price=null, List<string> tags=null)
    {
        this.name = name;
        this.description = description;
        this.price = Math.Round(price, 2);
        this.tags = tags;
    }
}