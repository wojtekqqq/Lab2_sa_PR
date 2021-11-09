using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    interface ICalculator
    {
        string Name { get; }
        decimal GetIntegralValue(IFunction function, decimal rangeFrom, decimal rangeTo);
    }
}
