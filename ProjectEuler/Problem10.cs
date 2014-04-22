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
            return SequenceHelper.GeneratePrimes()
                .TakeWhile(p => p < 2000000)
                .Aggregate(new long(), (a,b)=> a+b)
                .ToString();
        }
    }
}
