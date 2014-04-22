using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem20
    {
        public string Run()
        {
            return GetFactorial(100).ToString()
                .Select(c=>char.GetNumericValue(c))
                .Sum().ToString();
        }

        BigInteger GetFactorial(int a)
        {
            if(a < 1) throw new ArgumentException("a must be > 0");
            return Enumerable.Range(1, a - 1).Aggregate(new BigInteger(1), (b, i) => b *= i);
        }
    }
}
