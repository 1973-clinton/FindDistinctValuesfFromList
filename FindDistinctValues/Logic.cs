using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDistinctValues
{
    public static class Logic
    {
        public static List<string> GetDistinct(List<string> input)
        {
            return input.Distinct().ToList();
        }           

    }
}
