using System;

namespace lib.Arrays
{
    public class MergeSortedArrays
    {
        /// <summary>
        /// https://leetcode.com/explore/learn/card/fun-with-arrays/525/inserting-items-into-an-array/3253/
        /// </summary>
        public void Go(int[] nums1, int m, int[] nums2, int n)
        {
            var result = new int[nums1.Length];

            var array1 = 0;
            var array2 = 0;

            for (int i = 0; i < result.Length; i++)
            {
                if (array1 == m)
                {
                    result[i] = nums2[array2];
                    array2++;
                    continue;
                }
                else if (array2 == n)
                {
                    result[i] = nums1[array1];
                    array1++;
                    continue;
                }
                    
                if (nums1[array1] < nums2[array2])
                {
                    result[i] = nums1[array1];
                    array1++;
                }
                else {
                    result[i] = nums2[array2];
                    array2++;
                }
            }

            Array.Copy(result, nums1, nums1.Length);
        }
    }
}