using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem10
    {
        public string Run()
        {
            long l = 0;
            return PrimeHelper.GeneratePrimes()
                .TakeWhile(p => p < 2000000)
                .Aggregate(l, (a,b)=> a+b)
                .ToString();
        }
    }
}
