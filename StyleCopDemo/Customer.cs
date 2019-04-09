using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyleCopDemo
{
    class Customer
    {
#pragma warning disable SA1401 // Fields must be private
        public string Name;
#pragma warning restore SA1401 // Fields must be private
    }
}
