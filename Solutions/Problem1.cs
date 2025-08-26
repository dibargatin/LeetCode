namespace Solutions;

/*
https://leetcode.com/problems/two-sum/description/

Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.
*/
public class Problem1
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];

            if (dict.ContainsKey(diff))
            {
                return new[] { dict[diff], i };
            }
            else
            {
                dict[nums[i]] = i;
            }
        }
        throw new Exception();
    }
}
