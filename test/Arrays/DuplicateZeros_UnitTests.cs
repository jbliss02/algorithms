using System.Runtime;
using System.Runtime.InteropServices;
using System.Reflection;
using System;
using Xunit;
using lib.Arrays;

namespace test.Arrays
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/525/inserting-items-into-an-array/3245/
    /// </summary>
    public class DuplicateZeros_UnitTests
    {
        [Fact]
        public void SimpleTest_SomeZeros()
        {
            var nums = new int[8] { 1, 0, 2, 3, 0, 4, 5, 0 };
            new DuplicateZeros().Go(nums);

            var result = new int[8] { 1, 0, 0, 2, 3, 0, 0, 4 };
            Assert.Equal(nums, result);
        }

        [Fact]
        public void SimpleTest_NoZeros()
        {
            var nums = new int[3] { 1, 2, 3};
            new DuplicateZeros().Go(nums);

            var result = new int[3] { 1, 2, 3};
            Assert.Equal(nums, result);
        }

        [Fact]
        public void EdgeTest_StartsWithZeros()
        {
            var nums = new int[10] { 0, 1, 0, 2, 3, 0, 4, 5, 0, 8 };
            new DuplicateZeros().Go(nums);

            var result = new int[10] { 0, 0, 1, 0, 0, 2, 3, 0, 0, 4 };
            Assert.Equal(nums, result);
        }

        [Fact]
        public void EdgeTest_EndsWithZeros()
        {
            var nums = new int[10] { 0, 1, 0, 2, 3, 0, 4, 5, 0, 0 };
            new DuplicateZeros().Go(nums);

            var result = new int[10] { 0, 0, 1, 0, 0, 2, 3, 0, 0, 4 };
            Assert.Equal(nums, result);
        }

        [Fact]
        public void EdgeTest_StartsWithZeros_NoMoreZeros()
        {
            var nums = new int[10] { 0, 1, 8, 2, 3, 10, 4, 5, 30, 50 };
            new DuplicateZeros().Go(nums);

            var result = new int[10] { 0, 0, 1, 8, 2, 3, 10, 4, 5, 30 };
            Assert.Equal(nums, result);
        }


        [Fact]
        public void EdgeTest_StartsAllZeros()
        {
            var nums = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            new DuplicateZeros().Go(nums);

            var result = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Assert.Equal(nums, result);
        }

        [Fact]
        public void EdgeTest_ManyInitialZeros()
        {
            var nums = new int[10] { 0, 0, 0, 0, 4, 8, 0, 0, 0, 0 };
            new DuplicateZeros().Go(nums);

            var result = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 4, 8 };
            Assert.Equal(nums, result);
        }
        
        [Fact]
        public void EdgeTest_ManyInitialZeros2()
        {
            var nums = new int[10] { 0, 0, 0, 0, 4, 0, 1, 0, 0, 0 };
            new DuplicateZeros().Go(nums);

            var result = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 4, 0 };
            Assert.Equal(nums, result);
        }
            
    }
}