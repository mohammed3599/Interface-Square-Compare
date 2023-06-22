﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfce_Compare
{
    internal interface IShape
    {
        double CalArea();
        int CompareTo(Square? other);
    }
    internal class Square : IShape
    {
        public double length;

        public Square(double length)
        {
            this.length = length;
        }
        public double CalArea()
        {
            return length * length;
        }

        public int CompareTo(Square? other)
        {
            if (other == null) return 1;
            return this.length > other.length ? 1 : this.length < other.length ? -1 : 0;
        }
    }



}
