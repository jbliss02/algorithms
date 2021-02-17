using Xunit;
using lib.Hash;

namespace test.Hash
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/hash-table/183/combination-with-other-algorithms/1176/
    /// </summary>
    public class SingleNumber_UnitTests
    {
        [Fact]
        public void SimpleTest_OneSingleNumber()
        {
            //Given
            var nums = new int[3] { 2, 2, 1 };
            
            //When
            var result = new SingleNumbers().SingleNumber(nums);
            
            //Then
            Assert.Equal(1, result);
        }

        [Fact]
        public void SimpleTest_FourSingleNumber()
        {
            //Given
            var nums = new int[5] { 4, 1, 2, 1, 2 };
            
            //When
            var result = new SingleNumbers().SingleNumber(nums);
            
            //Then
            Assert.Equal(4, result);
        }

        [Fact]
        public void SimpleTest_SingleArray()
        {
            //Given
            var nums = new int[1] { 4 };
            
            //When
            var result = new SingleNumbers().SingleNumber(nums);
            
            //Then
            Assert.Equal(4, result);
        }
    }
}