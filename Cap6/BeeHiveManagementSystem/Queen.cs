using System.Text;

namespace BeeHiveManagementSystem
{
    public class Queen
    {
        readonly Worker[] workers;
        int shiftNumber;

        public Queen(Worker[] workers)
        {
            this.workers = workers;
        }

        public bool AssignWork(string job, int shifts)
        {
            foreach (var worker in workers)
                if (worker.DoThisJob(job, shifts))
                    return true;

            return false;
        }

        public string WorkTheNextShift()
        {
            shiftNumber++;
            var report = new StringBuilder("Report for shift #" + shiftNumber + "\r\n");

            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].WorkOneShift())
                    report.Append("Worker #" + (i + 1) + " finished the job\r\n");
                if (string.IsNullOrEmpty(workers[i].CurrentJob))
                    report.Append("Worker #" + (i + 1) + " is not working\r\n");
                else
                {
                    if (workers[i].ShiftsLeft > 0)
                        report.Append("Worker #" + (i + 1) + " is doing '" + workers[i].CurrentJob
                            + "' for " + workers[i].ShiftsLeft + " more shifts\r\n");
                    else
                        report.Append("Worker #" + (i + 1) + " will be done with '"
                             + workers[i].CurrentJob + "' after this shift\r\n");
                }
            }

            return report.ToString();
        }
    }
}
