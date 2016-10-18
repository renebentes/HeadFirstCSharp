namespace Page244
{
    class Locksmith
    {
        private string writtenDownCombination = null;

        public void OpenSafe(Safe safe, Owner owner)
        {
            safe.PickLock(this);
            Jewels safeContents = safe.Open(writtenDownCombination);
            ReturnContents(safeContents, owner);
        }

        public virtual void ReturnContents(Jewels safeContents, Owner owner)
        {
            owner.ReceiveContents(safeContents);
        }

        public void WriteDownCombination(string combination)
        {
            writtenDownCombination = combination;
        }
    }
}
