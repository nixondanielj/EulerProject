using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem15
    {
        public string Run()
        {
            long[,] lattice = new long[21,21];
            // start with a single route, then count backwards
            lattice[0,0] = 1;
            for (int x = 0; x < lattice.GetLength(0); x++)
            {
                for(int y = 0; y < lattice.GetLength(1); y++)
                {
                    if (x == 0 & y == 0) continue;
                    long total = 0;
                    if (x != 0)
                    {
                        total += lattice[x - 1, y];
                    }
                    if (y != 0)
                    {
                        total += lattice[x, y - 1];
                    }
                    lattice[x, y] = total;
                }
            }
            return lattice[20, 20].ToString();
        }
    }
}
