using System;

namespace EncapsulationDemoWithDieClass
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Die die1 = new Die();
            // Cannot set Value because it's private
            // die1.Value = 6;
        }
    }
}
