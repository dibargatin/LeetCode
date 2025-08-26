using Shouldly;

namespace Solutions.Test;

public class Problem5Test
{
    [Theory]
    [InlineData("babad", "bab")]
    [InlineData("cbbd", "bb")]
    public void TestCases(string s, string expected)
    {
        var p = new Problem5();

        var result = p.LongestPalindrome(s);

        result.ShouldBe(expected);
    }
}