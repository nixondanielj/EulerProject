using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem2
    {
        public string Run()
        {
            return SequenceHelper.GenerateFibonacci().Where(i => i % 2 == 0)
                .TakeWhile(i => i < 4000000).Sum().ToString();
        }

        
    }
}
