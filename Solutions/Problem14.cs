namespace Solutions;

/*
https://leetcode.com/problems/longest-common-prefix/

Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".
 

Example 1:
    Input: strs = ["flower","flow","flight"]
    Output: "fl"

Example 2:
    Input: strs = ["dog","racecar","car"]
    Output: ""
    Explanation: There is no common prefix among the input strings.
 

Constraints:
    1 <= strs.length <= 200
    0 <= strs[i].length <= 200
    strs[i] consists of only lowercase English letters if it is non-empty.
*/
public class Problem14
{
    public string LongestCommonPrefix(string[] strs)
    {
        int minLength = Int32.MaxValue;
        for (int i = 0; i < strs.Length; i++)
        {
            minLength = Math.Min(minLength, strs[i].Length);
        }

        for (int j = 0; j < minLength; j++)
        {
            for (int i = 1; i < strs.Length; i++)
            {
                if (strs[0][j] != strs[i][j])
                {
                    if (j == 0)
                    {
                        return string.Empty;
                    }
                    else
                    {
                        return strs[0].Substring(0, j);
                    }
                }
            }
        }

        return strs[0].Substring(0, minLength);
    }
}