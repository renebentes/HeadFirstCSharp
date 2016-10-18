using System;

namespace Page356
{
    internal class Bird
    {
        public string Name { get; set; }

        public virtual void Fly()
        {
            Console.WriteLine("Flap,flap");
        }

        public override string ToString()
        {
            return $"A bird named {Name}";
        }
    }
}