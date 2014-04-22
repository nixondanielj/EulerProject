using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem17
    {
        public string Run()
        {
            return (Enumerable.Range(1, 999)
                .Select(i => GetWordLength(i)).Sum() + "onethousand".Length)
                .ToString();
        }

        private int GetWordLength(int i)
        {
            string sI = i.ToString();
            int length = 0;
            if (i > 99)
            {
                length = GetWordLengthForOnesDigit(sI.First())
                    + "hundred".Length 
                    + (sI.Substring(1).All(c=>c=='0') ? 0 : "and".Length)
                    + GetWordLength(int.Parse(sI.Substring(1)));
            }
            else if (i > 20)
            {
                length = GetWordLengthForTensDigit(sI.First())
                        + GetWordLength((int)char.GetNumericValue(sI.Last()));
            }
            else if (i > 9)
            {
                length = GetWordLengthForTeen(i);
            }
            else
            {
                length = GetWordLengthForOnesDigit(sI.First());
            }
            return length;
        }

        private int GetWordLengthForTeen(int teen)
        {
            switch (teen)
            {
                case 11:
                case 12:
                    return 6;
                case 13:
                    return 8;
                case 15:
                    return 7;
                default:
                    return GetWordLengthForOnesDigit(teen.ToString().Last()) + "teen".Length;
            }
        }

        private int GetWordLengthForTensDigit(char digit)
        {
            switch (digit)
            {
                case '2':
                case '3':
                case '8':
                case '9':
                    return 6;
                case '4':
                case '5':
                case '6':
                    return 5;
                case '7':
                    return 7;
                case '0':
                    return 0;
                default:
                    throw new ArgumentException("Argument 'digit' is not a valid digit");
            }
        }

        private int GetWordLengthForOnesDigit(char digit)
        {
            switch (digit)
            {
                case '1':
                case '2':
                case '6':
                    return 3;
                case '3':
                case '7':
                case '8':
                    return 5;
                case '4':
                case '5':
                case '9':
                    return 4;
                case '0':
                    return 0;
                default:
                    throw new ArgumentException("Argument 'digit' is not a digit 1-9");
            }
        }
    }
}
