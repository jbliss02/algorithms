using System;
using Xunit;
using src.lib.Arrays;

namespace test.Arrays
{
    public class SmallestPositive_UnitTests
    {
        [Fact]
        public void SimpleTest_1()
        {
            var nums = new int[6] { 1, 3, 6, 4, 1, 2 };

            var result = new SmallestPositive().solution(nums);

            Assert.Equal(5, result);
        }

        [Fact]
        public void SimpleTest_2()
        {
            var nums = new int[3] { 1, 2, 3 };

            var result = new SmallestPositive().solution(nums);

            Assert.Equal(4, result);
        }

        [Fact]
        public void SimpleTest_3()
        {
            var nums = new int[2] { -1, -2 };

            var result = new SmallestPositive().solution(nums);

            Assert.Equal(1, result);
        }

    }
}