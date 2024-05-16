﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_6
{
    public class Square : Figure
    {
        public int A { get; set; }
        public int B { get; set; }
        public Square(int A, int B)
        {
            this.A = A;
            this.B = B;
        }
        public override double S()
        {
            return A * B;
        }
        public override double P()
        {
            return (A + B) * 2;
        }
    }
}
