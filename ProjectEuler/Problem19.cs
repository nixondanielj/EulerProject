using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem19
    {
        public string Run()
        {
            return SequenceHelper.GenerateSequence(DateTime.Parse("1/1/1901"),
                date => date.AddDays(1))
                .TakeWhile(d => d < DateTime.Parse("12/31/2000"))
                .Where(d => d.Day == 1 && d.DayOfWeek == DayOfWeek.Sunday)
                .Count().ToString();
        }
    }
}
