﻿using System;

namespace Enemies
{
    /// <summary>Class Zombie under the Enemies namespace.</summary>
    class Zombie
    {
        ///<summary>Health field that has value assigned when new instance is initialized</summary>
        public int health;

        ///<summary>Initializes new instance of Zombie class.</summary>
        public Zombie()
        {
            this.health = 0;
        }

        ///<summary>Initializes new instance of class Zombie with value to be assigned to health</summary>
        ///<param name="value">Value to set health. Must be greater than or equal to zero.</param>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            this.health = value;
        }

    }
}
