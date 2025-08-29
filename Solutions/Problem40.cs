namespace Solutions;

/*
https://leetcode.com/problems/combination-sum-ii/description/

Given a collection of candidate numbers (candidates) and a target number (target), find all unique combinations in candidates 
where the candidate numbers sum to target.

Each number in candidates may only be used once in the combination.

Note: The solution set must not contain duplicate combinations.

Example 1:
    Input: candidates = [10,1,2,7,6,1,5], target = 8
    Output: 
    [
        [1,1,6],
        [1,2,5],
        [1,7],
        [2,6]
    ]

Example 2:
    Input: candidates = [2,5,2,1,2], target = 5
    Output: 
    [
        [1,2,2],
        [5]
    ]
 

Constraints:
    1 <= candidates.length <= 100
    1 <= candidates[i] <= 50
    1 <= target <= 30
*/
public class Problem40
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        var result = new List<IList<int>>();
        var temp = new List<IList<int>>();

        Array.Sort(candidates);

        foreach (var num in candidates)
        {
            int tempCount = temp.Count;

            for (int i = -1; i < tempCount; i++)
            {
                var item = i == -1
                    ? new List<int>()
                    : new List<int>(temp[i]);
                item.Add(num);

                var sum = item.Sum();

                if (sum == target)
                {
                    if (!result.Any(t => IsSame(t, item)))
                        result.Add(item);
                }
                else if (sum < target && !temp.Any(t => IsSame(t, item)))
                {
                    temp.Add(item);
                }
            }
        }

        return result;
    }

    private static bool IsSame(IList<int> a, IList<int> b)
    {
        if (a.Count != b.Count) return false;

        var dict = new Dictionary<int, int>();

        for (int i = 0; i < a.Count; i++)
        {
            if (dict.ContainsKey(a[i]))
            {
                dict[a[i]]++;
            }
            else
            {
                dict[a[i]] = 1;
            }

            if (dict.ContainsKey(b[i]))
            {
                dict[b[i]]--;
            }
            else
            {
                dict[b[i]] = -1;
            }
        }

        return dict.All(item => item.Value == 0);
    }
}