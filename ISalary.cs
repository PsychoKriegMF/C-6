using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_6
{
    public interface ISalary
    {
        public string Name { get; set; }
        public int WorkDay {  get; set; }
        public double CalculateSalary();
    }
}
