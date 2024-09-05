using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Plus : ICalc
    {
        public double Calc(double x, double y)
        {
            return x + y;
        }
    }

    internal class Minus : ICalc
    {
        public double Calc(double x, double y)
        {
            return x - y;
        }
    }

    internal class Multiply : ICalc
    {
        public double Calc(double x, double y)
        {
            return x * y;
        }
    }

    internal class Division : ICalc
    {
        public double Calc(double x, double y)
        {
            if(y == 0)
            {
                throw new Exception("0では割れません");
            }
            return x / y;
        }
    }
}
