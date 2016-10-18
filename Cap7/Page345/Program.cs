using System;
using System.Collections.Generic;

namespace Page345
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var ducks = new List<Duck>
            {
                new Duck { Kind=KindOfDuck.Mallard, Size=17 },
                new Duck { Kind=KindOfDuck.Muscovy, Size=18 },
                new Duck { Kind=KindOfDuck.Decoy, Size=14 },
                new Duck { Kind=KindOfDuck.Muscovy, Size=11 },
                new Duck { Kind=KindOfDuck.Mallard, Size=14 },
                new Duck { Kind=KindOfDuck.Decoy, Size=13 }
            };

            ducks.Sort();
            PrintDucks(ducks);

            var sizeComparer = new DuckComparerBySize();
            ducks.Sort(sizeComparer);
            PrintDucks(ducks);

            var kindComparer = new DuckComparerByKind();
            ducks.Sort(kindComparer);
            PrintDucks(ducks);

            var comparer = new DuckComparer();
            comparer.SortBy = SortCriteria.KindThenSize;
            ducks.Sort(comparer);
            PrintDucks(ducks);

            comparer.SortBy = SortCriteria.SizeThenKind;
            ducks.Sort(comparer);
            PrintDucks(ducks);

            Console.ReadKey();
        }

        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (var duck in ducks)
                Console.WriteLine(duck);
            Console.WriteLine("End of Ducks!");
        }
    }
}