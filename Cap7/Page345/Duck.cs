using System;

namespace Page345
{
    internal class Duck : IComparable<Duck>
    {
        public int Size;
        public KindOfDuck Kind;

        public void Quack()
        {
        }

        public void Swim()
        {
        }

        public void Eat()
        {
        }

        public void Walk()
        {
        }

        public int CompareTo(Duck duckToCompare)
        {
            if (this.Size > duckToCompare.Size)
                return 1;
            else if (this.Size < duckToCompare.Size)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            return $"A {Size.ToString()} inch {Kind.ToString()}";
        }
    }
}