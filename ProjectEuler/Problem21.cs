using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem21
    {
        public string Run()
        {
            return Enumerable.Range(1, 9999)
                .Where(i => 
                {
                    int sum = GetDivisors(i).Sum();
                    return sum < 10000 && GetDivisors(sum).Sum() == i && i != sum;
                })
                .Sum().ToString();
        }

        private IEnumerable<int> GetDivisors(int n)
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
