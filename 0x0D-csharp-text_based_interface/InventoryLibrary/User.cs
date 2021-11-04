using System;

///<summary>User class that inherits from BaseClass</summary>
class User : BaseClass 
{
    public string name { get; set; }

    ///<summary>User class constructor</summary>
    public User(string name)
    {
        this.name = name;
    }
}