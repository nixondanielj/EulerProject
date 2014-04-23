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
                    int sum = MathHelper.GetDivisors(i).Sum();
                    return sum < 10000 && MathHelper.GetDivisors(sum).Sum() == i && i != sum;
                })
                .Sum().ToString();
        }

        
    }
}
