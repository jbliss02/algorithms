
using Xunit;
using lib.Arrays;

namespace test.Arrays
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/511/in-place-operations/3259/
    /// </summary>
    public class ReplaceGreatest_UnitTests
    {
        [Fact]
        public void SimpleTest_MixedList()
        {
            //Given
            var nums = new int[6] { 17, 18, 5, 4, 6, 1 };
            
            //When
            var result = new ReplaceGreatest().ReplaceElements(nums);
            
            //Then
            var exp = new int[6] { 18, 6, 6, 6, 1, -1 };
            //Assert.Equal(exp, nums);
        }

        [Fact]
        public void SimpleTest_SingleNumber()
        {
            //Given
            var nums = new int[1] { 555 };
            
            //When
            var result = new ReplaceGreatest().ReplaceElements(nums);
            
            //Then
            var exp = new int[1] { -1 };
            Assert.Equal(exp, nums);
        }

        
        [Fact]
        public void SimpleTest_TwoNumbers()
        {
            //Given
            var nums = new int[2] { 555, 666 };
            
            //When
            var result = new ReplaceGreatest().ReplaceElements(nums);
            
            //Then
            var exp = new int[2] { 666, -1 };
            Assert.Equal(exp, nums);
        }

        
        [Fact]
        public void SimpleTest_HighestLastIndex()
        {
            //Given
            var nums = new int[5] { 57010, 40840, 69871, 14425, 70605 };
            
            //When
            var result = new ReplaceGreatest().ReplaceElements(nums);
            
            //Then
            var exp = new int[5] { 70605, 70605, 70605, 70605, -1 };
            Assert.Equal(exp, nums);
        }
    }
}