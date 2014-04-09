using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem1
    {
        public string Run()
        {
            return (from i in Enumerable.Range(0, 1000)
                    where i % 3 == 0 || i % 5 == 0
                    select i).Sum().ToString();
        }
    }
}
