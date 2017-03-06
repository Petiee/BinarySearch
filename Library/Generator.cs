using System;

namespace Library
{
    public class Generator
    {
        public delegate IComparable Initializer(int value);

        public static IComparable SimpleInitializer(int value)
        {
            return value;
        }

        private Random rand;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Library.Generator"/> class.
        /// </summary>
        public Generator()
        {
            this.rand = new Random ();
        }
        /// <summary>
        /// Gets the next random value, from the interval [0;maxvalue].
        /// </summary>
        /// <returns>An integer in the interval [0;maxvalue]. </returns>
        /// <param name="maxValue">Max value. The max value the int is allowed to have. </param>
        public int NextInt(int maxValue)
        {
            return this.rand.Next (maxValue);
        }

        public IComparable [] NextArray (long size1, long maxValue1)
        {/// <summary>
         /// NextArray, is the function that initialize an Array with the specificated size. We need to do the following adjustment to the Array size: size less than 1000, so we dont genrate any arithmetic overflows.
         /// </summary>
         /// <returns>The array. With the length of size, but max 10000. </returns>
         /// <param name="size">Size. The length of the Array</param>
         /// <param name="maxValue">Max value. The generator produces a random number between, 0 and Max value, for every index. </param>
         /// <param name="initializer">Initializer. Add numbers to the index and sorts it after. </param>
            int size = (int) size1;
            int maxValue = (int) maxValue1;
            if (size < 10000) {
                return this.NextArray (size, maxValue,
                    new Initializer (Generator.SimpleInitializer));
            } else {
                return this.NextArray (10000, 10000,
                                      new Initializer (Generator.SimpleInitializer));
            }
                
        }

        public IComparable [] NextArray (int size, int maxValue, Initializer initializer)
        { 
            IComparable[] array = new IComparable[size]; // creates an Array with lenght of size.

            for (int i = 0; i < size; i++)
            {
                array[i] = initializer(rand.Next(maxValue)); // add a random number to the index (i)
            }
            Array.Sort(array); // sorts the array, so we can use Binary search on it.

            return array;
        }

        public ComparisonCountedInt [] ComparisonArray ()
        {
            
        }
    }
}