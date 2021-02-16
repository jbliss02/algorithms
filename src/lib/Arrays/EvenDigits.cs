using System.Reflection.Metadata.Ecma335;
using System;

namespace lib
{
    public class EvenDigits
    {
        /// <summary>
        /// https://leetcode.com/explore/learn/card/fun-with-arrays/521/introduction/3237/
        /// </summary>
        /// <returns></returns>
        public int FindNumbers(int[] nums) 
        {
            int result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int a = nums[i];
                int count = 0;

                while (a >= 10)
                {
                    a = a / 10;
                    count++;
                }

                if (count % 2 != 0)
                    result++;
            }    

            return result;
        }

        public int FindNumbers_WithToString(int[] nums) 
        {
            int result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i].ToString().Length % 2 == 0)
                    result++;
            }

            return result;
        }
    }
}