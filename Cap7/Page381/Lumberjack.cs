using System;
using System.Collections.Generic;

namespace Page381
{
    internal class Lumberjack
    {
        private string name;
        private Stack<Flapjack> meal;

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int FlapjackCount
        {
            get
            {
                return meal.Count;
            }
        }

        public Lumberjack(string name)
        {
            this.name = name;
            meal = new Stack<Flapjack>();
        }

        public void TakeFlapjacks(Flapjack food, int howMany)
        {
            for (int i = 0; i < howMany; i++)
                meal.Push(food);
        }

        public void EatFlapjacks()
        {
            Console.WriteLine($"{name}'s eating flapjacks!");
            while (meal.Count > 0)
                Console.WriteLine($"{name} eat a {meal.Pop().ToString().ToLower()} flapjacks");
        }
    }
}