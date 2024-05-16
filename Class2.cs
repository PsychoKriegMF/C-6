using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_6
{
    internal class Class2
    {
        public int Cel { get; set; }
        public int Far { get; set; }
        public string name1 { get; set; }
        public string name2 { get; set; }
        public double Convert()
        {
            return Cel + 273.15;
        }
        public void print2()
        {
            Console.WriteLine($"{name1} -> {name2} = {Convert()}");
        }
    }
}
