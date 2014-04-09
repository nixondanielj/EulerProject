using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem7
    {
        public string Run()
        {
            return PrimeHelper.GeneratePrimes()
                .Take(10001).Last().ToString();
        }

        public IEnumerable<int> InfiniteRange(int start = 0)
        {
            for (; true; start++)
            {
                yield return start;
            }
        }
    }
}
