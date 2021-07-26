﻿enum Rating
{
    Good,
    Great,
    Excellent
}

struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    public Dog(string newName, float newAge, string newOwner, Rating newRating)
    {
        name = newName;
        age = newAge;
        owner = newOwner;
        rating = newRating;
    }
}
