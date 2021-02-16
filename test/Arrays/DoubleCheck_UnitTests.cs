using System.Runtime;
using System.Runtime.InteropServices;
using System.Reflection;
using System;
using Xunit;
using lib.Arrays;

namespace test.Arrays
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/527/searching-for-items-in-an-array/3250/
    /// </summary>
    public class DoubleCheck_UnitTests
    {
        [Fact]
        public void SimpleTest_DoubleExists()
        {
            //Given
            var nums = new int[4] { 10, 2, 5, 3 };

            //When
            var result = new DoubleCheck().CheckIfExist(nums);

            //Then
            Assert.True(result);
        }

        [Fact]
        public void SimpleTest_DoubleExists_2()
        {
            //Given
            var nums = new int[4] { 7, 1, 14, 11 };

            //When
            var result = new DoubleCheck().CheckIfExist(nums);

            //Then
            Assert.True(result);
        }

        [Fact]
        public void SimpleTest_DoubleDoesNotExist()
        {
            //Given
            var nums = new int[4] { 3, 1, 7, 11 };

            //When
            var result = new DoubleCheck().CheckIfExist(nums);

            //Then
            Assert.False(result);
        }

        [Fact]
        public void SimpleTest_WithNegatives()
        {
            //Given
            var nums = new int[7] { -2, -55, 10, -19, 4, 6, -8 };

            //When
            var result = new DoubleCheck().CheckIfExist(nums);

            //Then
            Assert.False(result);
        }

        [Fact]
        public void SimpleTest_WithNegatives_AndZeros()
        {
            //Given
            var nums = new int[7] { -2, 0, 10, -19, 4, 6, -8 };

            //When
            var result = new DoubleCheck().CheckIfExist(nums);

            //Then
            Assert.False(result);
        }

        [Fact]
        public void SimpleTest_DoubleZero()
        {
            //Given
            var nums = new int[2] { 0, 0 };

            //When
            var result = new DoubleCheck().CheckIfExist(nums);

            //Then
            Assert.True(result);
        }

    }
}