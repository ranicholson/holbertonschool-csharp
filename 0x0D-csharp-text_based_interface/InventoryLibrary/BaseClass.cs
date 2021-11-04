using System;

///<summary>BaseClass that other classes will inherit from</summary>
class BaseClass
{
    public string id { get; set; }
    public DateTime date_created { get; set; }
    public DateTime date_updated { get; set; }

    ///<summary>Constructor for BaseClass</summary>
    public BaseClass()
    {
        this.id = Guid.NewGuid().ToString();
        this.date_created = DateTime.Now;
        this.date_updated = this.date_created;
    }
}