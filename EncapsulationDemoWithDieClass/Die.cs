using System;
namespace EncapsulationDemoWithDieClass
{
    /// <summary>
    /// Represents an individual die
    /// </summary>
    public class Die
    {
        // static fields are shared across all instances of a class
        static Random rand;

        static Die() // Static constructors are called once for all instances of this class
        {
            rand = new Random();
        }

        public Die()
        {
            Roll(); // Roll die on creation to generate first random number
        }

        /// <summary>
        /// Face up value of die
        /// </summary>
        public byte Value { get; private set;  }

        public bool IsHeld { get; set; }

        /// <summary>
        /// Roll a new random value between 1 - 6
        /// and return the newly rolled value
        /// If the die is held, the current value will be returned
        /// and no new value generated
        /// </summary>
        public byte Roll()
        {
            if (!IsHeld) // If die is not held
            {
                Value = (byte)rand.Next(1, 7);
            }
            return Value;
        }
    }
}
