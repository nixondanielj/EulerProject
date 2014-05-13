using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem29
    {
        public string Run()
        {
            return new HashSet<BigInteger>(
                Enumerable.Range(2, 99).SelectMany(
                a => Enumerable.Range(2, 99).Select(
                    b => BigInteger.Pow(a, b)))
                ).Count.ToString();
        }
    }
}
