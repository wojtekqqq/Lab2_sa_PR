using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Przedzial2 : IPrzedzialy
    {
        public int Id => 2;
        public string Name => "Przedział drugi od -5 do 20";

        public decimal rangeFrom()
        {
            return -5;
        }

        public decimal rangeTo()
        {
            return 20;
        }
    }
}
