using Shouldly;

namespace Solutions.Test;

public class Problem14Test
{
    [Theory]
    [InlineData(new string[] { "flower", "flow", "flight" }, "fl")]
    [InlineData(new string[] { "dog", "racecar", "car" }, "")]
    public void TestCases(string[] strs, string expected)
    {
        var p = new Problem14();

        var result = p.LongestCommonPrefix(strs);

        result.ShouldBe(expected);
    }
}