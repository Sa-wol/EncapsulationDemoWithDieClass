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
        byte minValue;
        byte maxValue;

        static Die() // Static constructors are called once for all instances of this class
        {
            rand = new Random();
        }

        public Die():this(1, 6)
        {
            // minValue = 1;
            // maxValue = 6;
            // Roll(); // Roll die on creation to generate first random number
        }

        /// <summary>
        /// Creates a die with numbers between the minimum
        /// and maximum values
        /// </summary>
        /// <param name="minValue">The inclusive lower bound</param>
        /// <param name="maxValue">The inclusive maximum bound</param>
        public Die(byte minValue, byte maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
            Roll();
        }

        /// <summary>
        /// Face up value of die
        /// </summary>
        public byte Value { get; private set;  }

        public bool IsHeld { get; set; }

        /// <summary>
        /// Roll a new random value between minimum and maximum value
        /// and return the newly rolled value
        /// If the die is held, the current value will be returned
        /// and no new value generated
        /// </summary>
        public byte Roll()
        {
            if (!IsHeld) // If die is not held
            {
                // Add 1 to maxValue due to the upper bound being exclusive
                Value = (byte)rand.Next(minValue, maxValue + 1);
            }
            return Value;
        }
    }
}
