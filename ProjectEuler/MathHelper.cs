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
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    yield return i;
                    yield return n / i;
                }
            }
        }
    }
}
