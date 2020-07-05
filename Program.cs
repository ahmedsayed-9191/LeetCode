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
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            IList<bool> extraCandiesTakeAbility = new List<bool>();
            for (int counter1 = 0; counter1 < candies.Length; counter1++)
            {
                int candyNewValue = candies[counter1] + extraCandies;
                int greatest = candies[0];
                for (int counter2 = 0; counter2 < candies.Length; counter2++)
                {
                    if (candies[counter2] >= greatest)
                        greatest = candies[counter2];
                }
                if(candyNewValue >= greatest)
                    extraCandiesTakeAbility.Add(true);
                else
                    extraCandiesTakeAbility.Add(false);
            }
            return extraCandiesTakeAbility;
        }
    }
}
