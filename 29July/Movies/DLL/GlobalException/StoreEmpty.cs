using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagerTask.GlobalException
{
    internal class StoreEmpty : Exception
    {
        public StoreEmpty(string message) : base(message) { }
    }
}
