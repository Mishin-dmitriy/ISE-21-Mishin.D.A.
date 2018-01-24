using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    class DockAlreadyHaveException : Exception
    {
        public DockAlreadyHaveException() : base("Такой корабль уже есть в доках") { }
    }
}
