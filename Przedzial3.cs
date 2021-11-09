using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Przedzial3 : IPrzedzialy
    {
        public int Id => 3;
        public string Name => "Przedział trzeci od -5 do 0";

        public decimal rangeFrom()
        {
            return -5;
        }

        public decimal rangeTo()
        {
            return 0;
        }
    }
}
