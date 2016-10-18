using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page275
{
    interface IStingPatrol
    {
        int AlertLevel { get; }
        int StingerLentght { get; set; }
        bool LookForEnemies();
        int SharpenStinger(int lenght);
    }
}
