using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_6
{
    public class Manager : ISalary, IPrint
    {     
        public string Name { get; set; }
        public int WorkDay { get; set; }
        public double SalaryDay = 1000;

        public Manager(string name, int day) 
        {
            this.Name = name;
            this.WorkDay = day;
        }
        public double CalculateSalary()
        {
            return SalaryDay * WorkDay;
        }
        public void Print()
        {
            Console.WriteLine($"Name: {Name}, WorkDay : {WorkDay}, Salary: {CalculateSalary()}");
        }
    }
}
