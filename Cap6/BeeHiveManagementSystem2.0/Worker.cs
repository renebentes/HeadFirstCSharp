namespace BeeHiveManagementSystem2._0
{
    public class Worker : Bee
    {
        string currentJob = string.Empty;

        public string CurrentJob
        {
            get
            {
                return currentJob;
            }
        }

        public override int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
        }

        readonly string[] jobsICanDo;
        int shiftsToWork;
        int shiftsWorked;

        public Worker(double wheight, string[] jobsICanDo)
            : base(wheight)
        {
            this.jobsICanDo = jobsICanDo;
        }

        public bool DoThisJob(string job, int shifts)
        {
            if (!string.IsNullOrEmpty(currentJob))
                return false;

            foreach (var j in jobsICanDo)
                if (j == job)
                {
                    currentJob = job;
                    shiftsToWork = shifts;
                    shiftsWorked = 0;
                    return true;
                }

            return false;
        }

        public bool WorkOneShift()
        {
            if (string.IsNullOrEmpty(currentJob))
                return false;

            shiftsWorked++;

            if (shiftsWorked > shiftsToWork)
            {
                shiftsWorked = 0;
                shiftsToWork = 0;
                currentJob = "";

                return true;
            }
            else
                return false;
        }
    }
}
