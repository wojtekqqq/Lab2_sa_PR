using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    interface IPrzedzialy
    {
        int Id { get; }
        string Name { get; }
        decimal rangeFrom();
        decimal rangeTo();
    }
}
