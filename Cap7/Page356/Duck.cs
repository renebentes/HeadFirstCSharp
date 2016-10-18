using System;

namespace Page356
{
    internal class Duck : Bird, IComparable<Duck>
    {
        public int Size;
        public KindOfDuck Kind;

        public int CompareTo(Duck duckToCompare)
        {
            return Size > duckToCompare.Size ? 1 : Size < duckToCompare.Size ? -1 : 0;
        }

        public override string ToString()
        {
            return $"A {Size.ToString()} inch {Kind.ToString()}";
        }
    }
}