using System;
using System.Collections.Generic;

namespace letcodestudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TwoSum(new int[] {1,2,3 },3));
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>(nums.Length);
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(target - nums[i]))
                {
                    return new int[] { dic[target - nums[i]], i };
                }
                else if(!dic.ContainsKey(nums[i])) 
                {
                    dic.Add(nums[i], i);
                }
            }
            return new int[] { -1, -1 };
        }
    }
}
