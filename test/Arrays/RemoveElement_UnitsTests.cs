using System.Reflection.Metadata;
using System.Configuration.Assemblies;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Reflection;
using System;
using Xunit;
using lib.Arrays;

namespace test.Arrays
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/526/deleting-items-from-an-array/3247/
    /// </summary>
    public class RemoveElement_UnitsTests
    {
        [Fact]
        public void SimpleTest_EasyRemove()
        {
            //Given
            var nums = new int[4] { 3, 2, 2, 3 };

            //When
            var result = new RemoveElement().Go(nums, 3);

            //Then
            Assert.Equal(2, result);
            Assert.Equal(2, nums[0]);
            Assert.Equal(2, nums[1]);
        }

        [Fact]
        public void SimpleTest_EasyRemove2()
        {
            //Given
            var nums = new int[8] { 0, 1, 2, 2, 3, 0, 4, 2 };

            //When
            var result = new RemoveElement().Go(nums, 2);

            //Then
            Assert.Equal(5, result);
        }
    }
}