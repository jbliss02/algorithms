namespace lib.Arrays
{
    /// <summary>
    /// https://leetcode.com/explore/learn/card/fun-with-arrays/511/in-place-operations/3259/
    /// </summary>
    public class ReplaceGreatest
    {        
        public int[] ReplaceElements(int[] arr) 
        {
            if (arr.Length == 0)
            {
                return arr;
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int max = arr[i + 1];

                for (int j = i + 2; j < arr.Length; j++)
                {
                    if (arr[j] > max)
                        max = arr[j];
                }

                arr[i] = max;
            }

            arr[arr.Length - 1] = -1;

            return arr;
        }
    }
}