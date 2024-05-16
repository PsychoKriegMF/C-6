using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_6
{
    public class FiveUgolnic : INUgol
    {

        public double Height { get; set; }
        public double Base { get; set; }
        public double Corner { get; set; }
        public int Count { get; set; }
        public List<Double> Length { get; set; }
        public double S()
        {
            double ans = P() / 2;
            foreach(var item in Length)
            {
                ans *= ans - item;
            }
            return Math.Sqrt(ans);
        }
        public double P()
        {
            double ans = 0;
            foreach (var item in Length)
            {
                ans += item;
            }
            return ans;
            //return Length.Sum(); //второй вариант
        }
        
    }
}
