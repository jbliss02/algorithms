using System.Xml;
using System;

namespace src.lib.Iterations
{
    /// <summary>
    /// https://app.codility.com/programmers/lessons/1-iterations/binary_gap/
    /// </summary>
    public class BinaryGap
    {
        public int solution(int N)
        {
            var bin = Convert.ToString(N, 2);
            int max = 0;
            int currentMax = 0;

            for (int i = 0; i < bin.Length; i++)
            {
                if (bin.Substring(i, 1).Equals("0"))
                    currentMax++;
                else 
                {
                    if (currentMax > max)
                        max = currentMax;

                    currentMax = 0;
                }
            }   

            return max;
        }
    }
}