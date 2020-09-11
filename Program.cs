using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] N = new int[] { -6,-91,1011,-100,84,-22,0,1,473 };
            int result = new ProblemSet().max(N);
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
                if (candyNewValue >= greatest)
                    extraCandiesTakeAbility.Add(true);
                else
                    extraCandiesTakeAbility.Add(false);
            }
            return extraCandiesTakeAbility;
        }
        public string DefangIPaddr(string address)
        {
            return address.Replace(".", @"[.]");
        }
        public string DefangIPaddrV2(string address)
        {
            string[] array = address.Split('.');
            string defangedIP = "";
            for (int count = 0; count < (array.Length) - 1; count++)
            {
                defangedIP = defangedIP + array[count] + "[.]";
            }
            return defangedIP + array[array.Length - 1];
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
        public int SubtractProductAndSum(int n)
        {
            int product = 1, sum = 0;
            while (n > 0)
            {
                var digit = n % 10;
                n /= 10;
                product *= digit;
                sum += digit;
            }
            return product - sum;
        }
        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            var target = new List<int>();
            for (int counter = 0; counter < nums.Length; counter++)
            {
                target.Insert(index[counter], nums[counter]);
            }
            return target.ToArray();
        }
        public int BalancedStringSplit(string s)
        {
            int count = 0, sum = 0;
            for (int counter = 0; counter < s.Length; counter++)
            {
                if (s[counter] == 'L')
                    sum++;
                else
                    sum--;
                if (sum == 0)
                {
                    count++;
                    sum = 0;
                }
            }
            return count;
        }
        public int FindNumbers(int[] nums)
        {
            int evenNums = 0;
            for (int counter = 0; counter < nums.Length; counter++)
            {
                int digitCount = 0;
                while (nums[counter] > 0)
                {
                    nums[counter] /= 10;
                    digitCount++;
                }
                if (digitCount % 2 == 0)
                    evenNums++;
            }
            return evenNums;
        }
        public int SmallestPositive(int[] A)
        {
            int smallestpos = 1;
            Array.Sort(A);
            for (int counter = 0; counter < A.Length; counter++)
                if (A[counter] > 0 && A[counter] >= smallestpos && A.Contains(smallestpos))
                    smallestpos = A[counter] + 1;
            return smallestpos;
        }
        public int maxValuebyadding5(int N)
        {
            var digites = new Stack<int>();
            int? result = null;
            bool inserted = false;
            if (N < 0)
                return int.Parse(-5 + String.Format("{0:0}", Math.Abs(N)));
            if (N == 0)
                digites.Push(N);
            while (N > 0)
            {
                var digit = N % 10;
                N /= 10;
                digites.Push(digit);
            }
            var list = digites.ToList();
            int IndexOfMinDigit = list.IndexOf(digites.Min());
            while (digites.Count > 0)
            {
                if (digites.FirstOrDefault() == list[IndexOfMinDigit] && !inserted)
                {
                    result = int.Parse(result.ToString() + 5);
                    inserted = true;
                }
                else
                {
                    int poped_digit = digites.Pop();
                    result = int.Parse(result.ToString() + poped_digit);
                }
            }
            return (int)result;
        }
        public int max(int[] N)
        {
            int maximum = 0;
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            for (int counter = 0; counter < N.Length; counter++)
            {
                if (N[counter] % 10 == 1)
                {
                    Console.WriteLine("number = {0}", N[counter]);
                }
            }
            return maximum;
        }
}
}
