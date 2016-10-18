namespace BeeHiveManagementSystem2._0
{
    public class Bee
    {
        readonly double wheight;

        public virtual int ShiftsLeft { get { return 0; } }

        public Bee(double wheight)
        {
            this.wheight = wheight;
        }

        public virtual double GetHoneyConsumption()
        {
            double totalConsumption = 0;

            if (ShiftsLeft == 0)
                totalConsumption += 7.5;
            else
                totalConsumption = 9 + ShiftsLeft;

            if (wheight > 150)
                totalConsumption *= 1.35;

            return totalConsumption;
        }
    }
}
