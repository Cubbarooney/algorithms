using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    public static class Utility
    {
        public static IList<T> Swap<T>(this IList<T> list, int index1, int index2)
        {
            var temp = list[index2];
            list[index2] = list[index1];
            list[index1] = temp;
            return list;
        }
    }
}
