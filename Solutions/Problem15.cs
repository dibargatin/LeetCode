using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

namespace Solutions;

/*
https://leetcode.com/problems/3sum/

Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] 
such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

Notice that the solution set must not contain duplicate triplets.
 

Example 1:
    Input: nums = [-1,0,1,2,-1,-4]
    Output: [[-1,-1,2],[-1,0,1]]
    Explanation: 
        nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
        nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
        nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
        The distinct triplets are [-1,0,1] and [-1,-1,2].
        Notice that the order of the output and the order of the triplets does not matter.

Example 2:
    Input: nums = [0,1,1]
    Output: []
    Explanation: The only possible triplet does not sum up to 0.

Example 3:
    Input: nums = [0,0,0]
    Output: [[0,0,0]]
    Explanation: The only possible triplet sums up to 0.
    
Constraints:
    3 <= nums.length <= 3000
    -10^5 <= nums[i] <= 10^5
*/
public class Problem15
{
    /*
    Second Solution:
        O(n^2) - time
        O(n) - space
    */
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var result = new List<IList<int>>();

        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }

            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum == 0)
                {
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });

                    int prev = nums[left];
                    while (prev == nums[++left] && left < right) ;
                }
                else if (sum < 0)
                {
                    left++;
                }
                else if (sum > 0)
                {
                    right--;
                }
                else break;
            }
        }

        return result;
    }

    /*
    First Solution:
        O((n^2)*logn) - time (could be better)
        O(n) - space
    */
    public IList<IList<int>> ThreeSum1(int[] nums)
    {
        Array.Sort(nums);

        var result = new HashSet<(int, int, int)>();

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 2; j < nums.Length; j++)
            {
                int sum = nums[i] + nums[j];
                int mid = Search(nums, i + 1, j - 1, sum * -1);

                if (mid != -1)
                {
                    result.Add((nums[i], nums[mid], nums[j]));
                }
            }
        }

        var list = new List<IList<int>>(result.Count);

        foreach ((int l, int m, int r) in result)
        {
            list.Add(new List<int> { l, m, r });
        }

        return list;
    }

    private static int Search(int[] nums, int from, int to, int target)
    {
        int left = from;
        int right = to;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target) return mid;
            else if (nums[mid] < target) left = mid + 1;
            else right = mid - 1;
        }

        return -1;
    }
}