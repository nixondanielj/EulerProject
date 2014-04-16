using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem7
    {
        public string Run()
        {
            return SequenceHelper.GeneratePrimes()
                .Take(10001).Last().ToString();
        }
    }
}
