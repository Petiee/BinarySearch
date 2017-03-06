using System;
using Library;

namespace TUI
{
    class MainClass
    {
        /// <summary>
        /// Prints the array.
        /// </summary>
        /// <param name="array">Array.</param>
        private static void PrintArray(object[] array)
        {
            Console.WriteLine ("Test Array: {0}", Show.Array (array));
        }
        /// <summary>
        /// Tests the array. And writes the result to the console.
        /// </summary>
        /// <param name="array">Array.</param>
        private static void TestArray(IComparable[] array)
        {
            PrintArray (array);

            for (int i = 0; i <= 11; i++)
            {
                int result = Search.Binary (array, i);
                if (result == -1)
                {
                    Console.WriteLine ("{0} was not found.", i);
                }
                else
                {
                    Console.WriteLine ("{0} was found in index {1}.", i, result);
                }
            }
        }

        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main (string[] args)
        {
            Generator gen = new Generator (); /// <summary>
            /// Creates new instance of Generator, so we can initialize the tests.
            /// </summary>

            TestArray (gen.NextArray(1000, 1000));
            TestArray (gen.NextArray(10, 10));
            TestArray (gen.NextArray(10, 10));
        }
    }
}