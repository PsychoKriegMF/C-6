using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_6
{
    internal class Buhgalter
    {
        public string Name;
        public Buhgalter(string Name) 
        {
            this.Name = Name;
        }
        public double Сalculation(ISalary a, int day)
        {
            return (a.CalculateSalary() / day) * 0.13 * a.WorkDay;
        }
        
    }
}
