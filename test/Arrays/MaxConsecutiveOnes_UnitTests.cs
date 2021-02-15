using System.Runtime;
using System.Runtime.InteropServices;
using System.Reflection;
using System;
using Xunit;
using lib;

namespace test.Arrays
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/521/introduction/3238/
    /// </summary>
    public class MaxConsecutiveOnes_UnitTests
    {
        [Fact]
        public void SimpleTest_StartsWith1s()
        {
            var A = new int[7] { 1, 1, 1, 1, 0, 1, 1 };
            int result = new ArrayLib().Max_Consecutive_Ones(A);
            Assert.Equal(4, result);
        }

        [Fact]
        public void SimpleTest_EndWith1s()
        {
            var A = new int[8] { 0, 1, 0, 1, 1, 1, 1, 1 };
            int result = new ArrayLib().Max_Consecutive_Ones(A);
            Assert.Equal(5, result);
        
        }

        [Fact]
        public void SimpleTest_1sInMiddle()
        {
            var A = new int[14] { 0, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 0, 0, 1 };
            int result = new ArrayLib().Max_Consecutive_Ones(A);
            Assert.Equal(5, result);
        }

        [Fact]
        public void SimpleTest_1sInMiddle_StartsAndEndsWith0s()
        {
            var A = new int[14] { 0, 1, 0, 1, 1, 1, 1, 0, 0, 1, 1, 0, 0, 0 };
            int result = new ArrayLib().Max_Consecutive_Ones(A);
            Assert.Equal(4, result);
        }

        [Fact]
        public void SimpleTest_1sInMiddle_StartsAndEndsWith1s()
        {
            var A = new int[14] { 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 0, 0, 1 };
            int result = new ArrayLib().Max_Consecutive_Ones(A);
            Assert.Equal(5, result);
        }

        [Fact]
        public void EdgeTest_AllZeros()
        {
            var A = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
            int result = new ArrayLib().Max_Consecutive_Ones(A);
            Assert.Equal(0, result);
        }

        
        [Fact]
        public void EdgeTest_AllOnes()
        {
            var A = new int[10] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int result = new ArrayLib().Max_Consecutive_Ones(A);
            Assert.Equal(A.Length, result);
        }

        [Fact]
        public void EdgeTest_SingleOne()
        {
            var A = new int[1] { 1 };
            int result = new ArrayLib().Max_Consecutive_Ones(A);
            Assert.Equal(1, result);
        }
        
        [Fact]
        public void EdgeTest_SingleZero()
        {
            var A = new int[1] { 0 };
            int result = new ArrayLib().Max_Consecutive_Ones(A);
            Assert.Equal(0, result);
        }

        [Fact]
        public void EdgeTest_Empty()
        {
            var A = new int[0];
            int result = new ArrayLib().Max_Consecutive_Ones(A);
            Assert.Equal(0, result);
        }

        [Fact]
        public void EdgeTest_Null()
        {
            var A = new int[0];
            int result = new ArrayLib().Max_Consecutive_Ones(A);
            Assert.Equal(0, result);
        }

        [Fact]
        public void EdgeTest_LongArray()
        {
            var A = new int[10000];

            int sequence = 45;
            for (int i = 1863; i < 1863 + sequence; i++)
            {
                A[i] = 1;
            }

            int result = new ArrayLib().Max_Consecutive_Ones(A);
            Assert.Equal(sequence, result);
        }
    }
}