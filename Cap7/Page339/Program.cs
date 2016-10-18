using System;
using System.Collections.Generic;

namespace Page339
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var shoeCloset = new List<Shoe>();
            shoeCloset.Add(new Shoe { Style = Style.Sneakers, Color = "Black" });
            shoeCloset.Add(new Shoe { Style = Style.Clogs, Color = "Brown" });
            shoeCloset.Add(new Shoe { Style = Style.Wingtips, Color = "Black" });
            shoeCloset.Add(new Shoe { Style = Style.Loafers, Color = "White" });
            shoeCloset.Add(new Shoe { Style = Style.Sneakers, Color = "Red" });
            shoeCloset.Add(new Shoe { Style = Style.Sneakers, Color = "Green" });

            var numberOfShoes = shoeCloset.Count;
            foreach (var shoe in shoeCloset)
            {
                shoe.Style = Style.Flipflops;
                shoe.Color = "Orange";
            }

            shoeCloset.RemoveAt(4);

            var thirdShoe = shoeCloset[3];
            var secondShoe = shoeCloset[2];

            shoeCloset.Clear();

            shoeCloset.Add(thirdShoe);

            if (shoeCloset.Contains(secondShoe))
                Console.WriteLine("That's surprising.");
        }
    }
}