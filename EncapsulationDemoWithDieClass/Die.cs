using System;
namespace EncapsulationDemoWithDieClass
{
    /// <summary>
    /// Represents an individual dice
    /// </summary>
    public class Die
    {
        /// <summary>
        /// Face up value of die
        /// </summary>
        public byte Value { get; private set;  }

        public bool IsHeld { get; set; }

        // Roll method
    }
}
