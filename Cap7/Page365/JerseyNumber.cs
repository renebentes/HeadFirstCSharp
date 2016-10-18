namespace Page365
{
    internal class JerseyNumber
    {
        public string Player { get; private set; }
        public int YearRetired { get; private set; }

        public JerseyNumber(string player, int yearRetired)
        {
            Player = player;
            YearRetired = yearRetired;
        }
    }
}