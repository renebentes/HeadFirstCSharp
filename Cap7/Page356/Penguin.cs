using System;

namespace Page356
{
    internal class Penguin : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Penguins can't fly!");
        }

        public override string ToString()
        {
            return $"A penguin named {base.Name}";
        }
    }
}