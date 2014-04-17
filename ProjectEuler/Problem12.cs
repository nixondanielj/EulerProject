using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem12
    {
        public string Run()
        {
            return SequenceHelper.GenerateTriangleNumbers()
                .First(i => GetDivisors(i).Count() > 500).ToString();
        }

        public IEnumerable<int> GetDivisors(int numerator)
        {
            yield return 1;
            yield return numerator;
            int max = (int)Math.Sqrt(numerator);
            for (int i = 2; i <= max; i++)
            {
                if (numerator % i == 0)
                {
                    yield return i;
                    yield return numerator / i;
                }
            }
        }
    }
}
