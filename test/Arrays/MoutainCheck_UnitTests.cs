using Xunit;
using lib.Arrays;

namespace test.Arrays
{
    public class MoutainCheck_UnitTests
    {
        [Fact]
        public void SimpleTest_ShortArray()
        {
            //Given
            var nums = new int[2] { 2, 1 };

            //When
            var result = new MountainCheck().ValidMountainArray(nums);

            //Then
            Assert.False(result);
        }

        [Fact]
        public void SimpleTest_NotMountain()
        {
            //Given
            var nums = new int[3] { 3, 5, 5 };

            //When
            var result = new MountainCheck().ValidMountainArray(nums);

            //Then
            Assert.False(result);
        }

        [Fact]
        public void SimpleTest_SimplestMountain()
        {
            //Given
            var nums = new int[3] { 1, 2, 3 };

            //When
            var result = new MountainCheck().ValidMountainArray(nums);

            //Then
            Assert.True(result);
        }

        [Fact]
        public void SimpleTest_SimpleMountain()
        {
            //Given
            var nums = new int[4] { 0, 3, 2, 1 };

            //When
            var result = new MountainCheck().ValidMountainArray(nums);

            //Then
            Assert.True(result);
        }

        [Fact]
        public void SimpleTest_SimplishMountain()
        {
            //Given
            var nums = new int[7] { 0, 3, 9, 12, 13, 2, 1 };

            //When
            var result = new MountainCheck().ValidMountainArray(nums);

            //Then
            Assert.True(result);
        }

        [Fact]
        public void SimpleTest_FlatPeak()
        {
            //Given
            var nums = new int[8] { 0, 3, 9, 12, 13, 13, 2, 1 };

            //When
            var result = new MountainCheck().ValidMountainArray(nums);

            //Then
            Assert.False(result);
        }

        [Fact]
        public void SimpleTest_FlatLeftHandSide()
        {
            //Given
            var nums = new int[8] { 0, 3, 9, 12, 12, 13, 2, 1 };

            //When
            var result = new MountainCheck().ValidMountainArray(nums);

            //Then
            Assert.False(result);
        }

        [Fact]
        public void SimpleTest_FlatRightHandSide()
        {
            //Given
            var nums = new int[10] { 0, 3, 9, 11, 12, 13, 3, 2, 2, 1 };

            //When
            var result = new MountainCheck().ValidMountainArray(nums);

            //Then
            Assert.False(result);
        }

        [Fact]
        public void SimpleTest_FlatRightHandEdge()
        {
            //Given
            var nums = new int[10] { 0, 3, 9, 11, 12, 13, 8, 6, 3, 3 };

            //When
            var result = new MountainCheck().ValidMountainArray(nums);

            //Then
            Assert.False(result);
        }

        [Fact]
        public void SimpleTest_FlatLeftHandEdge()
        {
            //Given
            var nums = new int[10] { 3, 3, 9, 11, 12, 13, 8, 6, 3, 0 };

            //When
            var result = new MountainCheck().ValidMountainArray(nums);

            //Then
            Assert.False(result);
        }

        [Fact]
        public void SimpleTest_DipsLeft()
        {
            //Given
            var nums = new int[10] { 1, 3, 9, 8, 12, 13, 8, 6, 3, 0 };

            //When
            var result = new MountainCheck().ValidMountainArray(nums);

            //Then
            Assert.False(result);
        }

        [Fact]
        public void SimpleTest_DipsRight()
        {
            //Given
            var nums = new int[10] { 1, 3, 9, 10, 12, 13, 8, 2, 3, 0 };

            //When
            var result = new MountainCheck().ValidMountainArray(nums);

            //Then
            Assert.False(result);
        }
    }
}