using System;

namespace lib
{
    public class ArrayLib
    {
        /// <summary>
        /// https://leetcode.com/explore/learn/card/fun-with-arrays/521/introduction/3238/
        /// </summary>
        public int Max_Consecutive_Ones(int[] A)
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

                    if (sequenceLength> longestSequence)
                        longestSequence = sequenceLength;
                }
            }   

            return longestSequence;
        }
    }
}
