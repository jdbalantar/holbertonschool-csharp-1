using System;
namespace Enemies
{
    /// <summary>  Class Zombie </summary>
    public class Zombie 
    {
        /// <summary> should be an int and have no value </summary>
        public int health;
        /// <summary> Method Constructor that inicialize health value</summary>
        public Zombie()
        {
            health = 0;
        }
        /// <summary> Constructor that update value of health </summary>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            health = value;
        }
    }
}
