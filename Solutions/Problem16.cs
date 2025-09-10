namespace Solutions;

/*
https://leetcode.com/problems/3sum-closest/

Given an integer array nums of length n and an integer target, find three integers in nums such that the sum is closest to target.

Return the sum of the three integers.

You may assume that each input would have exactly one solution.

Example 1:
    Input: nums = [-1,2,1,-4], target = 1
    Output: 2
    Explanation: The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).

Example 2:
    Input: nums = [0,0,0], target = 1
    Output: 0
    Explanation: The sum that is closest to the target is 0. (0 + 0 + 0 = 0).
 

Constraints:
    3 <= nums.length <= 500
    -1000 <= nums[i] <= 1000
    -104 <= target <= 104
 
Complexity:
    O(n^2) - time
    O(1) - space
*/
public class Problem16
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        if (nums.Length == 3)
        {
            return nums[0] + nums[1] + nums[2];
        }

        Array.Sort(nums);

        int minSum = int.MaxValue;
        int minDiff = int.MaxValue;        

        for (int i = 0; i < nums.Length - 2; i++)
        {
            int left = i + 1;
            int right = nums.Length - 1;
            
            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];
                int diff = sum - target;

                if (Math.Abs(minDiff) > Math.Abs(diff))
                {
                    minSum = sum;
                    minDiff = diff;
                }

                if (diff == 0)
                {
                    break;
                }
                else if (diff < 0)
                {
                    left++;
                }
                else // diff > 0
                {
                    right--;
                }
            }

            if (minSum == 0) break;
        }

        return minSum;
    }
}