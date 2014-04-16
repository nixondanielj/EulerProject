using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class PrimeTester
    {
        

        public static bool IsPrime(long n)
        {
            return IsPrime(n, 10);
        }
        public static bool IsPrime(long n, int k)
        {
            bool isPrime = true;
            if ((isPrime = n >= 2) && n != 2 && n != 3 && (isPrime = n % 2 != 0))
            {
                long s = n - 1;
                while (s % 2 == 0)
                {
                    s >>= 1;
                }
                Random rng = new Random();
                for (int i = 0; i < k; i++)
                {
                    BigInteger temp = s,
                        a = rng.Next(3, n > int.MaxValue ? int.MaxValue : (int)n - 1),
                        mod = BigInteger.ModPow(a, temp, n);
                    while (temp != n - 1 && mod != 1 && mod != n - 1)
                    {
                        mod = (mod * mod) % n;
                        temp = temp * 2;
                    }
                    if (mod != n - 1 && temp % 2 == 0)
                    {
                        isPrime = false;
                    }
                }
            }
            return isPrime;
        }
    }
}
