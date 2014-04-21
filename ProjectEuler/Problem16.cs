using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ProjectEuler
{
    class Problem16
    {
        public string Run()
        {
            // what would we do without BigInteger?
            // probably write our own implementation...
            return BigInteger.Pow(2, 1000).ToString()
                .Select(c => char.GetNumericValue(c)).Sum().ToString();
        }
    }
}
