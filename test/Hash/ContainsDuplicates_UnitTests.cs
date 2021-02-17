using Xunit;
using lib.Arrays;
using lib.Hash;

namespace test.Hash
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/hash-table/183/combination-with-other-algorithms/1112/
    /// </summary>
    public class ContainsDuplicates_UnitTests
    {
        [Fact]
        public void SimpleTest_OneDuplicate()
        {
            //Given
            var nums = new int[] { 1, 2, 2, 3 };
            
            //When
            var result = new ContainsDuplicates().ContainsDuplicate(nums);

            //Then
            Assert.True(result);
        }

        [Fact]
        public void SimpleTest_NoDuplicate()
        {
            //Given
            var nums = new int[] { 0, 1, 2, 3, 4 };
            
            //When
            var result = new ContainsDuplicates().ContainsDuplicate(nums);

            //Then
            Assert.False(result);
        }

        [Fact]
        public void SimpleTest_ManyDuplicate()
        {
            //Given
            var nums = new int[] { 1, 2, 3, 4, 4, 4, 4, 4, 5, 5, 5, 6 };
            
            //When
            var result = new ContainsDuplicates().ContainsDuplicate(nums);

            //Then
            Assert.True(result);
        }

        [Fact]
        public void SimpleTest_DuplicateStartAndEnd()
        {
            //Given
            var nums = new int[] { 1, 2, 3, 4, 5, 1 };
            
            //When
            var result = new ContainsDuplicates().ContainsDuplicate(nums);

            //Then
            Assert.True(result);
        }
    }
}