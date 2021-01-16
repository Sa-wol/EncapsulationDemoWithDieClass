using System;
namespace EncapsulationDemoWithDieClass
{
    /// <summary>
    /// Represents an individual dice
    /// </summary>
    public class Die
    {
        Random rand;

        public Die()
        {
            rand = new Random();
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
        /// </summary>
        public byte Roll()
        {
            Value = (byte)rand.Next(1, 7);
            return Value;
        }
    }
}
