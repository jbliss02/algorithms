using System;

namespace lib
{
    public class ArrayLib
    {
        /// <summary>
        /// https://leetcode.com/explore/learn/card/fun-with-arrays/521/introduction/3238/
        /// </summary>
        /// 
        public int Max_Consecutive_Ones(int[] nums)
        { 
            int run = 0;
            int max = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    run++;
                }
                else
                {
                    if (run > max)
                        max = run;

                    run = 0;
                }
            }

            return run > max ? run : max;
        }
        public int Max_Consecutive_Ones_Better(int[] nums)
        { 
            int run = 0;
            int max = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    run++;
                }
                else
                {
                    max = run > max ? run : max;
                    run = 0;
                }
            }

            return run > max ? run : max;
        }
        public int Max_Consecutive_Ones_Slow(int[] A)
        {          
            bool inSequence = false;
            int longestSequence = 0;
            int start = 0;
            int end = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (inSequence == false && A[i] == 1)
                {
                    inSequence = true;
                    start = i;
                }
                else if (inSequence && A[i] == 0)
                {
                    inSequence = false;
                    end = i - 1;

                    var sequenceLength = end - start + 1;

                    longestSequence = this.SetLongestSequence(longestSequence, sequenceLength);
                }
            }   

            if (inSequence)
            {
                var sequenceLength = A.Length - start;

                if (sequenceLength > longestSequence)
                    longestSequence = sequenceLength;
            }

            return longestSequence;
        }

        private int SetLongestSequence(int longestSequence, int sequenceLength)
        {
            return sequenceLength > longestSequence ? sequenceLength : longestSequence;
        }
    }
}
