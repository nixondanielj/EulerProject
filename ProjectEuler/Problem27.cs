using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem27
    {
        public string Run()
        {
            int longest = 0;
            int product = 0;
            for(int a = -999; a < 1000; a++)
            {
                for (int b = -999; b < 1000; b++)
                {
                    for (int n = 0; PrimeTester.IsPrime((int)Math.Pow(n, 2) + a * n + b); n++)
                    {
                        if (n > longest)
                        {
                            longest = n;
                            product = a * b;
                        }
                    }
                }
            }
            return product.ToString();
        }
    }
}
