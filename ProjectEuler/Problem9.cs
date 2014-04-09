using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem9
    {
        public string Run()
        {
            for (int b = 1; true; b++)
            {
                for (int a = 1; a < b; a++)
                {
                    double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                    if (a + b + c == 1000)
                    {
                        return (a * b * c).ToString();
                    }
                }
            }
        }
    }
}
