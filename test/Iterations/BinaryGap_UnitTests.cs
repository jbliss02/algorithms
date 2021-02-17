using System;
using Xunit;
using src.lib.Iterations;

namespace test.Iterations
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/1-iterations/binary_gap/
    /// </summary>
    public class BinaryGap_UnitTests
    {
        [Fact]
        public void SimpleTest_9()
        {
            var n = 9;

            var result = new BinaryGap().solution(n);

            Assert.Equal(2, result);
        }

        [Fact]
        public void SimpleTest_529()
        {
            var n = 529;

            var result = new BinaryGap().solution(n);

            Assert.Equal(4, result);
        }

        [Fact]
        public void SimpleTest_20()
        {
            var n = 20;

            var result = new BinaryGap().solution(n);

            Assert.Equal(1, result);
        }

        [Fact]
        public void SimpleTest_15()
        {
            var n = 15;

            var result = new BinaryGap().solution(n);

            Assert.Equal(0, result);
        }

        [Fact]
        public void SimpleTest_32()
        {
            var n = 32;

            var result = new BinaryGap().solution(n);

            Assert.Equal(0, result);
        }

        [Fact]
        public void EdgeTest_BigInt()
        {
            var n = Int32.MaxValue - 36339;

            var result = new BinaryGap().solution(n);

            Assert.Equal(5, result);
        }

        [Fact]
        public void EdgeTest_MaxInt()
        {
            var n = Int32.MaxValue;

            var result = new BinaryGap().solution(n);

            Assert.Equal(0, result);
        }

        [Fact]
        public void EdgeTest_32t()
        {
            var n = 32;

            var result = new BinaryGap().solution(n);

            Assert.Equal(0, result);
        }
    }
}