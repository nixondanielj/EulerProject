using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem2
    {
        public string Run()
        {
            return GenerateFibonacci().Where(i => i % 2 == 0)
                .TakeWhile(i => i < 4000000).Sum().ToString();
        }

        IEnumerable<int> GenerateFibonacci()
        {
            int a = 1, b = 2;
            yield return a;
            yield return b;
            while (true)
            {
                int swap = b;
                b += a;
                a = swap;
                yield return b;
            }
        }
    }
}
