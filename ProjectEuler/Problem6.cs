using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem6
    {
        public string Run()
        {
            return (Math.Pow(Enumerable.Range(1, 100).Sum(), 2) - Enumerable.Range(1, 100).Select(x => Math.Pow(x, 2)).Sum()).ToString();
        }
    }
}
