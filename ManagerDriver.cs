using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_6
{
    public class ManagerDriver : IWorker, IManager
    {
        List<IWorker> workers;
        public bool IsWorking { get; set; }
        public string Work()
        {
            return "Водитель работает";
        }
        public string Manager()
        {
            return "Управляет водителями";
        }
    }
}
