using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class SequenceHelper
    {
        public static IEnumerable<int> GeneratePrimes(int start = 2)
        {
            return GenerateSequence(start).Where(i=>PrimeTester.IsPrime(i));
        }

        public static IEnumerable<int> GenerateFibonacci()
        {
            int a = 1, b = 2;
            yield return a;
            yield return b;
            while (true)
            {
                int swap = b;
                b += a;
                a = swap;
                yield return b;
            }
        }

        public static IEnumerable<int> GenerateSequence(int start=0)
        {
            while (true)
            {
                yield return start++;
            }
        }
    }
}
