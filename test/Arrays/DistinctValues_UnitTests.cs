using System;
using Xunit;
using src.lib.Arrays;

namespace test.Arrays
{
    /// <summary>
    /// https://app.codility.com/c/run/trainingKWG3ZR-MFV/
    /// </summary>
    public class DistinctValues_UnitTests
    {
        [Fact]
        public void SimpleTest_SingleDigit()
        {
            //Given
            var nums = new int[1] { 1 };
            
            //When
            var result = new DistinctValues().solution(nums);
            
            //Then
            Assert.Equal(1, result);
        }

        [Fact]
        public void SimpleTest_TwoUniqueDigits()
        {
            //Given
            var nums = new int[2] { 1, 2 };
            
            //When
            var result = new DistinctValues().solution(nums);
            
            //Then
            Assert.Equal(2, result);
        }

        [Fact]
        public void SimpleTest_ThreeUniqueWithNegatives()
        {
            //Given
            var nums = new int[3] { -1, 0, -2 };
            
            //When
            var result = new DistinctValues().solution(nums);
            
            //Then
            Assert.Equal(3, result);
        }

        [Fact]
        public void SimpleTest_ThreeWithDupsWithNegatives()
        {
            //Given
            var nums = new int[3] { -1, 0, -1 };
            
            //When
            var result = new DistinctValues().solution(nums);
            
            //Then
            Assert.Equal(2, result);
        }

        [Fact]
        public void SimpleTest_Jumbled()
        {
            //Given
            var nums = new int[6] { 2, 1, 1, 2, 3, 1 };
            
            //When
            var result = new DistinctValues().solution(nums);
            
            //Then
            Assert.Equal(3, result);
        }
    }
}