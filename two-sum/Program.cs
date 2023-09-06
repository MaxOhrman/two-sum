using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

namespace two_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int target = 21;

            int[] myInt = solution.TwoSum(new int[] { 15, 1, 6 }, target);

        }
    }



    //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    //You may assume that each input would have exactly one solution, and you may not use the same element twice.
    //You can return the answer in any order.

    public class Solution
    {

        public int[] TwoSum(int[] nums, int target)
        {


            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            return new int[] { i, j };
                        }
                    }
                }
            }
            return Array.Empty<int>();
        }
    }
}