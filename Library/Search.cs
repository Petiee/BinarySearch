using System;

namespace Library
{
    public static class Search
    {/// <summary>
    /// Binary the specified array and target.
    /// </summary>
    /// <param name="array">Array.</param>
    /// <param name="target">Target.</param>
        public static int Binary (IComparable [] array, IComparable target)
        {
            long low = 0;
            long high = array.Length - 1;

            if (array.Length == 0) {// We check if the array is empty.
                return -1;
            } if (array [0].CompareTo (target) <= 0 && array [high].CompareTo (target) >= 0) { // We check whether the target is inside the bounds of the array.
                while (low <= high) {
                    int mid = (int)(((high + low) / 2));
                    IComparable midVal = array [mid];
                    int relation = midVal.CompareTo (target);

                    if (relation < 0) {
                        low = mid + 1;
                    } else if (relation > 0) {
                        high = mid - 1;
                    } else {
                        return mid;
                    }
                }
            }
            return -1;
        }
        /// <summary>
        /// Linear Seach, in worst case, goes through the whole array, also if target is not in array.
        /// </summary>
        /// <param name="array">Array. To be run through, to see if target is part of.</param>
        /// <param name="target">Target. The element that is compared to elements in array. </param>
        /// <returns> integer, equal to the index of the array, and how many comparisons that have been made. If the target is not in the array, return -1. </returns>
        public static int Linear (IComparable [] array, IComparable target)
        {
            long len = array.Length;

            for (int i = 0; i < len; i++) {
                if (array [i] == target) 
                    return i;
            }
            return -1;
        }
    }
}