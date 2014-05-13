using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem31
    {
        int[] coins = new int[] { 200, 100, 50, 20, 10, 5, 2, 1 };
        public string Run()
        {
            return AddCoins(new int[coins.Length], coins.Length - 1, 0)
                .ToString();
        }

        public int AddCoins(int[] currCoins, int coin, int sum)
        {
            if (sum == 200) return 1;
            int count = 0;
            for (int i = 0; coin >= 0 && sum <= 200; currCoins[coin] = ++i)
            {
                count += AddCoins(currCoins.ToArray(), coin - 1, sum);
                sum += coins[coin];
            }
            return count;
        }

        private int GetTotal(int[] currCoins)
        {
            return currCoins.Select((c, i) => coins[i] * c).Sum();
        }
    }
}
