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

        [Fact]
        public void SimpleTest_OneEmptyArray()
        {
            //Given
            var nums1 = new int[1] { 1 };
            var nums2 = new int[0];
            var m = 1;
            var n = 0;
            
            //When
            new MergeSortedArrays().Go(nums1, m, nums2, n);

            //Then
            var expected = new int[1] { 1 };
            Assert.Equal(expected, nums1);
        }

        [Fact]
        public void SimpleTest_NonCrossOverArrays()
        {
            //Given
            var nums1 = new int[9] { 1, 3, 5, 9, 12, 15, 0, 0, 0 };
            var nums2 = new int[3] { 22, 34, 36 };
            var m = 6;
            var n = 3;
            
            //When
            new MergeSortedArrays().Go(nums1, m, nums2, n);

            //Then
            var expected = new int[9] { 1, 3, 5, 9, 12, 15, 22, 34, 36 };
            Assert.Equal(expected, nums1);
        }
        
        [Fact]
        public void SimpleTest_NonCrossOverArrays_Backwards()
        {
            //Given
            var nums1 = new int[9] { 21, 23, 25, 39, 412, 515, 0, 0, 0 };
            var nums2 = new int[3] { 2, 4, 6 };
            var m = 6;
            var n = 3;
            
            //When
            new MergeSortedArrays().Go(nums1, m, nums2, n);

            //Then
            var expected = new int[9] { 2, 4, 6, 21, 23, 25, 39, 412, 515 };
            Assert.Equal(expected, nums1);
        }

        [Fact]
        public void EdgeTest_SomeEqualNumbers()
        {
            //Given
            var nums1 = new int[9] { 1, 2, 6, 39, 412, 515, 0, 0, 0 };
            var nums2 = new int[3] { 2, 4, 6 };
            var m = 6;
            var n = 3;
            
            //When
            new MergeSortedArrays().Go(nums1, m, nums2, n);

            //Then
            var expected = new int[9] { 1, 2, 2, 4, 6, 6, 39, 412, 515 };
            Assert.Equal(expected, nums1);
        }
    }
}