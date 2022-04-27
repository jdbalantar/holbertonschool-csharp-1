using System;
namespace Enemies
{
    /// <summary>  Class Zombie </summary>
    public class Zombie 
    {
        /// <summary> Private Field health should be an int and have no value </summary>
        private int health;
        /// <summary> Private Field name </summary>
        private string name = "(No name)";
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
        /// <summary>This property retrieve and set a name</summary>
        public string Name
        {
            get{ return this.name; }
            set { name = value; }
        }
        /// <summary> Method that return the value of health of the Zombie object </summary>
        public int GetHealth()
        {
            return health;
        }
        /// <summary> This method retrieve all variables </summary>
        public override  string ToString()=> $"Zombie Name: {name} / Total health: {health}";
    }
}
