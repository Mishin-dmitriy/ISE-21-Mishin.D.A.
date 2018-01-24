using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    class DockOverflowException : Exception
    {
        public DockOverflowException() :
            base("В доках нет свободных мест")
        { }
    }
}
