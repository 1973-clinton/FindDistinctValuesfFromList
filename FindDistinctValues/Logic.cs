using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDistinctValues
{
    public static class Logic<T>
    {
        public static List<T> GetDistinct(List<T> input)
        {
            return input.Distinct().ToList();
        }           

    }
}
