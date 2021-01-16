using System;

namespace EncapsulationDemoWithDieClass
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Die[] dice = new Die[5];
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Die();
                Console.WriteLine(dice[i].Value);
            }

            Console.ReadKey();

            // Cannot set Value because it's private
            // die1.Value = 6;
        }
    }
}
