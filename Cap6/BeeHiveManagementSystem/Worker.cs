namespace BeeHiveManagementSystem
{
    public class Worker
    {
        private string currentJob = "";

        public string CurrentJob
        {
            get
            {
                return currentJob;
            }
        }

        public int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
        }

        readonly string[] jobsICanDo;
        int shiftsToWork;
        int shiftsWorked;

        public Worker(string[] jobs)
        {
            jobsICanDo = jobs;
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
