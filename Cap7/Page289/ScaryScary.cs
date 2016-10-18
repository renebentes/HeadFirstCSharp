using System;

namespace Page289
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        readonly int numberOfScaryThings;

        public ScaryScary(string funnyThingIHave, int numberOfScaryThings)
            : base(funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }

        public string ScaryThingIHave
        {
            get
            {
                return "I have " + numberOfScaryThings + " spiders";
            }
        }

        public void ScareLittleChildren()
        {
            Console.WriteLine("Boo! Gotcha!" + base.funnyThingIHave);
        }
    }
}
