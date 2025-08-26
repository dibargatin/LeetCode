using Shouldly;

namespace Solutions.Test;

public class Problem3Test
{
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    public void TestCases(string s, int expected)
    {
        var p = new Problem3();

        var result = p.LengthOfLongestSubstring(s);

        result.ShouldBe(expected);
    }
}