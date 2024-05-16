using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_6
{
    public class Driver : IWorker
    {
        public bool IsWorking { get; set; }
        public string Work()
        {
            return "Водитель работает";
        }
    }
}
