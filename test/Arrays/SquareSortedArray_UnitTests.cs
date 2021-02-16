using System.Runtime;
using System.Runtime.InteropServices;
using System.Reflection;
using System;
using Xunit;
using lib;

namespace test.Arrays
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/521/introduction/3240/
    /// </summary>
    public class SquareSortedArray_UnitTests
    {
        [Fact]
        public void SimpleTest_PositiveArray()
        {
            var A = new int[3] { 1, 4, 9 };
            int[] result = new SquareSortedArray().Go(A);

            var E = new int[3] { 1, 16, 81 };
            Assert.Equal(E, result);
        }

        [Fact]
        public void SimpleTest_PositiveAndNegativeArray()
        {
            var A = new int[5] { -5, -2, 1, 4, 9 };
            int[] result = new SquareSortedArray().Go(A);

            var E = new int[5] { 1, 4, 16, 25, 81 };
            Assert.Equal(E, result);
        }
    }
}