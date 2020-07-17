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
            int[] nums = new[] { 1, 2, 3, 4 };
            int[] result = new int[nums.Length];
            int[] expected = new[] { 2, 4, 4, 4 };
            result = new ProblemSet().DecompressRLElist(nums);
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
        public string DefangIPaddr(string address)
        {
            return address.Replace(".",@"[.]");
        }
        public string DefangIPaddrV2(string address)
        {
            string[] array= address.Split('.');
            string defangedIP="";
            for(int count = 0; count < (array.Length)-1; count++)
            {
                defangedIP = defangedIP + array[count] + "[.]";
            }          
            return defangedIP + array[array.Length-1];
        }
        public int XorOperation(int n, int start)
        {
            int[] nums = new int[n];
            int result = 0;
            for (int counter = 0; counter < n; counter++)
            {
                nums[counter] = start + 2 * counter;
                result ^= nums[counter];
            }        
            return result;
        }
        public int NumberOfSteps(int num)
        {
            int stepsNum = 0;
            while (num > 0)
            {
                if (num % 2 == 0)
                    num /= 2;
                else
                    num--;
                stepsNum++;
            }
            return stepsNum;
        }
        public int NumJewelsInStones(string J, string S)
        {
            char[] myStones = S.ToCharArray();
            int jewelsNum = 0;
            foreach (char stone in myStones)
                if (J.Contains(stone))
                    jewelsNum++;
            return jewelsNum;

        }
        public int NumJewelsInStonesV2(string J, string S)
        {
            char[] stonesTypes = J.ToCharArray();
            return S.Count(stonesTypes.Contains);
        }
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] newnums = new int[nums.Length];
            for (int counter1 = 0; counter1 < nums.Length; counter1++)
                for (int counter2 = 0; counter2 < nums.Length; counter2++)
                    if (counter2 != counter1 && nums[counter2] < nums[counter1])
                        newnums[counter1]++;
            return newnums;
        }
        public int[] SmallerNumbersThanCurrentV2(int[] nums)
        {
            int[] newnums = new int[nums.Length];
            int[] sortednums = new int[nums.Length];
            sortednums = new List<int>(nums).ToArray();
            Array.Sort(sortednums);
            for (int counter = 0; counter < sortednums.Length; counter++)
                newnums[counter] = Array.IndexOf(sortednums, nums[counter]);
            return newnums;
        }
        public int[] DecompressRLElist(int[] nums)
        {
            var list = new List<int>();
            for (int counter = 0; counter < nums.Length; counter += 2)
                for (int counter2 = 0; counter2 < nums[counter]; counter2++)
                    list.Add(nums[counter + 1]);
            return list.ToArray();
        }
    }
}
