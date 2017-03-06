using System;

namespace Library
{
    public class ComparisonCountedInt : IComparable
    {
        private int value;
        private int comparisonCount;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Library.ComparisonCountedInt"/> class. And sets up the comparisonCounter.
        /// </summary>
        /// <param name="value">Value.</param>
        public ComparisonCountedInt (int value)
        {
            this.value = value;
            this.comparisonCount = 0;
        }

        /// <summary>
        /// Compares this object to other.
        /// </summary>
        /// <returns>An integer, indicating if the object proceds or follows.</returns>
        /// <param name="other">Other. The object to be compared to.</param>
        public int CompareTo (object other)
        {
            //return this.value - other.value;
            this.comparisonCount++;
            var v = (ComparisonCountedInt) other;
            return value.CompareTo (v.value);
        }

        /// <summary>
        /// Gets the comparison count.
        /// </summary>
        /// <returns> Integer, of the comparisons counted. </returns>
        /// <value>The comparison count.</value>
        public int ComparisonCount {
            get {
                return this.comparisonCount;
            }
        }

        /// <summary>
        /// Sums over the comparisons in the given array.
        /// </summary>
        /// <returns> Integer, all comparisons in the array.</returns>
        /// <param name="array"> Array. </param>
        public static int CountComparisons (ComparisonCountedInt [] array)
        {
            int counter = 0;

            foreach (ComparisonCountedInt i in array) 
            {
                counter += i.ComparisonCount;
            }
            return counter;
        }
    }
}