using System.Security.Cryptography;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Reflection;
using System;
using Xunit;
using lib;

namespace test.Arrays
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/521/introduction/3237/
    /// </summary>
    public class EvenDigits_UnitTests
    {
        [Fact]
        public void SimpleTest_OneLength_IsEven()
        {
            var nums = new int[1] { 22 };
            int result = new EvenDigits().FindNumbers(nums);
            Assert.Equal(1, result);
        }

        [Fact]
        public void SimpleTest_OneLength_IsOdd()
        {
            var nums = new int[1] { 222 };
            int result = new EvenDigits().FindNumbers(nums);
            Assert.Equal(0, result);
        }

        [Fact]
        public void SimpleTest_Mixture_EndsWithEven()
        {
            var nums = new int[5] { 12, 345, 2, 6, 7896 };
            int result = new EvenDigits().FindNumbers(nums);
            Assert.Equal(2, result);
        }

        [Fact]
        public void SimpleTest_Mixture_EndsWithOdd()
        {
            var nums = new int[6] { 12, 345, 21, 6, 654, 786 };
            int result = new EvenDigits().FindNumbers(nums);
            Assert.Equal(2, result);
        }

        [Fact]
        public void EdgeCase_LargeValues()
        {
            var nums = new int[8] { 100000, 3, 21736, 100000, 68654, 7876, 100000, 98789 };
            int result = new EvenDigits().FindNumbers(nums);
            Assert.Equal(4, result);
        }

        [Fact]
        public void EdgeCase_SingleEvenValue()
        {
            var nums = new int[1] { 3894 };
            int result = new EvenDigits().FindNumbers(nums);
            Assert.Equal(1, result);
        }

        [Fact]
        public void EdgeCase_SingleOddValue()
        {
            var nums = new int[1] { 38947 };
            int result = new EvenDigits().FindNumbers(nums);
            Assert.Equal(0, result);
        }

        [Fact]
        public void EdgeCase_Empty()
        {
            var nums = new int[0];
            int result = new EvenDigits().FindNumbers(nums);
            Assert.Equal(0, result);
        }

        [Fact]
        public void EdgeCase_MaximumSizeArray_Even_At_Ends()
        {
            var nums = new int[500];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = 74648;
            }

            nums[0] = 2222;
            nums[499] = 34;

            int result = new EvenDigits().FindNumbers(nums);
            Assert.Equal(2, result);
        }
    }
}