using NUnit.Framework;
using System;
using Library;

namespace Tests
{
    [TestFixture ()]
    public class Test
    {
        [Test ()]
        /// <summary>
        /// Tests the Binary Search algoritm, we want to see what happens when our target is less than any element in the array.
        /// </summary>
        public void TestTooLowBS ()
        {
            Assert.AreEqual (-1, Search.Binary(new IComparable [] { 3, 4, 5, 6, 7, 8, 9 } , 1 ), "1NotIn3456789" );
        }

        [Test ()]
        /// <summary>
        /// Tests the Binary Search algoritm, we want to see what happens when our target is higher than any element in the array.
        /// </summary>
        public void TestTooHighBS ()
        {
            Assert.AreEqual (-1, Search.Binary (new IComparable [] { 3, 4, 5, 6, 7, 8, 9 }, 10), "10NotIn3456789");
        }

        [Test ()]
        /// <summary>
        /// Tests the Binary Search algoritm, we want to see what happens when our target is part of the array.
        /// </summary>
        public void TestElementBS ()
        {
            Assert.AreNotEqual (-1, Search.Binary (new IComparable [] { 3, 4, 5, 6, 7, 8, 9 }, 4), "4IsIn3456789");
            Assert.AreNotEqual (-1, Search.Binary (new IComparable [] { 3, 4, 5, 6, 7, 8, 9 }, 5), "5IsIn3456789");
            Assert.AreNotEqual (-1, Search.Binary (new IComparable [] { 3, 4, 5, 6, 7, 8, 9 }, 3), "3IsIn3456789");
            Assert.AreNotEqual (-1, Search.Binary (new IComparable [] { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, 11), "11IsIn3456789101112");
        }

        [Test ()]
        /// <summary>
        /// Tests the Binary Search algoritm, we want to see what happens when our array is empty, we check all numbers from -100 to 100.
        /// </summary>
        public void TestEmptyArrayBS ()
        {
            for (int i = -100; i <= 100; i++) {
                Assert.AreEqual (-1, Search.Binary ((new IComparable [] { }), i), "-100To100EmptyArray");
            }
        }
        [Test ()]
        /// <summary>
        /// Tests the Binary Search algoritm, we want to see what happens when our array is empty, we check all numbers from -100 to 100.
        /// </summary>
        public void TestEmptyArrayBS1 ()
        {
            for (int i = -100; i <= 100; i++) {
                Assert.That(-1 == (Search.Binary ((new IComparable [] { }), i)));
            }
        }

        [SetUp ()]
        public void TestRunningTime ()
        {
            Generator gen = new Generator ();
            var sortedArray = (gen.NextArray (10, 10));
        }

        [Test ()]
        /// <summary>
        /// Tests the Binary Search algoritm, we use the IComparable class to check how many comparisons we make, which should be less than [1+log_2(n)]. 
        /// </summary>
        public void TestRunningTime () // fejler: specified cast is not valid
        {
           
        }

        [Test ()]
        /// <summary>
         /// Tests the Binary Search algoritm, we use the IComparable class to check how many comparisons we make, which should be less than [1+log_2(n)]. 
         /// </summary>
        public void TestCompareMethod () // fejler: specified cast is not valid
        {
            var n = new ComparisonCountedInt (20);
            var i = new ComparisonCountedInt (30);
            Assert.AreNotEqual (-10,n.CompareTo(i));
        }
    }
}