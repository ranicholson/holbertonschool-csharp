﻿using System;


/// <summary>Class filled with math fun</summary>
    class VectorMath
    {
        /// <summary>Calculates length of a given vector</summary>
        public static double Magnitude(double[] vector)
        {
            if (vector.Length == 2)
                return (Math.Round(Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2)), 2));

            if (vector.Length == 3)
                return (Math.Round(Math.Sqrt(Math.Pow(vector[0], 2) + Math.Pow(vector[1], 2) + Math.Pow(vector[2], 2)), 2));

            return (-1);
        }
    }
