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
            for (int product = 21; true; product++)
            {
                if (Enumerable.Range(2, 20).All(d => product % d == 0))
                {
                    return product.ToString();
                }
            }
        }
    }
}
