using System;
using System.Collections.Generic;

namespace Page356
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

            IEnumerable<Bird> upcastDucks = ducks;

            var birds = new List<Bird>();
            birds.Add(new Bird { Name = "Feathers" });
            birds.AddRange(upcastDucks);
            birds.Add(new Penguin { Name = "George" });

            foreach (var bird in birds)
            {
                Console.WriteLine(bird);
            }

            Console.ReadKey();
        }
    }
}