using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    static class MathHelper
    {
        public static IEnumerable<int> GetDivisors(int n)
        {
            yield return 1;
            double sqrt = Math.Sqrt(n);
            for (int i = 2; i <= sqrt; i++)
            {
                if (n % i == 0)
                {
                    yield return i;
                    if (i != sqrt)
                    {
                        yield return n / i;
                    }
                }
            }
        }
    }
}
