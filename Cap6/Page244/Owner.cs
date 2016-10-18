using System;

namespace Page244
{
    class Owner
    {
        private Jewels returnedContents;

        public void ReceiveContents(Jewels safeContents)
        {
            returnedContents = safeContents;
            Console.WriteLine("Thank you for returning my jewels! " + safeContents.Sparkle());
        }
    }
}
