using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListsPrep
{
    public class ListSum
    {
        public static int Even(List<double> nums)
        {
            int total = 0;

            foreach (int num in nums)
            {
                if (num % 2 == 0)
                {
                    total += num;
                }
            }
            return total;
        }
    }
}
