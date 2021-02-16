namespace lib.Arrays
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/526/deleting-items-from-an-array/3247/
    /// </summary>
    public class RemoveElement
    {
        public int Go(int[] nums, int val) 
        {
            var taken = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    if (taken != i)
                        nums[taken] = nums[i];

                    taken++;
                }
            }

            return taken;
        }


        public int Go_DealsWithDoubles(int[] nums, int val) 
        {
            var removed = 0;

            for (int i = 0; i < nums.Length - removed; i++)
            {
                while (nums[i] == val)
                {
                    removed++;

                    if (removed + i == nums.Length)
                        break;

                    for (int j = i; j < nums.Length - removed; j++)
                    {
                        nums[j] = nums[j + 1];
                    }
                }
            }

            return nums.Length - removed;
        }
    }
}