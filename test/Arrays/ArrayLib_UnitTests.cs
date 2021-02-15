using System.Runtime;
using System.Runtime.InteropServices;
using System.Reflection;
using System;
using Xunit;
using lib;

namespace test.Arrays
{
    public class UnitTest1
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
    }
}