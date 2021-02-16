using System.Runtime;
using System.Runtime.InteropServices;
using System.Reflection;
using System;
using Xunit;
using lib.Arrays;

namespace test.Arrays
{
    public class RemoveDuplicates_UnitTests
    {
        [Fact]
        public void SimpleTest_SingleRemoval()
        {
            //Given
            var nums = new int[3] { 1, 1, 2 };
            
            //When
            var result = new RemoveDuplicates().Go(nums);

            //Then
            Assert.Equal(2, result);
            Assert.Equal(nums[0], 1); 
            Assert.Equal(nums[1], 2); 
        }

        [Fact]
        public void SimpleTest_MultipleRemoval()
        {
            //Given
            var nums = new int[10] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            
            //When
            var result = new RemoveDuplicates().Go(nums);

            //Then
            Assert.Equal(5, result);
            Assert.Equal(nums[0], 0); 
            Assert.Equal(nums[1], 1); 
            Assert.Equal(nums[2], 2); 
            Assert.Equal(nums[3], 3); 
            Assert.Equal(nums[4], 4); 
        }
    }
}