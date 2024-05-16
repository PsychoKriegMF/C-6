using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_6
{
    public interface IConverter
    {
        public string name1 {  get; set; }
        public string name2 { get; set; }   

        public double Convert(int t);
    }
}
