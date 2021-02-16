using System;

namespace lib.Arrays
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/525/inserting-items-into-an-array/3245/
    /// </summary>
    public class DuplicateZeros
    {
        public void Go(int[] nums)
        {
            int index = 0;

            while (index < nums.Length - 1)
            {
                if (nums[index] == 0)
                {
                    for (int i = nums.Length - 2; i > index; i--)
                    {
                        nums[i + 1] = nums[i];
                    }

                    nums[index + 1] = 0;

                    index++;
                }
                index++;
            }
        }

        public void SimpleBackwardsIteration(int[] nums)
        {
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                if (nums[i] == 0)
                {
                    for (int k = nums.Length - 2; k > i; k--)
                    {
                        nums[k + 1] = nums[k];
                    }

                    nums[i + 1] = 0;
                }              
            }
        }
    }
}