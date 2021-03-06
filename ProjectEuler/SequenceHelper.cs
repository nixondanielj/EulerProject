﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class SequenceHelper
    {
        public static IEnumerable<T> GenerateSequence<T>(T start, Func<T, T> transform)
        {
            while (true)
            {
                yield return start;
                start = transform(start);
            }
        }

        public static IEnumerable<long> GenerateCollatzSequence(long start)
        {
            yield return start;
            while (start != 1)
            {
                if (start % 2 == 0)
                {
                    start /= 2;
                }
                else
                {
                    start = start * 3 + 1;
                }
                yield return start;
            }
        }

        public static IEnumerable<int> GenerateTriangleNumbers()
        {
            int start = 0;
            return GenerateSequence(1).Select(i => start += i);
        }

        public static IEnumerable<int> GeneratePrimes(int start = 2)
        {
            return GenerateSequence(start).AsParallel().AsOrdered().Where(i=>PrimeTester.IsPrime(i));
        }

        public static IEnumerable<BigInteger> GenerateFibonacci()
        {
            BigInteger a = 1, b = 1;
            yield return a;
            yield return b;
            while (true)
            {
                BigInteger swap = b;
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

        internal static IEnumerable<int> GenerateAbundantNumbers()
        {
            return GenerateSequence(2).Where(i => MathHelper.GetDivisors(i).Sum() > i);
        }
    }
}
