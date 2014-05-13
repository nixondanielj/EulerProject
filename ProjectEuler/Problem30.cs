using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem30
    {
        public string Run()
        {
            int max = 0;
            // proves the point at which adding further 9^5s will no longer result in longer numbers
            // we can assume that numbers after this point cannot be reached by using fifth powers
            for (int i = 1; max.ToString().Length >= i; i++)
            {
                max += (int)Math.Pow(9, 5);
            }
            return Enumerable.Range(10, max)
                .Where(i =>
                    i == i.ToString().Aggregate(new long(), (l, n) => l += (int)Math.Pow(char.GetNumericValue(n), 5)))
                .Sum().ToString();
        }
    }
}
