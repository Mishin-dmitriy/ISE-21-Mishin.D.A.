using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    class DockIndexOutOfRangeException : Exception
    {
        public DockIndexOutOfRangeException() :
            base("На парковке нет корабля по такому месту")
        { }
    }
}
