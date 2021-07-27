using System;

namespace Enemies
{
    /// <summary>Class Zombie under the Enemies namespace.</summary>
    class Zombie
    {
        /// <summary>Health field that has value assigned when new instance is initialized</summary>
        private int health;

        ///<summary>Name field that has string value and defaults to (No Name)</summary>
        private string name = "(No Name)";

        /// <summary>Gets or sets the name</summary>
        public string Name { get {return (name);} set {name=value;} }

        ///<summary>Initializes new instance of Zombie class.</summary>
        public Zombie()
        {
            health = 0;
        }

        ///<summary>Initializes new instance of class Zombie with value to be assigned to health</summary>
        ///<param name="value">Value to set health. Must be greater than or equal to zero.</param>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }

        ///<summary>Returns the value of health</summary>
        public int GetHealth()
        {
            return (health);
        }

    }
}
