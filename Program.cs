using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class ProblemSet
    {
        public int[] RunningArraySum(int[] nums)
        {
            for (int counter = 1; counter < nums.Length; counter++)
            {
                nums[counter] = nums[counter] + nums[counter - 1];
            }
            return nums;
        }
        public int[] Shuffle(int[] nums, int n)
        {
            int[] shuffledArray = new int[nums.Length];
            int oddCounter = 0, evenCounter = 0;
            for (int counter = 0; counter < nums.Length; counter++)
            {
                if (counter % 2 == 0)
                {
                    shuffledArray[counter] = nums[evenCounter];
                    evenCounter++;
                }
                else
                {
                    shuffledArray[counter] = nums[oddCounter + n];
                    oddCounter++;
                }
            }
            return shuffledArray;
        }
    }
}
