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
    }
}
