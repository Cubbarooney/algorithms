using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    public static class BubbleSort
    {
        public static void DoBubbleSort<T>(this IList<T> list) where T : IComparable
        {
            performBubbleSort(list);
        }

        // Written by Cubby without looking up pseudo code
        // TODO: There is a slight optimization for Bubble Sort
        // TODO: Handle a read only list
        private static void performBubbleSort<T>(IList<T> list) where T : IComparable
        {
            // Set true if there was a swap that was performed.
            bool hadSwap = false;
            
            do
            {
                hadSwap = false;
                for(int i = 0; i < list.Count - 1; i++)
                {
                    var compareResult = list[i].CompareTo(list[i + 1]);
                    if(compareResult > 0)
                    {
                        hadSwap = true;
                        list.Swap(i, i + 1);
                    }
                }
            } while (hadSwap);
        }
    }
}
