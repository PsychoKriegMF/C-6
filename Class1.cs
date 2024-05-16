using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_6
{
    public class Class1 : IConverter
    {
        public int Cel { get; set; }
        public int Far { get; set; }
        public string name1 { get; set; }
        public string name2 { get; set; }
        public double Convert(int t)
        {
            return 1.8 * t + 32;
        }
    }
}
