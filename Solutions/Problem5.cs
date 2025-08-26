namespace Solutions;

/*
https://leetcode.com/problems/longest-palindromic-substring/description/

Given a string s, return the longest palindromic substring in s.

Example 1:
    Input: s = "babad"
    Output: "bab"
    Explanation: "aba" is also a valid answer.

Example 2:
    Input: s = "cbbd"
    Output: "bb"
 

Constraints:
    1 <= s.length <= 1000
    s consist of only digits and English letters.
*/
public class Problem5
{
    public string LongestPalindrome(string s)
    {
        var source = s.AsSpan();
        ReadOnlySpan<char> longestPolindrome = source.Slice(0, 1);

        for (int i = 1; i <= s.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                var slice = source.Slice(j, i - j);
                if (isPalindrome(slice) && longestPolindrome.Length < i - j)
                {
                    longestPolindrome = slice;
                }
            }
        }

        return longestPolindrome.ToString();
    }

    private static bool isPalindrome(ReadOnlySpan<char> input)
    {
        int left = 0;
        int right = input.Length - 1;

        while (left < right)
        {
            if (input[left++] != input[right--])
            {
                return false;
            }
        }

        return true;
    }
}