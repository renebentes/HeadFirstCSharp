using System;

namespace Page244
{
    class JewelThief : Locksmith
    {
        private Jewels stolenJeweks = null;

        public override void ReturnContents(Jewels safeContents, Owner owner)
        {
            stolenJeweks = safeContents;
            Console.WriteLine("I'm stealing the contents! " + stolenJeweks.Sparkle());
        }
    }
}
