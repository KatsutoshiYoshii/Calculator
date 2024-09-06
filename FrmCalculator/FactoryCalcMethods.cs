using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal enum EMethods
    {
        Puls,
        Minus,
        Multply,
        Division
    }

    internal static class FactoryCalcMethods
    {
        internal static ICalc Factory(int method)
        {
            switch (method)
            {
                case (int)EMethods.Puls:
                    return new Plus();
                case (int)EMethods.Minus:
                    return new Minus();
                case (int)EMethods.Multply:
                    return new Multiply();
                case (int)EMethods.Division:
                    return new Division();
                default:
                    return new Plus();
            }
        }
    }
}
