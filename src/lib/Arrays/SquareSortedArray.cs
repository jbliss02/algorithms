using System.IO;
using System;
using lib;

namespace lib
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/521/introduction/3240/
    /// </summary>
    public class SquareSortedArray
    {
        public int[] Go(int[] nums)
        {
            var result = new int[nums.Length];

            int left = 0;
            int right = nums.Length - 1;
            int nextSlot = nums.Length - 1;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
                {
                    result[nextSlot] = nums[left] * nums[left];
                    nextSlot--;
                    left++;
                }
                else
                {
                    result[nextSlot] = nums[right] * nums[right];
                    nextSlot--;
                    right--;
                }
            } 

            return result;
        }

        public int[] Go_Simple(int[] nums)
        {
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                    nums[i] = -nums[i];
            }

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = nums[i] * nums[i];
            }

            return result;
        }
    }
}