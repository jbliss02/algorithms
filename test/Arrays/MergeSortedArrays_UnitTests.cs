using System.Runtime;
using System.Runtime.InteropServices;
using System.Reflection;
using System;
using Xunit;
using lib.Arrays;

namespace test.Arrays
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/525/inserting-items-into-an-array/3253/
    /// </summary>
    public class MergeSortedArrays_UnitTests
    {
        [Fact]
        public void SimpleTest_TwoSmallArrays()
        {
            //Given
            var nums1 = new int[6] { 1, 3, 5, 0, 0, 0 };
            var nums2 = new int[3] { 2, 4, 6 };
            var m = 3;
            var n = 3;
            
            //When
            new MergeSortedArrays().Go(nums1, m, nums2, n);

            //Then
            var expected = new int[6] { 1, 2, 3, 4, 5, 6 };
            Assert.Equal(expected, nums1);
        }
    }
}