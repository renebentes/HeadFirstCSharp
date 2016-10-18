using System;

namespace Page289
{
    class FunnyFunny : IClown
    {
        protected string funnyThingIHave;

        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }

        public string FunnyThingIHave
        {
            get
            {
                return "Honk honk! I have a " + funnyThingIHave;
            }
        }

        public void Honk()
        {
            Console.WriteLine(this.FunnyThingIHave);
        }
    }
}