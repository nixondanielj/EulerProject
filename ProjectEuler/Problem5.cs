using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem5
    {
        public string Run()
        {
            var divisors = new int[] { 19, 17, 16, 13, 11, 9, 7, 5, 4, 3, 2 };
            for (int product = 19; true; product+=19)
            {
                if (divisors.All(d => product % d == 0))
                {
                    return product.ToString();
                }
            }
        }
    }
}
